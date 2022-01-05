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
    public class CustomerAddController : Controller
    {
        // GET: Customer
        CustomerBusiness customerBusiness = new CustomerBusiness();
        
        
        [HttpGet]
        [Authorize]
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddCustomer(Customer customer)
        {
            var crypto = new SimpleCrypto.PBKDF2();
            customer.Password = crypto.Compute(customer.Password);
            customer.Salt = crypto.Salt;
            CustomerValidator customerValidator = new CustomerValidator();
            ValidationResult results = customerValidator.Validate(customer);
            if (results.IsValid)
            {
                customerBusiness.AddCustomer(customer);
                return RedirectToAction("Dashboard", "CustomerDashboard");
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