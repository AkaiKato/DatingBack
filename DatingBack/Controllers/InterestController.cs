using Domain.DTO.Book;
using Domain.DTO.Tags;
using Domain.Interfaces.UoW;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingBack.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class InterestController(IUnitOfWork unitOfWork) : ControllerBase
    {
        /// <summary>
        /// Создать интерес
        /// </summary>
        /// <param name="createInterestDto"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpPost("createInterest")]
        public async Task<IActionResult> CreateInterest([FromBody] CreateTagDto createInterestDto, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (createInterestDto == null || createInterestDto.Title == null)
            {
                return BadRequest("Requared Fields are nulls");
            }

            Interest interest = new()
            {
                Id = Guid.NewGuid(),
                Title = createInterestDto.Title,
                Description = createInterestDto.Description ?? ""
            };

            unitOfWork.InterestRepository.Add(interest);

            await unitOfWork.SaveAsync(ct);

            return Ok("ok");
        }

        /// <summary>
        /// Получить все интересы
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpGet("getAllInterests")]
        public async Task<IActionResult> GetAllInterest(CancellationToken ct)
        {
            var allInterest = await unitOfWork.InterestRepository.GetAllAsync(ct);

            List<ReturnTag> returnTags = [];
            foreach (var interest in allInterest)
            {
                returnTags.Add(new ReturnTag()
                {
                    Id = interest.Id,
                    Title = interest.Title,
                    Description = interest.Description,
                });
            }

            return Ok(returnTags);
        }

        /// <summary>
        /// Обновить интерес
        /// </summary>
        /// <param name="updateInterestDto"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpPut("updateInterest")]
        public async Task<IActionResult> UpdateInterest([FromBody] UpdateTagDto updateInterestDto, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (updateInterestDto == null || updateInterestDto.Title == null)
            {
                return BadRequest("Requared Fields are nulls");
            }

            var updatedInterest = await unitOfWork.InterestRepository.GetAsync(updateInterestDto.Id, ct);

            if (updatedInterest == null)
                return NotFound("no interest with such id");

            updatedInterest.Title = updateInterestDto.Title;
            updatedInterest.Description = updateInterestDto.Description ?? "";

            unitOfWork.InterestRepository.Update(updatedInterest);

            await unitOfWork.SaveAsync(ct);

            return Ok("Suc Updated");
        }

        /// <summary>
        /// Удалить интерес
        /// </summary>
        /// <param name="interestId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpDelete("deleteInterest")]
        public async Task<IActionResult> DeleteInterest([FromQuery] Guid interestId, CancellationToken ct)
        {
            var deletedInterest = await unitOfWork.InterestRepository.GetAsync(interestId, ct);

            if (deletedInterest == null)
                return NotFound("no interest with such id");

            var interestProfiles = await unitOfWork.InterestProfileRepository.FindAsync(x => x.InterestId == deletedInterest.Id, ct);

            foreach (var profile in interestProfiles)
            {
                unitOfWork.InterestProfileRepository.Remove(profile);
            }

            await unitOfWork.SaveAsync(ct);

            unitOfWork.InterestRepository.Remove(deletedInterest);
            await unitOfWork.SaveAsync(ct);

            return Ok("Suc deleted");
        }
    }
}
