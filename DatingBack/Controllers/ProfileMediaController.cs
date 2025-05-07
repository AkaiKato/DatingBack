using Domain.Interfaces.UoW;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingBack.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ProfileMediaController(IUnitOfWork unitOfWork, Microsoft.AspNetCore.Hosting.IWebHostEnvironment env) : ControllerBase
    {
        private readonly string[] permittedExtensions = { ".jpg", ".jpeg", ".png", ".webp" };

        /// <summary>
        /// Добавить фото профиля
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="pic"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpPut("addProfileMedia")]
        public async Task<IActionResult> AddProfileMedia([FromQuery] Guid profileId, IFormFile pic, CancellationToken ct)
        {
            if (pic == null)
                return BadRequest(ModelState);

            var ext = Path.GetExtension(pic.FileName).ToLowerInvariant();
            if (string.IsNullOrEmpty(ext) || !permittedExtensions.Contains(ext))
                return BadRequest("Unsupported extension");

            var profile = await unitOfWork.ProfileRepository.GetProfileWithProfileMediasAsync(profileId, ct);

            if (profile is null)
                return NotFound($"No such user");

            if (profile.ProfileMedias.Count >= 6)
                return BadRequest("More Than Six Medias");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var profileMedias = profile.ProfileMedias;
            var unique = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            var rootFolder = env.WebRootPath;
            var todayFolder = $"/uploads/{DateTime.Now.ToShortDateString()}";
            var folderPath = rootFolder + todayFolder;
            var uniqueName = $"/{unique}{ext}";
            var newfilePath = folderPath + uniqueName;

            if(!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            var getLastOrder = profileMedias.OrderByDescending(x => x.Order).FirstOrDefault()?.Order;

            if (getLastOrder == null)
                getLastOrder = 0;
            else
                getLastOrder++;

            var t = AppContext.BaseDirectory;
            var tt = Directory.GetParent(t);
            var ttt = Directory.GetParent(tt!.FullName);

            using (FileStream fileStream = System.IO.File.Create(newfilePath))
                pic.CopyTo(fileStream);

            ProfileMedia profileMedia = new()
            {
                Id = Guid.NewGuid(),
                MediaType = Domain.Enums.DomainEnums.MediaTypes.Photo,
                Order = getLastOrder.Value,
                ProfileId = profileId,
                StrorageUrl = todayFolder + uniqueName,
            };

            unitOfWork.ProfileMediaRepository.Add(profileMedia);
            await unitOfWork.SaveAsync(ct);

            return Ok("Suc add");
        }

        /// <summary>
        /// Удалить фото
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="mediaId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpPut("deleteProfileMedia")]
        public async Task<IActionResult> DeleteProfileMedia([FromQuery] Guid profileId, [FromQuery] Guid mediaId, CancellationToken ct)
        {
            var profile = await unitOfWork.ProfileRepository.GetProfileWithProfileMediasAsync(profileId, ct);

            if (profile is null)
                return NotFound($"No such user");

            if (profile.ProfileMedias.Count == 0)
                return BadRequest("Nothing to update");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var profileMedias = profile.ProfileMedias;
            var profileMedia = profileMedias.FirstOrDefault(x => x.Id == mediaId);
            if (profileMedia is null)
                return NotFound("No such media");

            var oldPath = profileMedia.StrorageUrl;

            FileInfo f = new(oldPath);
            f.Delete();            

            var order = profileMedia.Order;
            foreach (var item in profileMedias)
            {
                if (order < item.Order)
                {
                    item.Order--;
                    unitOfWork.ProfileMediaRepository.Update(item);
                }
            }

            unitOfWork.ProfileMediaRepository.Remove(profileMedia);
            await unitOfWork.SaveAsync(ct);

            return Ok("Suc deleted");
        }
    }
}
