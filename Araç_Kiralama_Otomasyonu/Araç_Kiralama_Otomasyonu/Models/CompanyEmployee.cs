using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Araç_Kiralama_Otomasyonu.Models
{
    public class CompanyEmployee
    {
        public Company company { get; set; }
        public Employee employee { get; set; }
    }
}