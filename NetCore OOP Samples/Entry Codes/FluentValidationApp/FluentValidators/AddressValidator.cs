using FluentValidation;
using FluentValidationApp.Models;

namespace FluentValidationApp.FluentValidators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} field can not be empty...";
        public string Max30LengthMessage { get; } = "{PropertyName} field can not be longer than {MaxLength}  chars...";

        public AddressValidator()
        {
            RuleFor(prop => prop.City).NotEmpty().WithMessage(NotEmptyMessage).MaximumLength(30).WithMessage(Max30LengthMessage);
            RuleFor(prop => prop.State).NotEmpty().WithMessage(NotEmptyMessage);

        }
    }
}
