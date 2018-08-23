using System.Web;
using System.Web.Mvc;

namespace Rad302RepeatExams00152908
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
