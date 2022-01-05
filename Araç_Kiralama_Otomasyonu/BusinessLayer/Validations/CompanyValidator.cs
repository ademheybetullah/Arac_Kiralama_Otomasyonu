using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("Adresdres bilgisini boş geçemezsiniz.");
            RuleFor(x => x.Address).MinimumLength(3).MaximumLength(500).WithMessage("Adres bilgisi 3-500 karakterden oluşmalı");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir bilgisini boş geçemezsiniz.");
            RuleFor(x => x.City).MinimumLength(3).MaximumLength(20).WithMessage("Şehir bilgisi 3-20 karakterden oluşmalı");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim bilgisini boş geçemezsiniz.");
            RuleFor(x => x.Name).MinimumLength(3).MaximumLength(20).WithMessage("İsim bilgisi 3-50 karakterden oluşmalı");
        }
    }
}
