namespace Domain.Models
{
    public class Musican
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = string.Empty;

        public List<MusicanProfile>? Profile { get; set; }
    }
}
