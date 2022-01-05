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
    public class LoginEmployeeController : Controller
    {
        
        [HttpGet]
        public ActionResult EmployeeLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EmployeeLogin(Employee employee)
        {

            var crypto = new SimpleCrypto.PBKDF2();
            Context c = new Context();
            var user = c.Employees.Where(x => x.Email == employee.Email).FirstOrDefault();
            user.Password = crypto.Compute(employee.Password, user.Salt);
            var employeeInfo = c.Employees.FirstOrDefault(x => x.Password == user.Password);
            if (employeeInfo == null)
            {
                TempData["ErrorCard"] = "<script>alert('Şifre veya Eposta Yanlış!!');</script>";
                return RedirectToAction("EmployeeLogin", "LoginEmployee");
            }
            else
            {
                FormsAuthentication.SetAuthCookie(employeeInfo.Email, false);
                Session["Name"] = employeeInfo.Name;
                Session["CompanyId"] = employeeInfo.CompanyId;
                Session["Status"] = employeeInfo.Status;
                Session["Adress"] = employeeInfo.Address;
                Session["Email"] = employeeInfo.Email;
                Session["EmployeeId"] = employeeInfo.EmployeeId;
                Session["PhoneNo"] = employeeInfo.PhoneNo;
                Session["Surname"] = employeeInfo.Surname;
                return RedirectToAction("ListCar", "CarList");
            }
        }
        
        
    }
}