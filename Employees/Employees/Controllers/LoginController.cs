using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employees.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ViewResult employeelogin()
        {
            return View("Register");
        }
        public ViewResult employeeuserlogin()
        {
            return View("UserLogin");
        }
        public Boolean checkdata(string empusername,string emppassword)
        {
            if(empusername =="Nikhil" && emppassword == "Nikhil123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}