using Domain.DTO;
using Domain.Interfaces.UoW;
using Domain.Models;
using GameLibraryV2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using static Domain.Enums.DomainEnums;

namespace DatingBack.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;

        public AuthController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        [HttpPost("/register")]
        public async Task<IActionResult> Register([FromBody] UserRegister userRegister, CancellationToken ct)
        {
            if (userRegister == null)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            userRegister.TelephoneNumber = userRegister.TelephoneNumber.Trim();
            if (userRegister.TelephoneNumber.StartsWith('8'))
            {
                userRegister.TelephoneNumber = string.Concat("+7", userRegister.TelephoneNumber.AsSpan(1));
            }

            if (await _unitOfWork.UserRepository.HaveThisPhoneNumberAsync(userRegister.TelephoneNumber))
            {
                return BadRequest("This Telephone Already Registred");
            }

            var userMap = new User
            {
                Name = userRegister.Name,
                Surname = userRegister.Surname,
                TelephoneNumber = userRegister.TelephoneNumber,
                Password = BCrypt.Net.BCrypt.HashPassword(userRegister.Password),
                Sex = userRegister.Sex,
                Role = Roles.User
            };

            _unitOfWork.UserRepository.Add(userMap);
            await _unitOfWork.SaveAsync(ct);

            return Ok(userMap.Id);
        }

        [HttpPost("/login")]
        public async Task<IActionResult> Login([FromBody] UserLogin userLogin, CancellationToken ct)
        {
            if (userLogin == null)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            userLogin.TelephoneNumber = userLogin.TelephoneNumber.Trim();
            if (userLogin.TelephoneNumber.StartsWith('8'))
            {
                userLogin.TelephoneNumber = string.Concat("+7", userLogin.TelephoneNumber.AsSpan(1));
            }

            if (!await _unitOfWork.UserRepository.HaveThisPhoneNumberAsync(userLogin.TelephoneNumber))
                return NotFound($"Not found user with such telephone");

            var user = await _unitOfWork.UserRepository.GetAsync(x => x.TelephoneNumber == userLogin.TelephoneNumber, ct);

            if (!ValidatePassword(userLogin.Password, user!.Password))
                return BadRequest("Wrong Password");


            string token = CreateToken(user);

            var refreshToken = GenerateRefreshToken();
            SetRefreshToken(refreshToken, user);

            _unitOfWork.UserRepository.Update(user);
            await _unitOfWork.SaveAsync(ct);
            return Ok(token);
        }

        [HttpPost("/refreshToken")]
        public async Task<IActionResult> RefreshToken([FromQuery] Guid userId, CancellationToken ct)
        {
            var refreshToken = Request.Cookies["refreshToken"];

            if (!await _unitOfWork.UserRepository.AnyAsync(x => x.Id == userId, ct))
                return NotFound($"Not found user with such id {userId}");

            var user = await _unitOfWork.UserRepository.GetAsync(userId, ct);

            if (!user!.RefreshToken.Equals(refreshToken))
                return Unauthorized("Invalid Refresh Token");
            else if (user.TokenExpires < DateTime.Now)
                return Unauthorized("Token expired");

            string token = CreateToken(user);
            var newRefreshToken = GenerateRefreshToken();
            SetRefreshToken(newRefreshToken, user);

            _unitOfWork.UserRepository.Update(user);
            await _unitOfWork.SaveAsync(ct);

            return Ok(token);
        }


        private static RefreshToken GenerateRefreshToken()
        {
            var refreshToken = new RefreshToken
            {
                Token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
                Expires = DateTime.Now.AddDays(7)
            };
            return refreshToken;
        }

        private void SetRefreshToken(RefreshToken newRefreshToken, User user)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = newRefreshToken.Expires,
            };

            Response.Cookies.Append("refreshToken", newRefreshToken.Token, cookieOptions);

            user.RefreshToken = newRefreshToken.Token;
            user.TokenCreated = newRefreshToken.Created;
            user.TokenExpires = newRefreshToken.Expires;
        }

        private string CreateToken(User user)
        {
            List<Claim> claims =
            [
                new Claim("Id", user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.TelephoneNumber!),
                new Claim(ClaimTypes.Role, user.Role.ToString()),
            ];

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(555),
                    signingCredentials: creds
                );
            try
            {

                var jwt = new JwtSecurityTokenHandler().WriteToken(token);
                return jwt;
            }
            catch(Exception e) {
                Console.WriteLine(e.ToString());
                return "";
            }
        }

        private bool ValidatePassword(string loginPassword, string userPassword)
        {
            return BCrypt.Net.BCrypt.Verify(loginPassword, userPassword);
        }
    }
}
