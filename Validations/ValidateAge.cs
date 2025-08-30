using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Validations
{
    public class ValidateAge : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext context)
        {
            Customer customer = (Customer)context.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }


            if (customer.BirthDate == null)
            {
                return new ValidationResult("Birth date is required.");
            }

            var age = DateTime.Today.Year - customer.BirthDate.Year;

            return age >= 18 ? ValidationResult.Success : new ValidationResult("Customer should be at least 18 years old.");
        }
    }
}
