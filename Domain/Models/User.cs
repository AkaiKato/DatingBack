using System.ComponentModel.DataAnnotations.Schema;
using static Domain.Enums.DomainEnums;

namespace Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public Roles Role {  get; set; }

        public string Name { get; set; } = null!;

        public string Surname { get; set; } = null!;

        public DateOnly BirthDate { get; set; }

        public Sex Sex { get; set; }

        public string? Email { get; set; }

        public string? TelephoneNumber { get; set; }

        public string Password { get; set; } = null!;

        public Guid? SearchSettingId {  get; set; } 

        public Guid? ProfileId { get; set; }

        public List<LikedBy> LikedUsers { get; set; } = [];

        public List<DislikedUsers> DislikedUsers { get; set; } = [];

        //public List<Chat> Chats { get; set; }

        public string RefreshToken { get; set; } = string.Empty;

        public DateTime TokenCreated { get; set; }

        public DateTime TokenExpires { get; set; }

        [ForeignKey(nameof(SearchSettingId))]
        public SearchSetting? SearchSetting { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public Profile? Profile { get; set; }
    }
}
