using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Araç_Kiralama_Otomasyonu.Controllers
{
    public class LoginCustomerController : Controller
    {
        [HttpGet]
        public ActionResult CustomerLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CustomerLogin(Customer customer)
        {
            var crypto = new SimpleCrypto.PBKDF2();
            Context c = new Context();
            var user = c.Customers.Where(x => x.Email == customer.Email).FirstOrDefault();
            user.Password = crypto.Compute(customer.Password, user.Salt);
            var CustomerInfo = c.Customers.FirstOrDefault(x => x.Password == user.Password);
            if (CustomerInfo == null)
            {
                TempData["ErrorCard"] = "<script>alert('Şifre veya Eposta Yanlış!!');</script>";
                return RedirectToAction("CustomerLogin","LoginCustomer");
            }
            else
            {
                FormsAuthentication.SetAuthCookie(CustomerInfo.Email, false);
                Session["Email"] = CustomerInfo.Email;
                Session["Name"] = CustomerInfo.Name;
                Session["CustomerId"] = CustomerInfo.UserId;
                Session["Surname"] = CustomerInfo.Surname;
                Session["Address"] = CustomerInfo.Address;
                Session["PhoneNo"] = CustomerInfo.PhoneNo;
                return RedirectToAction("Dashboard", "CustomerDashboard");
            }
        }
    }
}