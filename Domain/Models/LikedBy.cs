using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class LikedBy
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid LikedByUserId { get; set; }
    }
}
