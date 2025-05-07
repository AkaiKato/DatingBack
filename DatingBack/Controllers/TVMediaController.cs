using Domain.DTO.Book;
using Domain.DTO.Tags;
using Domain.Interfaces.UoW;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingBack.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class TVMediaController(IUnitOfWork unitOfWork) : ControllerBase
    {
        /// <summary>
        /// Создать ТВМедиа
        /// </summary>
        /// <param name="createTVMediaDto"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpPost("/createTVMedia")]
        public async Task<IActionResult> CreateTVMedia([FromBody] CreateTagDto createTVMediaDto, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (createTVMediaDto == null || createTVMediaDto.Title == null)
            {
                return BadRequest("Requared Fields are nulls");
            }

            TVMedia tvMedia = new()
            {
                Id = Guid.NewGuid(),
                Title = createTVMediaDto.Title,
                Description = createTVMediaDto.Description ?? ""
            };

            unitOfWork.TVMediaRepository.Add(tvMedia);

            await unitOfWork.SaveAsync(ct);

            return Ok("ok");
        }

        /// <summary>
        /// Получить все ТВМедиа
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpGet("getAllTVMedias")]
        public async Task<IActionResult> GetAllTVMedias(CancellationToken ct)
        {
            var allTVMedias = await unitOfWork.TVMediaRepository.GetAllAsync(ct);

            List<ReturnTag> returnTags = [];
            foreach (var tVMedia in allTVMedias)
            {
                returnTags.Add(new ReturnTag()
                {
                    Id = tVMedia.Id,
                    Title = tVMedia.Title,
                    Description = tVMedia.Description,
                });
            }

            return Ok(returnTags);
        }

        /// <summary>
        /// Обновить ТВМедиа
        /// </summary>
        /// <param name="updateTVMediaDto"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpPut("updateTVMedia")]
        public async Task<IActionResult> UpdateTVMedia([FromBody] UpdateTagDto updateTVMediaDto, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (updateTVMediaDto == null || updateTVMediaDto.Title == null)
            {
                return BadRequest("Requared Fields are nulls");
            }

            var updatedTVMedia = await unitOfWork.TVMediaRepository.GetAsync(updateTVMediaDto.Id, ct);

            if (updatedTVMedia == null)
                return NotFound("no TVMedia with such id");

            updatedTVMedia.Title = updateTVMediaDto.Title;
            updatedTVMedia.Description = updateTVMediaDto.Description ?? "";

            unitOfWork.TVMediaRepository.Update(updatedTVMedia);

            await unitOfWork.SaveAsync(ct);

            return Ok("Suc Updated");
        }

        /// <summary>
        /// Удалить ТВМедиа
        /// </summary>
        /// <param name="tvMediaId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpDelete("deleteTVMedia")]
        public async Task<IActionResult> DeleteTVMedia([FromQuery] Guid tvMediaId, CancellationToken ct)
        {
            var deletedTVMedia = await unitOfWork.TVMediaRepository.GetAsync(tvMediaId, ct);

            if (deletedTVMedia == null)
                return NotFound("no interest with such id");

            var TVMediaProfiles = await unitOfWork.TVMediaProfileRepository.FindAsync(x => x.TVMediasId == deletedTVMedia.Id, ct);

            foreach (var profile in TVMediaProfiles)
            {
                unitOfWork.TVMediaProfileRepository.Remove(profile);
            }

            await unitOfWork.SaveAsync(ct);

            unitOfWork.TVMediaRepository.Remove(deletedTVMedia);
            await unitOfWork.SaveAsync(ct);

            return Ok("Suc deleted");
        }
    }
}
