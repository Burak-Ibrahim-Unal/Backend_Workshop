using FluentValidation;
using FluentValidationApp.Models;

namespace FluentValidationApp.FluentValidators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {

        public string NotEmptyMessage { get; } = "{PropertyName} can not be null or empty";
        public string GenderMessage { get; } = "{PropertyName} 1 is male,2 is female";

        public CustomerValidator()
        {
            RuleFor(property => property.Name).NotEmpty().WithMessage("Name can not be empty...");
            RuleFor(property => property.Mail).NotEmpty().WithMessage("Email can not be empty...").EmailAddress().WithMessage("Email must be in correct format...");
            RuleFor(property => property.Age).NotEmpty().WithMessage("Age can not be empty...").InclusiveBetween(18, 150).WithMessage("Age must be between 18 and 150");
            RuleFor(property => property.Birthday).NotEmpty().WithMessage(NotEmptyMessage).Must(property =>
            {
                return DateTime.Now.AddYears(-18) >= property;
            }).WithMessage("You have to be an adult for this process...+18...");

            RuleForEach(property => property.Addresses).SetValidator(new AddressValidator());
            RuleFor(property => property.Gender).IsInEnum().WithMessage(GenderMessage);
        }

    }
}
