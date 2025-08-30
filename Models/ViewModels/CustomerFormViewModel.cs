namespace Vidly.Models.ViewModels
{
    public class CustomerFormViewModel
    {
        public Customer? Customer { get; set; }
        public IEnumerable<MembershipType>? MembershipTypes { get; set; }
    }
}
