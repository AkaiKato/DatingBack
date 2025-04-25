using System.ComponentModel.DataAnnotations.Schema;

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

        public Guid? DatingPurposeId { get; set; }

        [ForeignKey(nameof(DatingPurposeId))]
        public DatingPurpose? DatingPurpose { get; set; }

        public List<PersonalTagProfile> PersonalTags { get; set; } = [];

        public List<InterestProfile> Interests { get; set; } = [];

        public List<MusicanProfile> Musicans { get; set; } = [];

        public List<TVMediaProfile> TVMedias { get; set; } = [];

        public List<BookProfile> Books { get; set; } = [];
    }
}
