using Domain.DTO;
using Domain.Interfaces.UoW;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingBack.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class UserController(IUnitOfWork unitOfWork) : ControllerBase
    {
        [HttpGet("getAllUsers")]
        public async Task<IActionResult> GetAllUsers(CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var users = await unitOfWork.UserRepository.GetUsersWithProfile(ct);

            return Ok(users);
        }

        [HttpGet("getUser")]
        public async Task<IActionResult> GetUser(Guid userId, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await unitOfWork.UserRepository.GetUserWithProfile(userId, ct);

            if(user == null)
                return NotFound("No such user");

            return Ok(user);
        }

        [HttpPut("setComfirmed")]
        public async Task<IActionResult> SetComfirmed(Guid userId, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await unitOfWork.UserRepository.GetUserWithProfile(userId, ct);

            if (user == null)
                return NotFound("No such user");

            var profile = user.Profile;

            if (profile == null)
                return Ok("Ok");

            profile.IsConfirmed = true;

            unitOfWork.ProfileRepository.Update(profile);

            await unitOfWork.SaveAsync(ct);

            return Ok("Ok");
        }

        [HttpPut("setDisable")]
        public async Task<IActionResult> SetDisabled(Guid userId, bool disabled, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await unitOfWork.UserRepository.GetUserWithProfile(userId, ct);

            if (user == null)
                return NotFound("No such user");

            var profile = user.Profile;

            if (profile == null)
                return Ok("Ok");

            profile.IsDisabled = disabled;

            unitOfWork.ProfileRepository.Update(profile);

            await unitOfWork.SaveAsync(ct);

            return Ok("Ok");
        }

        [HttpPost("updateProfile")]
        public async Task<IActionResult> UpdateProfile([FromBody] UpdateProfile updateProfile, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await unitOfWork.UserRepository.GetUserWithProfile(updateProfile.Id, ct);

            return Ok("Ok");
        }
    }
}
