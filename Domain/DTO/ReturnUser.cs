namespace Domain.DTO
{
    public class ReturnUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public Guid? ProfileId { get; set; }
        public bool IsConfirmed { get; set; }
        public string? AboutMe { get; set; }
        public string? Education { get; set; }
        public string? Work { get; set; }
        public List<ReturnProfilePictures>? ReturnProfilePictures { get; set; }
        public ReturnDatingPurpose? ReturnDatingPurpose { get; set; }
        public List<ReturnTagWithOrder>? PersonalTag { get; set; }
        public List<ReturnTagWithOrder>? InterestTag { get; set; }
        public List<ReturnTagWithOrder>? MusicanTag { get; set; }
        public List<ReturnTagWithOrder>? TVMediaTag { get; set; }
        public List<ReturnTagWithOrder>? BookTag { get; set; }
    }
}
