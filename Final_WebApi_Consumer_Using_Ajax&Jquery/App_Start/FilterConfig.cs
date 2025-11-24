using System.Web;
using System.Web.Mvc;

namespace Final_WebApi_Consumer_Using_Ajax_Jquery
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
