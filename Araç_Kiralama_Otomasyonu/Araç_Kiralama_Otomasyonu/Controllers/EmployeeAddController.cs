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
    public class EmployeeAddController : Controller
    {
        EmployeeBusiness employeeBusiness = new EmployeeBusiness();


        [HttpGet]
        [Authorize]
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddEmployee(Employee employee)
        {
            var crypto = new SimpleCrypto.PBKDF2();
            employee.Password = crypto.Compute(employee.Password);
            employee.Salt = crypto.Salt;
            EmployeeValidator employeValidator = new EmployeeValidator();
            ValidationResult results = employeValidator.Validate(employee);
            if (results.IsValid)
            {
                employeeBusiness.AddEmployee(employee);
                return RedirectToAction("ListEmployee", "EmployeeList");
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