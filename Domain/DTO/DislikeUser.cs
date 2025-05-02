namespace Domain.DTO
{
    public class DislikeUser
    {
        public Guid UserId { get; set; }

        public Guid WhoWasDisliked { get; set; }
    }
}
