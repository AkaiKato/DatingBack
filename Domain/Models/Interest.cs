namespace Domain.Models
{
    public class Interest
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = string.Empty;

        public List<InterestProfile>? Profile { get; set; }
    }
}
