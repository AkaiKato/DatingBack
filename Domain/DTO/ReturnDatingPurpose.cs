namespace Domain.DTO
{
    public class ReturnDatingPurpose
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
    }
}
