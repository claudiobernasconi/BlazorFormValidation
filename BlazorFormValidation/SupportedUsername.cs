using System.ComponentModel.DataAnnotations;

namespace BlazorFormValidation;

public class SupportedUsername : ValidationAttribute
{
    protected override ValidationResult IsValid(object value,
        ValidationContext validationContext)
    {
        var username = (string)value;
        if (username == "Bill Gates")
        {
            return new ValidationResult("You cannot use the reserved username 'Bill Gates'.",
                new[] { validationContext.MemberName });
        }

        return ValidationResult.Success!;
    }
}
