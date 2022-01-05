using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Araç_Kiralama_Otomasyonu.Controllers
{
    public class CustomerProfilController : Controller
    {
        [Authorize]
        public ActionResult MyProfil()
        {
            return View();
        }
    }
}