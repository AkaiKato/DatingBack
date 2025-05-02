namespace Domain.DTO
{
    public class UpdateProfile
    {
        public Guid Id { get; set; }

        public string? AboutMe { get; set; }

        public string? Education { get; set; }

        public string? Work { get; set; }

        public Guid? DatingPurposeId { get; set; }

        public List<UpdateTag> PersonalTags { get; set; } = [];

        public List<UpdateTag> Interests { get; set; } = [];

        public List<UpdateTag> Musicans { get; set; } = [];

        public List<UpdateTag> TVMedias { get; set; } = [];

        public List<UpdateTag> Books { get; set; } = [];
    }
}
