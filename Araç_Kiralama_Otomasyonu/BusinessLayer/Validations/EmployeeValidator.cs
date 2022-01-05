using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("Adresdres bilgisini boş geçemezsiniz.");
            RuleFor(x => x.Address).MinimumLength(3).MaximumLength(500).WithMessage("Adres bilgisi 3-500 karakterden oluşmalı");
            //RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre bilgisini boş geçemezsiniz.");
           // RuleFor(x => x.Password).MinimumLength(6).WithMessage("Şifre bilgisi minimum 6 karakterden oluşmalı");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim bilgisini boş geçemezsiniz.");
            RuleFor(x => x.Name).MinimumLength(2).MaximumLength(20).WithMessage("İsim bilgisi 2-20 karakterden oluşmalı");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim bilgisini boş geçemezsiniz.");
            RuleFor(x => x.Surname).MinimumLength(2).MaximumLength(20).WithMessage("Soyisim bilgisi 2-20 karakterden oluşmalı");
            RuleFor(x => x.PhoneNo).NotEmpty().WithMessage("Telefon no bilgisini boş geçemezsiniz.");
            RuleFor(x => x.PhoneNo).Length(10).WithMessage("Telefon no bilgisi 10 karakterden oluşmalı(Başında sıfır olmadan giriniz)");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail bilgisini boş geçemezsiniz.");
            RuleFor(x => x.Email).MinimumLength(2).MaximumLength(50).WithMessage("Mail bilgisi 2-50 karakterden oluşmalı");
        }
    }
}
