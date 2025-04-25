namespace Domain.Models
{
    public class DatingPurpose
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = string.Empty;
    }
}
