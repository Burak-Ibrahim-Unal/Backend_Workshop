﻿using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Model).GreaterThan(1850);
            RuleFor(c => c.Model).LessThan(DateTime.Now.Year + 1);
        }
    }
}
