namespace Domain.DTO
{
    public class ReturnProfilePictures
    {
        public Guid Id { get; set; }
        public string Url { get; set; } = null!;
        public int Order {  get; set; }
    }
}
