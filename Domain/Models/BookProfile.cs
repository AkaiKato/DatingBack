using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class BookProfile
    {
        public Guid Id { get; set; }

        public Guid BookId { get; set; }

        public Guid ProfileId { get; set; }

        public int Order { get; set; }

        [ForeignKey(nameof(BookId))]
        public Book? Book { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public Profile? Profile { get; set; }
    }
}
