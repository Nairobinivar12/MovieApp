using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using FluentValidation;

namespace Infrastructure.Validation
{
    public class Validation  : AbstractValidator<Users>
    {
        //RuleFor(Users => u)
        //        .NotEmpty().WithMessage("Name is required")
        //        .MaximumLength(100).WithMessage("Name must be less than 100 characters");
    }
}
