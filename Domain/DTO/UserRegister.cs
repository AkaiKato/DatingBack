using System.ComponentModel.DataAnnotations;
using static Domain.Enums.DomainEnums;

namespace Domain.DTO
{
    public class UserRegister
    {
        [StringLength(100,ErrorMessage = "Something Wrong with length of Name", MinimumLength = 2)]
        public string Name { get; set; } = null!;
        [StringLength(100, ErrorMessage = "Something Wrong with length of Surname", MinimumLength = 2)]
        public string Surname { get; set; } = null!;
        [StringLength(12, MinimumLength = 11)]
        [RegularExpression("^((8|\\+7)[\\- ]?)?(\\(?\\d{3}\\)?[\\- ]?)?[\\d\\- ]{7,10}$")]
        public string TelephoneNumber { get; set; } = null!;
        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; } = null!;

        public Sex Sex { get; set; }

    }
}
