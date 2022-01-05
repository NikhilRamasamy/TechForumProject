using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employees.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        public ViewResult employeedetails()
        {
            return View("ShowDetails");
        }
    }
}