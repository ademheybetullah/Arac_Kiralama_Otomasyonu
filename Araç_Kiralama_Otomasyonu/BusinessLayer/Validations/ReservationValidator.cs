using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class ReservationValidator : AbstractValidator<Reservation>
    {
        public ReservationValidator()
        {
            RuleFor(x => x.StartDate).NotNull().WithMessage("Tarih bilgisini boş geçemezsiniz.");
            RuleFor(x => x.FinishDate).NotNull().WithMessage("Tarih bilgisini boş geçemezsiniz.");
        }
    }
}
