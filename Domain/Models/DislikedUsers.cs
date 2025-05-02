using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class DislikedUsers
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Кого дизлайкнули
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Кто дизлайкнул
        /// </summary>
        public Guid UserDislikedId { get; set; }
    }
}
