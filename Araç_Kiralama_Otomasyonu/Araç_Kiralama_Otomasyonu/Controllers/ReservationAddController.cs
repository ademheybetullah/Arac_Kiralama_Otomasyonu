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
    public class ReservationAddController : Controller
    {
        ReservationBusiness reservationBusiness = new ReservationBusiness();
        RentingBusiness rentingBusiness = new RentingBusiness();
        ImageBusiness imageBusiness = new ImageBusiness();
        CarBusiness cm = new CarBusiness();
        Car car;
        [Authorize]
        [HttpGet]
        public ActionResult AddReservation(int id)
        {
            string[,] RentedDates = new string[20, 2];
            string[,] ReservedDates = new string[20, 2];
            string[,] AllDates = new string[40, 2];
            car = cm.GetCarById(id);
            var rentings = rentingBusiness.GetRengingListById(id);
            for (int i = 0; i < rentings.Count(); i++)
            {
                RentedDates[i, 0] = rentings[i].StartDate.Date.ToString("d");
                RentedDates[i, 1] = rentings[i].FinishDate.Date.ToString("d");
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
            ViewBag.DepositFee = car.DepositFee;
            ViewBag.StartKm = car.InstantKm;
            ViewBag.Dates = AllDates;
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult AddReservation(Reservation reservation, int id)
        {
            ReservationValidator rules = new ReservationValidator();
            ValidationResult results = rules.Validate(reservation);
            if (results.IsValid)
            {
                car = cm.GetCarById(id);
                reservation.CompanyId = car.CompanyId;
                reservation.ImagePath = imageBusiness.ListImageById(car.CarId)[0].ImagePath;
                car.RentalStatus = false;
                cm.CarUpdate(car);
                reservationBusiness.AddReservation(reservation);
                return RedirectToAction("ListReservations", "ReservationList");
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