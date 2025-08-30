using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [StringLength(225)]
        [Display(Name = "Customer Name")]
        public string? Name { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime BirthDate { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        public MembershipType? MembershipType { get; set; }
    }
}
