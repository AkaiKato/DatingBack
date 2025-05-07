using DatingBack.gRPC.Client;
using Domain.DTO;
using Domain.Interfaces.UoW;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingBack.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class UserController(IUnitOfWork unitOfWork, IChatDataClient chatDataClient) : ControllerBase
    {
        [HttpGet("getAllUsers")]
        public async Task<IActionResult> GetAllUsers(CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var users = await unitOfWork.UserRepository.GetUsersWithProfileAndTags(ct);

            return Ok(users);
        }

        [HttpGet("getUser")]
        public async Task<IActionResult> GetUser(Guid userId, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await unitOfWork.UserRepository.GetUserWithProfileAndTags(userId, ct);

            if (user == null)
                return NotFound("No such user");

            return Ok(user);
        }

        [HttpPut("setComfirmed")]
        public async Task<IActionResult> SetComfirmed(Guid userId, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await unitOfWork.UserRepository.GetUserWithProfileAndTags(userId, ct);

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

            var user = await unitOfWork.UserRepository.GetUserWithProfileAndTags(userId, ct);

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

            var user = await unitOfWork.UserRepository.GetUserWithProfileAndTags(updateProfile.Id, ct);

            if (user == null)
                return NotFound("No such user");

            var profile = user.Profile;

            if (profile == null)
                return Ok("Ok");

            profile.AboutMe = updateProfile.AboutMe;
            profile.Education = updateProfile.Education;
            profile.Work = updateProfile.Work;

            if (!await unitOfWork.DatingPurposeRepository.AnyAsync(x => x.Id == updateProfile.DatingPurposeId, ct))
                return NotFound("No such dating Purpose");

            profile.DatingPurposeId = updateProfile.DatingPurposeId;

            var oldPersonalTags = profile.PersonalTags;
            List<PersonalTagProfile> personalTag = [];
            foreach (var item in updateProfile.PersonalTags)
            {
                personalTag.Add(new PersonalTagProfile
                {
                    Id = Guid.NewGuid(),
                    ProfileId = profile.Id,
                    PersonalTagId = item.TagId,
                    Order = item.Order,
                });
            }

            var oldInterestTags = profile.Interests;
            List<InterestProfile> interestTag = [];
            foreach (var item in updateProfile.Interests)
            {
                interestTag.Add(new InterestProfile
                {
                    Id = Guid.NewGuid(),
                    ProfileId = profile.Id,
                    InterestId = item.TagId,
                    Order = item.Order,
                });
            }

            var oldMusicanTags = profile.Musicans;
            List<MusicanProfile> musicanTag = [];
            foreach (var item in updateProfile.Musicans)
            {
                musicanTag.Add(new MusicanProfile
                {
                    Id = Guid.NewGuid(),
                    ProfileId = profile.Id,
                    MusicanId = item.TagId,
                    Order = item.Order,
                });
            }

            var oldTvMediasTags = profile.TVMedias;
            List<TVMediaProfile> tvmediaTag = [];
            foreach (var item in updateProfile.TVMedias)
            {
                tvmediaTag.Add(new TVMediaProfile
                {
                    Id = Guid.NewGuid(),
                    ProfileId = profile.Id,
                    TVMediasId = item.TagId,
                    Order = item.Order,
                });
            }

            var oldBookTags = profile.Books;
            List<BookProfile> bookTag = [];
            foreach (var item in updateProfile.Books)
            {
                bookTag.Add(new BookProfile
                {
                    Id = Guid.NewGuid(),
                    ProfileId = profile.Id,
                    BookId = item.TagId,
                    Order = item.Order,
                });
            }

            foreach (var item in oldPersonalTags)
            {
                unitOfWork.PersonalTagProfileRepository.Remove(item);
            }

            foreach (var item in oldInterestTags)
            {
                unitOfWork.InterestProfileRepository.Remove(item);
            }

            foreach (var item in oldMusicanTags)
            {
                unitOfWork.MusicanProfileRepository.Remove(item);
            }

            foreach (var item in oldTvMediasTags)
            {
                unitOfWork.TVMediaProfileRepository.Remove(item);
            }

            foreach (var item in oldBookTags)
            {
                unitOfWork.BookProfileRepository.Remove(item);
            }
            await unitOfWork.SaveAsync(ct);


            unitOfWork.PersonalTagProfileRepository.AddRange(personalTag);
            unitOfWork.InterestProfileRepository.AddRange(interestTag);
            unitOfWork.MusicanProfileRepository.AddRange(musicanTag);
            unitOfWork.TVMediaProfileRepository.AddRange(tvmediaTag);
            unitOfWork.BookProfileRepository.AddRange(bookTag);

            unitOfWork.ProfileRepository.Update(profile);

            await unitOfWork.SaveAsync(ct);

            return Ok("Ok");
        }

        [HttpPost("updateUserBaseInfo")]
        public async Task<IActionResult> UpdateUserBaseInfo([FromBody] UpdateUserBaseInfo updateUserBaseInfo, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await unitOfWork.UserRepository.GetUserWithProfileAndTags(updateUserBaseInfo.Id, ct);

            if (user == null)
                return NotFound("No such user");

            user.Name = updateUserBaseInfo.Name;
            user.Surname = updateUserBaseInfo.Surname;
            user.Sex = updateUserBaseInfo.Sex;
            user.BirthDate = updateUserBaseInfo.BirthDay;
            user.Email = updateUserBaseInfo.Email;

            unitOfWork.UserRepository.Update(user);
            await unitOfWork.SaveAsync(ct);

            return Ok("Ok");
        }

        [HttpPost("changePass")]
        public async Task<IActionResult> ChangePass([FromBody] UserChangePassModel changePass, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await unitOfWork.UserRepository.GetUserWithProfileAndTags(changePass.UserId, ct);

            if (user == null)
                return NotFound("No such user");

            if (!BCrypt.Net.BCrypt.Verify(changePass.oldPass, user.Password))
                return BadRequest("Wrong password");

            user.Password = BCrypt.Net.BCrypt.HashPassword(changePass.newPass);
            unitOfWork.UserRepository.Update(user);
            await unitOfWork.SaveAsync(ct);
            return Ok("Ok");
        }

        [HttpGet("getUsersWhoLikedUser")]
        public async Task<IActionResult> GetUsersWhoLikedUser(Guid UserId, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var whoLikedUser = await unitOfWork.LikedByRepository.FindAsync(x => x.UserId == UserId, ct);

            return Ok(whoLikedUser);
        }

        [HttpPost("likeUser")]
        public async Task<IActionResult> LikeUser([FromBody] LikeUser likeUser, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await unitOfWork.UserRepository.GetAsync(likeUser.UserId, ct);

            if (user == null)
                return NotFound("No such user");

            var whoWasLiked = await unitOfWork.UserRepository.GetAsync(likeUser.WhoWasLiked, ct);

            if (whoWasLiked == null)
                return NotFound("No such user");

            if (await unitOfWork.DislikedUsersRepository.IsLikedPersonIsDislikeUser(likeUser.UserId, likeUser.WhoWasLiked))
            {
                return Ok("Ok");
            }

            if (await unitOfWork.LikedByRepository.IsItMathc(likeUser.UserId, likeUser.WhoWasLiked))
            {
                //Send request to create chat

                var like = await unitOfWork.LikedByRepository.GetLike(likeUser.UserId, likeUser.WhoWasLiked);
                if (like == null)
                    return Ok("Ok");

                var value = await chatDataClient.CreateChat(likeUser.UserId, likeUser.WhoWasLiked);

                if(!value)
                    return BadRequest("Error when creating chat");

                unitOfWork.LikedByRepository.Remove(like);
                await unitOfWork.SaveAsync(ct);
                return Ok("Это Мэтч!");
            }
            else
            {
                var newLike = new LikedBy
                {
                    Id = Guid.NewGuid(),
                    UserId = likeUser.WhoWasLiked,
                    LikedByUserId = likeUser.UserId
                };

                unitOfWork.LikedByRepository.Add(newLike);
                await unitOfWork.SaveAsync(ct);
            }
            return Ok("Ok");
        }

        [HttpPost("dislikeUser")]
        public async Task<IActionResult> DislikeUser([FromBody] DislikeUser dislikeUser, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await unitOfWork.UserRepository.GetAsync(dislikeUser.UserId, ct);

            if (user == null)
                return NotFound("No such user");

            var whoWasDisliked = await unitOfWork.UserRepository.GetAsync(dislikeUser.WhoWasDisliked, ct);

            if (whoWasDisliked == null)
                return NotFound("No such user");
            
            var newDislike = new DislikedUsers
            {
                Id = Guid.NewGuid(),
                UserId = dislikeUser.WhoWasDisliked,
                UserDislikedId = dislikeUser.UserId
            };

            unitOfWork.DislikedUsersRepository.Add(newDislike);
            await unitOfWork.SaveAsync(ct);

            if (await unitOfWork.LikedByRepository.IsItMathc(dislikeUser.UserId, dislikeUser.WhoWasDisliked))
            {
                var like = await unitOfWork.LikedByRepository.GetLike(dislikeUser.UserId, dislikeUser.WhoWasDisliked);
                if (like == null)
                    return Ok("Ok");

                unitOfWork.LikedByRepository.Remove(like);
                await unitOfWork.SaveAsync(ct);
                return Ok("Упс! Вы упустили мэтч!");
            }

            return Ok("Ok");
        }

        [HttpGet("getUsersWithUserSearchFilters")]
        public async Task<IActionResult> GetUsersWithUserSearchFilters(Guid userId, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await unitOfWork.UserRepository.GetAsync(userId, ct);

            if (user == null || user.SearchSettingId == null)
                return NotFound("No such user");

            var searchSettings = await unitOfWork.SearchSettingsRepository.GetAsync(user.SearchSettingId.Value, ct);

            if (searchSettings == null) 
                return BadRequest("Doesn't have search settings");

            var users = await unitOfWork.UserRepository.GetUserBySearchSettings(userId, searchSettings, ct);

            return Ok(users);
        }
    }
}
