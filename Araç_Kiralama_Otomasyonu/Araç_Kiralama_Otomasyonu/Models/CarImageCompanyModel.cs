using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Araç_Kiralama_Otomasyonu.Models
{
    public class CarImageCompanyModel
    {
        public List<Image> Images { get; set; }
        public List<Car> Cars { get; set; }
        public List<Company> Companies { get; set; }
    }
}