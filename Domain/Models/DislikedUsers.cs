using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class DislikedUsers
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid UserDislikedId { get; set; }
    }
}
