namespace Domain.DTO
{
    public class LikeUser
    {
        public Guid UserId { get; set; }

        public Guid WhoWasLiked { get; set; }
    }
}
