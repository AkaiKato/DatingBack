using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class PersonalTagProfile
    {
        public Guid Id { get; set; }

        public Guid PersonalTagId { get; set; }

        public Guid ProfileId { get; set; }

        public int Order { get; set; }

        [ForeignKey(nameof(PersonalTagId))]
        public PersonalTag? PersonalTag { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public Profile? Profile { get; set; }
    }
}
