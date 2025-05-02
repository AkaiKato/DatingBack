using System.ComponentModel.DataAnnotations;

namespace Domain.DTO
{
    public class UserChangePassModel
    {
        public Guid UserId { get; set; }
        public string oldPass { get; set; } = null!;
        [StringLength(50, MinimumLength = 6)]
        public string newPass { get; set; } = null!;
    }
}
