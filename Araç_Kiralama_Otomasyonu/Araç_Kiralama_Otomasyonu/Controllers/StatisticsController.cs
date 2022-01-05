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
    public class StatisticsController : Controller
    {
        CarBusiness carBusiness = new CarBusiness();
        CompanyBusiness companyBusiness = new CompanyBusiness();
        EmployeeBusiness employeeBusiness = new EmployeeBusiness();
        CustomerBusiness customerBusiness = new CustomerBusiness();
        [Authorize]
        public ActionResult ListStatistics()
        {
            var cars = carBusiness.ListAllCar();
            ViewBag.carCount = cars.Count();
            var companies = companyBusiness.GetCompanyList();
            ViewBag.companyCount = companies.Count();
            var customers = customerBusiness.GetCustomerList();
            ViewBag.customerCount = customers.Count();
            var employees = employeeBusiness.GetEmployeeList();
            ViewBag.employeeCount = employees.Count();
            return View();
        }
    }
}