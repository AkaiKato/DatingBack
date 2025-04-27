using Domain.DTO.Book;
using Domain.Interfaces.UoW;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingBack.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class InterestController(IUnitOfWork unitOfWork) : ControllerBase
    {
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

        [HttpGet("getAllInterests")]
        public async Task<IActionResult> GetAllInterest(CancellationToken ct)
        {
            var allInterest = await unitOfWork.InterestRepository.GetAllAsync(ct);

            return Ok(allInterest);
        }

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
