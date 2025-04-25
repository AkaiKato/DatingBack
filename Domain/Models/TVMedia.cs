namespace Domain.Models
{
    public class TVMedia
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = string.Empty;

        public List<TVMediaProfile>? Profile { get; set; }   
    }
}
