using System.ComponentModel.DataAnnotations;

namespace Vidly.Validations
{
    public class ValidateStocks : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Number of stocks is required.");
            }

            int numInStock;
            if (!int.TryParse(value.ToString(), out numInStock))
            {
                return new ValidationResult("Invalid number for stocks.");
            }

            if (numInStock <= 0)
            {
                return new ValidationResult("Number of stocks must be greater than 0.");
            }

            return ValidationResult.Success;
        }
    }
}
