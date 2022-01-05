using Araç_Kiralama_Otomasyonu.Models;
using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Araç_Kiralama_Otomasyonu.Controllers
{
    public class CompanyListController : Controller
    {
        CompanyBusiness companyBusiness = new CompanyBusiness();
        [Authorize]
        public ActionResult ListCompany()
        {
            var Companies = new CompanyModel { Companies = companyBusiness.GetCompanyList() };
            return View(Companies);
        }
    }
}