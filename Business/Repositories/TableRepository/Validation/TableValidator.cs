using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.TableRepository.Validation
{
    public class TableValidator:AbstractValidator<Table>
    {
        public TableValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}