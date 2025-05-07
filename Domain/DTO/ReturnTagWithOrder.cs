namespace Domain.DTO
{
    public class ReturnTagWithOrder
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = null!;

        public int Order { get; set; }
    }
}
