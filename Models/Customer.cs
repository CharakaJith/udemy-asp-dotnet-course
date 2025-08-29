using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [StringLength(225)]
        public string? Name { get; set; }

        public DateTime BirthDate { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public byte MembershipTypeId { get; set; }
        public MembershipType? MembershipType { get; set; }
    }
}
