namespace Vidly.Models
{
    public class MembershipType
    {
        public byte MembershipTypeId { get; set; }
        public short SignupFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}
