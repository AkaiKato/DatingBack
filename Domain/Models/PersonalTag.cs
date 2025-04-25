namespace Domain.Models
{
    public class PersonalTag
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = string.Empty;

        public List<PersonalTagProfile>? Profile { get; set; }
    }
}
