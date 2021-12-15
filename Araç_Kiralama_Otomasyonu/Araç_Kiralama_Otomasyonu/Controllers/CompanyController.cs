using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Araç_Kiralama_Otomasyonu.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        CompanyBusiness companyBusiness = new CompanyBusiness();
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddCompany()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCompany(Company company)
        {
            companyBusiness.AddCompany(company);
            return RedirectToAction("ListCompany");
        }
        public ActionResult ListCompany()
        {
            var Companies = companyBusiness.GetCompanyList();
            return View(Companies);
        }
    }
}