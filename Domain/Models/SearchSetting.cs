namespace Domain.Models
{
    public class SearchSetting
    {
        public Guid Id { get; set; }

        public string? City { get; set; }

        public int MinAge { get; set; } = 18;

        public int MaxAge { get; set; } = 130;

        public int Radius { get; set; }
    }
}
