using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentalDate).NotEmpty();
            RuleFor(r => r.CarId).NotEmpty();
            RuleFor(r => r.CustomerId).NotEmpty();

            RuleFor(r=> r.RentalDate).LessThanOrEqualTo(DateTime.Now);
            RuleFor(r=> r.TotalDays).GreaterThanOrEqualTo(1);
        }
    }
}
