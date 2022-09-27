using System.Web;
using System.Web.Mvc;

namespace MT_LABTASK_1_PORTFOLIO
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
