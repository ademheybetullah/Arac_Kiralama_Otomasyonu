using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.CarCategory).NotEmpty().WithMessage("Araç kategori bilgisini boş geçemezsiniz.");
            RuleFor(x => x.CarCategory).MinimumLength(3).MaximumLength(20).WithMessage("Kategori bilgisi 3-20 karakterden oluşmalı");
            RuleFor(x => x.Brand).NotEmpty().WithMessage("Araç marka bilgisini boş geçemezsiniz.");
            RuleFor(x => x.Brand).MinimumLength(3).MaximumLength(20).WithMessage("Marka bilgisi 3-20 karakterden oluşmalı");
            RuleFor(x => x.Color).NotEmpty().WithMessage("Araç renk bilgisini boş geçemezsiniz.");
            RuleFor(x => x.Color).MinimumLength(3).MaximumLength(15).WithMessage("Renk bilgisi 3-15 karakterden oluşmalı");
            RuleFor(x => x.FuelType).NotEmpty().WithMessage("Araç yakıt türü bilgisini boş geçemezsiniz.");
            RuleFor(x => x.FuelType).MinimumLength(3).MaximumLength(10).WithMessage("Yakıt türü bilgisi 3-10 karakterden oluşmalı");
            RuleFor(x => x.GearType).NotEmpty().WithMessage("Araç vites türü bilgisini boş geçemezsiniz.");
            RuleFor(x => x.GearType).MinimumLength(3).MaximumLength(15).WithMessage("Vites türü bilgisi 3-15 karakterden oluşmalı");
            RuleFor(x => x.InstantKm).NotEmpty().WithMessage("Araç KM bilgisini boş geçemezsiniz.");
            RuleFor(x => x.Model).NotEmpty().WithMessage("Model bilgisini boş geçemezsiniz.");
            RuleFor(x => x.Model).MinimumLength(3).MaximumLength(20).WithMessage("Model bilgisi 3-20 karakterden oluşmalı");
            RuleFor(x => x.Seats).NotEmpty().WithMessage("Koltuk sayısı bilgisini boş geçemezsiniz.");
            RuleFor(x => x.RentalFee).NotEmpty().WithMessage("Kiralama ücreti bilgisini boş geçemezsiniz.");
            RuleFor(x => x.RentalStatus).NotEmpty().WithMessage("Kiralanabilirlik bilgisini boş geçemezsiniz.");
            RuleFor(x => x.MinAge).NotEmpty().WithMessage("Minimum yaş bilgisini boş geçemezsiniz.");
            RuleFor(x => x.MinDrivingLicenseAge).NotEmpty().WithMessage("Minimum ehliyet yaşı bilgisini boş geçemezsiniz.");
        }
    }
}
