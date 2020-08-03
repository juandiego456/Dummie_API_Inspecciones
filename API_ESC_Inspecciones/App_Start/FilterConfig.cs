using System.Web;
using System.Web.Mvc;

namespace API_ESC_Inspecciones
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
