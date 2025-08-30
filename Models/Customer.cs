using System.ComponentModel.DataAnnotations;
using Vidly.Validations;

namespace Vidly.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Customer name is required.")]
        [StringLength(225)]
        [Display(Name = "Customer Name")]
        public string? Name { get; set; }

        [Display(Name = "Date of Birth")]
        [ValidateAge]
        public DateTime BirthDate { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Required(ErrorMessage = "The membership type is required.")]
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        public MembershipType? MembershipType { get; set; }
    }
}
