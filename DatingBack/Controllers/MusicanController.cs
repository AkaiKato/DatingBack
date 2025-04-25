using Domain.DTO.Book;
using Domain.Interfaces.UoW;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingBack.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class MusicanController(IUnitOfWork unitOfWork) : ControllerBase
    {
        [HttpPost("/createMusican")]
        public async Task<IActionResult> CreateMusican([FromBody] CreateTagDto createMusicanDto, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (createMusicanDto == null || createMusicanDto.Title == null)
            {
                return BadRequest("Requared Fields are nulls");
            }

            Musican musican = new()
            {
                Id = Guid.NewGuid(),
                Title = createMusicanDto.Title,
                Description = createMusicanDto.Description ?? ""
            };

            unitOfWork.MusicanRepository.Add(musican);

            await unitOfWork.SaveAsync(ct);

            return Ok("ok");
        }

        [HttpGet("/getAllMusicans")]
        public async Task<IActionResult> GetAllMusican(CancellationToken ct)
        {
            var allMusicans = await unitOfWork.MusicanRepository.GetAllAsync(ct);

            return Ok(allMusicans);
        }

        [HttpPut("/updateInterest")]
        public async Task<IActionResult> UpdateMusican([FromBody] UpdateTagDto updateMusicanDto, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (updateMusicanDto == null || updateMusicanDto.Title == null)
            {
                return BadRequest("Requared Fields are nulls");
            }

            var updatedMusican = await unitOfWork.MusicanRepository.GetAsync(updateMusicanDto.Id, ct);

            if (updatedMusican == null)
                return NotFound("no musican with such id");

            updatedMusican.Title = updateMusicanDto.Title;
            updatedMusican.Description = updateMusicanDto.Description ?? "";

            unitOfWork.MusicanRepository.Update(updatedMusican);

            await unitOfWork.SaveAsync(ct);

            return Ok("Suc Updated");
        }

        [HttpDelete("/deleteMusican")]
        public async Task<IActionResult> DeleteMusican([FromQuery] Guid musicanId, CancellationToken ct)
        {
            var deletedMusican = await unitOfWork.MusicanRepository.GetAsync(musicanId, ct);

            if (deletedMusican == null)
                return NotFound("no interest with such id");

            var musicanProfiles = await unitOfWork.MusicanProfileRepository.FindAsync(x => x.MusicanId == deletedMusican.Id, ct);

            foreach (var profile in musicanProfiles)
            {
                unitOfWork.MusicanProfileRepository.Remove(profile);
            }

            await unitOfWork.SaveAsync(ct);

            unitOfWork.MusicanRepository.Remove(deletedMusican);
            await unitOfWork.SaveAsync(ct);

            return Ok("Suc deleted");
        }
    }
}
