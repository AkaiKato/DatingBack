using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class InterestProfile
    {
        public Guid Id { get; set; }

        public Guid InterestId { get; set; }

        public Guid ProfileId { get; set; }

        public int Order { get; set; }

        [ForeignKey(nameof(InterestId))]
        public Interest? Interest { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public Profile? Profile { get; set; }
    }
}
