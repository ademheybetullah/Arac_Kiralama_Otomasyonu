using System.Web;
using System.Web.Mvc;

namespace Araç_Kiralama_Otomasyonu
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
