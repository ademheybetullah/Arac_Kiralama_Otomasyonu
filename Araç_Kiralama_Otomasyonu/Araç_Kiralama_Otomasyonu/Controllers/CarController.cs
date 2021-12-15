using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Araç_Kiralama_Otomasyonu.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        CarBusiness carBusiness = new CarBusiness();
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCar(Car car)
        {
            carBusiness.AddCar(car);
            return RedirectToAction("ListCar");
        }
        public ActionResult ListCar()
        {
            var Cars = carBusiness.GetCarList();
            return View(Cars);
        }
    }
}