using Araç_Kiralama_Otomasyonu.Models;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Araç_Kiralama_Otomasyonu.Controllers
{
    public class CarListController : Controller
    {
        CompanyBusiness companyBusiness = new CompanyBusiness();
        CarBusiness carBusiness = new CarBusiness();
        ImageBusiness imageBusiness = new ImageBusiness();
        [Authorize]
        [HttpGet]
        public ActionResult ListCar()
        {
            var id = Convert.ToInt32(Session["CompanyId"]);
            var model = new CarImageCompanyModel { Cars = carBusiness.GetCarList(id), Images = imageBusiness.ListAllImage()};
            return View(model);
        }
        [Authorize]
        [HttpPost]
        public ActionResult ListCar(Car car)
        {
            var oldCar = carBusiness.GetCarById(car.CarId);
            oldCar.Brand = car.Brand;
            oldCar.CarCategory = car.CarCategory;
            oldCar.Model = car.Model;
            oldCar.RentalFee = car.RentalFee;
            oldCar.DepositFee = car.DepositFee;
            oldCar.MinAge = car.MinAge;
            oldCar.InstantKm = car.InstantKm;
            oldCar.Seats = car.Seats;
            carBusiness.CarUpdate(oldCar);
            return RedirectToAction("ListCar");
        }
        [Authorize]
        public ActionResult ListAllCar()
        {
            var model = new CarImageCompanyModel { Cars = carBusiness.ListAllCar(),Images=imageBusiness.ListAllImage(),Companies=companyBusiness.GetCompanyList()};
            return View(model);
        }

    }
}