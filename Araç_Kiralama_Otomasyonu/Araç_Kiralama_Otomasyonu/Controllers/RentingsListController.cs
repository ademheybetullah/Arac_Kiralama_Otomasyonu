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
    public class RentingsListController : Controller
    {
        CompanyBusiness companyBusiness = new CompanyBusiness();
        RentingBusiness rentingBusiness = new RentingBusiness();
        CarBusiness carBusiness = new CarBusiness();
        [Authorize]
        [HttpGet]
        public ActionResult ListRentings()
        {
            var id = Convert.ToInt32(Session["CustomerId"]);
            var Rentings = new RentingModel { Rentings = rentingBusiness.ListRentingsByUserId(id) };
            return View(Rentings);
        }
        [HttpPost]
        [Authorize]
        public ActionResult ListRentings(Renting renting)
        {
            var id = renting.RentingId;
            var _renting = rentingBusiness.GetRentingByRentingId(id);
            _renting.Score = renting.Score;
            var _company=companyBusiness.GetById(renting.CompanyId);
            _company.CompanyScore += renting.Score;
            rentingBusiness.UpdateRenting(_renting);
            companyBusiness.CompanyUpdate(_company);
            return RedirectToAction("ListRentings", "RentingsList");
        }
    }
}