using System.Web;
using System.Web.Mvc;

namespace StackOverFlow_Project.DomainModels
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
