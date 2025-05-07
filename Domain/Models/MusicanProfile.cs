using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class MusicanProfile
    {
        public Guid Id { get; set; }

        public Guid MusicanId { get; set; }

        public Guid ProfileId { get; set; }

        public int Order { get; set; }

        [ForeignKey(nameof(MusicanId))]
        public Musican? Musican { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public Profile? Profile { get; set; }
    }
}
