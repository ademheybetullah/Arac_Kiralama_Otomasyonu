using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Araç_Kiralama_Otomasyonu.Models;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;

namespace Araç_Kiralama_Otomasyonu.Controllers
{
    public class EmployeeListController : Controller
    {
        EmployeeBusiness employeeBusiness = new EmployeeBusiness();
        [Authorize]
        [HttpGet]
        public ActionResult ListEmployee()
        {
            var id = Convert.ToInt32(Session["CompanyId"]);
            var model = new EmployeeModel { Employees = employeeBusiness.GetEmployeeListByCompanyId(id) };
            return View(model);
        }
        [Authorize]
        [HttpPost]
        public ActionResult ListEmployee(Employee employee)
        {
            var _employe = employeeBusiness.GetEmployeeByEmployeeId(employee.EmployeeId);
            employeeBusiness.DeleteEmployee(_employe);
            return RedirectToAction("ListEmployee", "EmployeeList");
        }
    }
}