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
    public class LoginAdminController : Controller
    {
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin admin)
        {
            Context c = new Context();
            var AdminInfo = c.Admins.FirstOrDefault(x => x.Email == admin.Email && x.Password == admin.Password);
            if (AdminInfo == null)
            {
                TempData["ErrorCard"] = "<script>alert('Şifre veya Eposta Yanlış!!');</script>";
                return RedirectToAction("AdminLogin","LoginAdmin");
            }
            else
            {
                FormsAuthentication.SetAuthCookie(AdminInfo.Email, false);
                Session["Email"] = AdminInfo.Email;
                Session["Id"] = AdminInfo.AdminId;
                Session["Name"] = AdminInfo.Name;
                Session["Surname"] = AdminInfo.Surname;
                return RedirectToAction("ListCompany", "CompanyList");
            }
        }
    }
}