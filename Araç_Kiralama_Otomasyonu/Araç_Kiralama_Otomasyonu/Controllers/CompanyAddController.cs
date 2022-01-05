using Araç_Kiralama_Otomasyonu.Models;
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
    public class CompanyAddController : Controller
    {
        CompanyBusiness companyBusiness = new CompanyBusiness();
        EmployeeBusiness employeeBusiness = new EmployeeBusiness();
        [Authorize]
        [HttpGet]
        public ActionResult AddCompany()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult AddCompany(CompanyEmployee model)
        {
            CompanyValidator companyValidator = new CompanyValidator();
            ValidationResult results = companyValidator.Validate(model.company);
            EmployeeValidator employeeValidator = new EmployeeValidator();
            ValidationResult _results = employeeValidator.Validate(model.employee);
            if (results.IsValid && _results.IsValid)
            {
                model.company.CompanyScore = 0;
                model.company.CarCount = 0;
                companyBusiness.AddCompany(model.company);
                model.employee.Status = "Müdür";
                model.employee.CompanyId = model.company.CompanyId;
                var crypto = new SimpleCrypto.PBKDF2();
                model.employee.Password = crypto.Compute(model.employee.Password);
                model.employee.Salt = crypto.Salt;
                employeeBusiness.AddEmployee(model.employee);
                return RedirectToAction("ListCompany","CompanyList");
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