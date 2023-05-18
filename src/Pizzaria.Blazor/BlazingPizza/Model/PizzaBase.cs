namespace BlazingPizza.Model;

using System.ComponentModel.DataAnnotations;

public class PizzaBase : ValidationAttribute
{
    public string GetErrorMessage() => $"Sorry, that's not a valid pizza base.";

    protected override ValidationResult IsValid(
        object value, ValidationContext validationContext)
    {
        if (value != "Tomato" || value != "Pesto")
        {
            return new ValidationResult(GetErrorMessage());
        }

        return ValidationResult.Success;
    }
}
