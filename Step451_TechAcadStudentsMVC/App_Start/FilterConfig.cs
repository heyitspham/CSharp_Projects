using System.Web;
using System.Web.Mvc;

namespace Step451_TechAcadStudentsMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
