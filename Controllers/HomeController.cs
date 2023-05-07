using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntershipCode_bank_login.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username ,string password)
        {

            if(username=="Abhi@relationshipManeger" && password=="Relationship@123")
            {
                return RedirectToAction("RelationshipManager"); 
            }
            else if(username == "Abhi@operationalManeger" && password == "Relationship@123")
            {
                return RedirectToAction("OperationalManager");
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        public ActionResult LoginPage()
        {
            return View();  
        }
        public ActionResult SignUpPage()
        {
            return View();
        }
        public ActionResult RelationshipManager()
        {
            return View();
        }
        public ActionResult OperationalManager()
        {
            return View();
        }

        public ActionResult CreateCustomer()
        {
            return View();
        }

        public ActionResult ProductMetrics()
        {
            return View();
        }
        public ActionResult OrderManagement()
        {
            return View();

        }

        public ActionResult CustomerSupport()
        {
            return View();

        }

        public ActionResult EmployeeManagement()
        {
            return View();

        }

        public ActionResult Error()
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
    }
}