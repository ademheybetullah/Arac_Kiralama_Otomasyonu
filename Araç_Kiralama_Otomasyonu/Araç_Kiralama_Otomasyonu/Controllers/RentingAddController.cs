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
    public class RentingAddController : Controller
    {

        RentingBusiness rentingBusiness = new RentingBusiness();
        ReservationBusiness reservationBusiness = new ReservationBusiness();
        ImageBusiness imageBusiness = new ImageBusiness();
        CarBusiness cm = new CarBusiness();
        Car car;
        [Authorize]
        [HttpGet]
        
        public ActionResult AddRenting(int id)
        {
            string[,] RentedDates = new string[20, 2];
            string[,] ReservedDates = new string[20, 2];
            string[,] AllDates = new string[40, 2];
            car = cm.GetCarById(id);
            var rentings=rentingBusiness.GetRengingListById(id);
            for (int i = 0; i < rentings.Count(); i++)
            {
                RentedDates[i,0] = rentings[i].StartDate.Date.ToString("d");
                RentedDates[i,1] = rentings[i].FinishDate.Date.ToString("d");
            }
            var reservations = reservationBusiness.GetRsvListByCarId(id);
            for (int i = 0; i < reservations.Count(); i++)
            {
                ReservedDates[i, 0] = reservations[i].StartDate.Date.ToString("d");
                ReservedDates[i, 1] = reservations[i].FinishDate.Date.ToString("d");
            }
            int d = reservations.Count() + rentings.Count();
            for (int i = 0; i < d; i++)
            {
                AllDates[i, 0] = ReservedDates[i, 0];
                AllDates[i, 1] = ReservedDates[i, 1];
                AllDates[i + 20, 0] = RentedDates[i, 0];
                AllDates[i + 20, 1] = RentedDates[i, 1];
            }

            ViewBag.CarId = car.CarId;
            ViewBag.RentingFee = car.RentalFee;
            ViewBag.StartKm = car.InstantKm;
            ViewBag.Dates = AllDates;
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult AddRenting(Renting renting,int id)
        {
            RentingValidator rules = new RentingValidator();
            var x = renting.StartDate;
            var xy= renting.FinishDate;
            ValidationResult results = rules.Validate(renting);
            if (results.IsValid)
            {
                car = cm.GetCarById(id);
                renting.CompanyId = car.CompanyId;
                renting.ImagePath = imageBusiness.ListImageById(car.CarId)[0].ImagePath;
                car.RentalStatus = false;
                cm.CarUpdate(car);
                rentingBusiness.AddRenting(renting);
                return RedirectToAction("ListRentings","RentingsList");
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