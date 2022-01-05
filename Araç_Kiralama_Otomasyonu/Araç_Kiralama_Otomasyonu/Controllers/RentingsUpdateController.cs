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
    public class RentingsUpdateController : Controller
    {
        CompanyBusiness companyBusiness = new CompanyBusiness();
        RentingBusiness rentingBusiness = new RentingBusiness();
        CarBusiness carBusiness = new CarBusiness();
        [Authorize]
        [HttpGet]
        public ActionResult UpdateRenting()
        {
            var id = Convert.ToInt32(Session["CompanyId"]);
            RentingModel rentings = new RentingModel {Rentings = rentingBusiness.GetRengingListByCompanyId(id) };
            return View(rentings);
        }
        [Authorize]
        [HttpPost]
        public ActionResult UpdateRenting(Renting renting)
        {
            var id = renting.RentingId;
            var _renting = rentingBusiness.GetRentingByRentingId(id);
            _renting.LastKm = renting.LastKm;
            var _car = carBusiness.GetCarById(renting.CarId);
            _car.InstantKm = renting.LastKm;
            rentingBusiness.UpdateRenting(_renting);
            carBusiness.CarUpdate(_car);
            return RedirectToAction("UpdateRenting", "RentingsUpdate");
        }
    }
}