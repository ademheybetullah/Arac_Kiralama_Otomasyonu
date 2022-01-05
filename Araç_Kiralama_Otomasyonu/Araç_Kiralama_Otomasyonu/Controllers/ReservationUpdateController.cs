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
    public class ReservationUpdateController : Controller
    {
        ReservationBusiness reservationBusiness = new ReservationBusiness();
        CarBusiness carBusiness = new CarBusiness();
        [Authorize]
        [HttpGet]
        public ActionResult UpdateReservation()
        {
            var id = Convert.ToInt32(Session["CompanyId"]);
            ReservationModel reservations = new ReservationModel { Reservations = reservationBusiness.GetRsvListByCompanyId(id) };
            return View(reservations);
        }
    }
}