using System.Web;
using System.Web.Mvc;

namespace TranMinhHao_5951071021
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
