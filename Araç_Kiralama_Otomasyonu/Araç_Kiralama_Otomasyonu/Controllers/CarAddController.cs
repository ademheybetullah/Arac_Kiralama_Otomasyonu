using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Araç_Kiralama_Otomasyonu.Controllers
{
    public class CarAddController : Controller
    {
        CompanyBusiness companyBusiness = new CompanyBusiness();
        CarBusiness carBusiness = new CarBusiness();
        ImageBusiness imageBusiness = new ImageBusiness();
        [Authorize]
        [HttpGet]
        public ActionResult AddCar()
        {
            ViewBag.AuthId = Convert.ToInt32(TempData["AuthCompanyId"]);
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult AddCar(Car car)
        {
            CarValidator carValidator = new CarValidator();
            ValidationResult results = carValidator.Validate(car);
            if (results.IsValid)
            {
                Company company = new Company();
                company = companyBusiness.GetById(car.CompanyId);
                company.CarCount += 1;
                carBusiness.AddCar(car);
                companyBusiness.CompanyUpdate(company);
                return RedirectToAction("ListCar","CarList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
            
        }

    }
}