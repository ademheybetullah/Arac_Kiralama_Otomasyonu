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
    public class ReservationListController : Controller
    {
        ReservationBusiness reservationBusiness = new ReservationBusiness();
        [Authorize]
        [HttpGet]
        public ActionResult ListReservations()
        {
            var id = Convert.ToInt32(Session["CustomerId"]);
            var Reservations = new ReservationModel { Reservations = reservationBusiness.ListRsvByUserId(id) };
            return View(Reservations);
        }
        [HttpPost]
        [Authorize]
        public ActionResult ListReservations(Reservation reservation)
        {
            var id = reservation.ReservationId;
            var _reservation = reservationBusiness.GetRsvByRsvId(id);
            reservationBusiness.DeleteReservation(_reservation);
            return RedirectToAction("ListReservations", "ReservationList");
        }
    }
}