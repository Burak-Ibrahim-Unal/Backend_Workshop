using FluentValidation;
using FluentValidationApp.Models;

namespace FluentValidationApp.FluentValidators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(property => property.Name).NotEmpty().WithMessage("Name can not be empty..");
            RuleFor(property => property.Mail).NotEmpty().WithMessage("Email can not be empty").EmailAddress().WithMessage("Email must be in correct format...");
            RuleFor(property => property.Age).NotEmpty().WithMessage("Age can not be empty...").InclusiveBetween(18, 150).WithMessage("Age must be between 18 and 150");

        }
    }
}
