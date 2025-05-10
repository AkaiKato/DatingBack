using Domain.DTO.Book;
using Domain.DTO.Tags;
using Domain.Interfaces.UoW;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingBack.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class DatingPurposeController(IUnitOfWork unitOfWork) : ControllerBase
    {
        /// <summary>
        /// Создать причину для знакомства
        /// </summary>
        /// <param name="createDatingPurposeDto"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpPost("Admin/createDatingPurpose")]
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

        /// <summary>
        /// Получить все причины для знакомства
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpGet("getAllDatingPurposes")]
        public async Task<IActionResult> GetAllDatingPurposes(CancellationToken ct)
        {
            var allDatingPurposes = await unitOfWork.DatingPurposeRepository.GetAllAsync(ct);

            List<ReturnTag> returnTags = [];
            foreach (var datingPurpose in allDatingPurposes)
            {
                returnTags.Add(new ReturnTag()
                {
                    Id = datingPurpose.Id,
                    Title = datingPurpose.Title,
                    Description = datingPurpose.Description,
                });
            }

            return Ok(returnTags);
        }

        /// <summary>
        /// Обновить причину для знакомства
        /// </summary>
        /// <param name="updateDatingPurposeDto"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpPut("Admin/updateDatingPurpose")]
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

        /// <summary>
        /// Удалить причину для знакомства
        /// </summary>
        /// <param name="datingPurposeId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpDelete("Admin/deleteDatingPurpose")]
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
