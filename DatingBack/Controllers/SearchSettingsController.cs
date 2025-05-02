using Domain.DTO;
using Domain.Interfaces.UoW;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingBack.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class SearchSettingsController(IUnitOfWork unitOfWork) : ControllerBase
    {
        [HttpGet("getUserSearchSettings")]
        public async Task<IActionResult> GetUserSearchSettings(Guid userId, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await unitOfWork.UserRepository.GetAsync(userId, ct);

            if (user == null || user.SearchSettingId == null)
                return NotFound("No such user");

            var searchSetting = await unitOfWork.SearchSettingsRepository.GetAsync(user.SearchSettingId.Value, ct);

            return Ok(searchSetting);
        }

        [HttpPut("updateUserSearchSettings")]
        public async Task<IActionResult> UpdateUserSearchSettings([FromBody] SearchSetting searchSetting, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updSearchSetting = await unitOfWork.SearchSettingsRepository.GetAsync(searchSetting.Id, ct);

            if(updSearchSetting == null)
                return NotFound("No such SearchSettings");

            updSearchSetting.City = searchSetting.City;
            updSearchSetting.MinAge = searchSetting.MinAge;
            updSearchSetting.MaxAge = searchSetting.MaxAge;
            updSearchSetting.Radius = searchSetting.Radius;

            unitOfWork.SearchSettingsRepository.Update(updSearchSetting);
            await unitOfWork.SaveAsync(ct);
            return Ok("Ok");
        }
    }
}
