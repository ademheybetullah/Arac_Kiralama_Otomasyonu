using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Araç_Kiralama_Otomasyonu.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        CustomerBusiness customerBusiness = new CustomerBusiness();
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            customerBusiness.AddCustomer(customer);
            return RedirectToAction("ListCustomer");
        }
        public ActionResult ListCustomer()
        {
            var Customers = customerBusiness.GetCustomerList();
            return View(Customers);
        }
    }
}