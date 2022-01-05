using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class RentingValidator:AbstractValidator<Renting>
    {
        public RentingValidator()
        {
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Tarih bilgisini boş geçemezsiniz.");
            RuleFor(x => x.FinishDate).NotEmpty().WithMessage("Tarih bilgisini boş geçemezsiniz.");
        }
    }
}
