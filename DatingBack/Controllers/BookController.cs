using Domain.DTO.Book;
using Domain.DTO.Tags;
using Domain.Interfaces.UoW;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingBack.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class BookController(IUnitOfWork unitOfWork) : ControllerBase
    {
        /// <summary>
        /// Создать книгу
        /// </summary>
        /// <param name="createBookDto"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpPost("createBook")]
        public async Task<IActionResult> CreateBook([FromBody] CreateTagDto createBookDto, CancellationToken ct)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            if(createBookDto == null || createBookDto.Title == null)
            {
                return BadRequest("Requared Fields are nulls");
            }

            Book book = new()
            {
                Id = Guid.NewGuid(),
                Title = createBookDto.Title,
                Description = createBookDto.Description ?? ""
            };

            unitOfWork.BookRepository.Add(book);

            await unitOfWork.SaveAsync(ct);

            return Ok("ok");
        }

        /// <summary>
        /// Получить все книги
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpGet("getAllBooks")]
        public async Task<IActionResult> GetAllBooks(CancellationToken ct)
        {
            var allBooks = await unitOfWork.BookRepository.GetAllAsync(ct);

            List<ReturnTag> returnTags = [];
            foreach (var book in allBooks)
            {
                returnTags.Add(new ReturnTag()
                {
                    Id = book.Id,
                    Title = book.Title,
                    Description = book.Description,
                });
            }

            return Ok(returnTags);
        }

        /// <summary>
        /// Обновить книгу
        /// </summary>
        /// <param name="updateBookDto"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpPut("updateBook")]
        public async Task<IActionResult> UpdateBook([FromBody] UpdateTagDto updateBookDto, CancellationToken ct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if(updateBookDto == null || updateBookDto.Title == null)
            {
                return BadRequest("Requared Fields are nulls");
            }

            var updatedBook = await unitOfWork.BookRepository.GetAsync(updateBookDto.Id, ct);

            if (updatedBook == null)
                return NotFound("no book with such id");

            updatedBook.Title = updateBookDto.Title;
            updatedBook.Description = updateBookDto.Description ?? "";

            unitOfWork.BookRepository.Update(updatedBook);

            await unitOfWork.SaveAsync(ct);

            return Ok("Suc Updated");
        }

        /// <summary>
        /// Удалить книгу
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpDelete("deleteBook")]
        public async Task<IActionResult> DeleteBook([FromQuery] Guid bookId, CancellationToken ct)
        {
            var deletedBook = await unitOfWork.BookRepository.GetAsync(bookId, ct);

            if (deletedBook == null)
                return NotFound("no book with such id");

            var bookProfiles = await unitOfWork.BookProfileRepository.FindAsync(x => x.BookId == deletedBook.Id, ct);

            foreach (var profile in bookProfiles)
            {
                unitOfWork.BookProfileRepository.Remove(profile);
            }

            await unitOfWork.SaveAsync(ct);

            unitOfWork.BookRepository.Remove(deletedBook);
            await unitOfWork.SaveAsync(ct);

            return Ok("Suc deleted");
        }
    }
}
