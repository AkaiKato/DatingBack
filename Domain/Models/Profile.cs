namespace Domain.Models
{
    public class Profile
    {
        public Guid Id { get; set; }

        public bool IsConfirmed { get; set; } = false;

        public bool IsDisabled { get; set; } = false;

        public List<ProfileMedia> ProfileMedias { get; set; } = [];

        public string? AboutMe { get; set; }

        public string? Education {  get; set; }

        public string? Work { get; set; }

        public string? DatingPurpose { get; set; }

        public List<PersonalTag> PersonalTags { get; set; } = [];

        public List<Interest> Interests { get; set; } = [];

        public List<Musican> Musicans { get; set; } = [];

        public List<TVMedia> TVMedias { get; set; } = [];

        public List<Book> Books { get; set; } = [];
    }
}
