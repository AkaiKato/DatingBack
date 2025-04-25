namespace Domain.DTO.Book
{
    public class UpdateTagDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; } 
    }
}
