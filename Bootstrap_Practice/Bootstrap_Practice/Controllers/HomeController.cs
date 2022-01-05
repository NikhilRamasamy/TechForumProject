using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap_Practice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Bootstrap()
        {
            ViewBag.Message = "Bootstrap sample.";
            return View();
        }
        public ActionResult Bootstrap_List()
        {
            ViewBag.Message = "Bootstrap List Page.";
            return View();
        }
        public ActionResult Bootstrap_form()
        {
            ViewBag.Message = "createing form using bootstrap.";
            return View();
        }
        public ActionResult Bootstrap_Table()
        {
            ViewBag.Message = "Creating table.";
            return View();
        }
    }
}