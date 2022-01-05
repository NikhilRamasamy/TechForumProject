using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employees.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ViewResult employeelogout()
        {
            return View("UserLogout");
        }
    }
}