using System.Web;
using System.Web.Mvc;

namespace _20231633_Jared_Jonosky_SLD_Formative
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
