using System.ComponentModel.DataAnnotations.Schema;
using static Domain.Enums.DomainEnums;

namespace Domain.Models
{
    public class ProfileMedia
    {
        public Guid Id { get; set; }

        public Guid ProfileId { get; set; }

        public string StrorageUrl { get; set; } = null!;

        public MediaTypes MediaType { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public Profile Profile { get; set; } = null!;
    }
}
