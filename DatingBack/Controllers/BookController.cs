using Domain.DTO.Book;
using Domain.Interfaces.UoW;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingBack.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class BookController(IUnitOfWork unitOfWork) : ControllerBase
    {
        [HttpPost("/createBook")]
        public async Task<IActionResult> CreateBook([FromBody] CreateBookDto createBookDto, CancellationToken ct)
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

        [HttpGet("/getAllBooks")]
        public async Task<IActionResult> GetAllBooks(CancellationToken ct)
        {
            var allBooks = await unitOfWork.BookRepository.GetAllAsync(ct);

            return Ok(allBooks);
        }

        [HttpPut("/updateBook")]
        public async Task<IActionResult> UpdateBook([FromBody] UpdateBookDto updateBookDto, CancellationToken ct)
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

        [HttpDelete("/deleteBook")]
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
