using System.ComponentModel.DataAnnotations;

namespace Domain.DTO
{
    public class UserLogin
    {
        [StringLength(12, MinimumLength = 11)]
        [RegularExpression("^((8|\\+7)[\\- ]?)?(\\(?\\d{3}\\)?[\\- ]?)?[\\d\\- ]{7,10}$")]
        public string TelephoneNumber { get; set; } = null!;
        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; } = null!;
    }
}
