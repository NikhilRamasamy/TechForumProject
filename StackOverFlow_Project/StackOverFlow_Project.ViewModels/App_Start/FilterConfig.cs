using System.Web;
using System.Web.Mvc;

namespace StackOverFlow_Project.ViewModels
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
