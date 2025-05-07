using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class TVMediaProfile
    {
        public Guid Id { get; set; }

        public Guid TVMediasId { get; set; }

        public Guid ProfileId { get; set; }

        public int Order { get; set; }

        [ForeignKey(nameof(TVMediasId))]
        public TVMedia? TVMedia { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public Profile? Profile { get; set; }
    }
}
