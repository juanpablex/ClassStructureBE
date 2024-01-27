using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.FieldRepository.Validation
{
    public class FieldValidator:AbstractValidator<Field>
    {
        public FieldValidator()
        {
            RuleFor(p => p.dataType).NotEmpty().WithMessage("dataType cannot be empty");
            RuleFor(p => p.valueData).NotEmpty().WithMessage("valueData cannot be empty");
            RuleFor(p => p.TableId).NotEmpty().WithMessage("TableId cannot be null");
        }
    }
}