using static Domain.Enums.DomainEnums;

namespace Domain.DTO
{
    public class UpdateUserBaseInfo
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Surname { get; set; } = null!;

        public Sex Sex { get; set; }

        public string? Email { get; set; }

        public DateOnly BirthDay { get; set; }
    }
}
