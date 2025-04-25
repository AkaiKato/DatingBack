using Domain.DTO.Book;
using Domain.Interfaces.UoW;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingBack.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class DatingPurposeController(IUnitOfWork unitOfWork) : ControllerBase
    {
        [HttpPost("/createDatingPurpose")]
        public async Task<IActionResult> CreateDatingPurpose([FromBody] CreateTagDto createDatingPurposeDto, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (createDatingPurposeDto == null || createDatingPurposeDto.Title == null)
            {
                return BadRequest("Requared Fields are nulls");
            }

            DatingPurpose datingPurpose = new()
            {
                Id = Guid.NewGuid(),
                Title = createDatingPurposeDto.Title,
                Description = createDatingPurposeDto.Description ?? ""
            };

            unitOfWork.DatingPurposeRepository.Add(datingPurpose);

            await unitOfWork.SaveAsync(ct);

            return Ok("ok");
        }

        [HttpGet("/getAllDatingPurposes")]
        public async Task<IActionResult> GetAllDatingPurposes(CancellationToken ct)
        {
            var allBooks = await unitOfWork.DatingPurposeRepository.GetAllAsync(ct);

            return Ok(allBooks);
        }

        [HttpPut("/updateDatingPurpose")]
        public async Task<IActionResult> UpdateDatingPurposes([FromBody] UpdateTagDto updateDatingPurposeDto, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (updateDatingPurposeDto == null || updateDatingPurposeDto.Title == null)
            {
                return BadRequest("Requared Fields are nulls");
            }

            var updatedDatingPurpose = await unitOfWork.DatingPurposeRepository.GetAsync(updateDatingPurposeDto.Id, ct);

            if (updatedDatingPurpose == null)
                return NotFound("no datingPurpose with such id");

            updatedDatingPurpose.Title = updateDatingPurposeDto.Title;
            updatedDatingPurpose.Description = updateDatingPurposeDto.Description ?? "";

            unitOfWork.DatingPurposeRepository.Update(updatedDatingPurpose);

            await unitOfWork.SaveAsync(ct);

            return Ok("Suc Updated");
        }

        [HttpDelete("/deleteDatingPurpose")]
        public async Task<IActionResult> DeleteDatingPurposes([FromQuery] Guid datingPurposeId, CancellationToken ct)
        {
            var deletedDatingPurpose = await unitOfWork.DatingPurposeRepository.GetAsync(datingPurposeId, ct);

            if (deletedDatingPurpose == null)
                return NotFound("no datingPurpose with such id");

            unitOfWork.DatingPurposeRepository.Remove(deletedDatingPurpose);
            await unitOfWork.SaveAsync(ct);

            return Ok("Suc deleted");
        }
    }
}
