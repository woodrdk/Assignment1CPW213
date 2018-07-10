using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1CPW213.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
            // will return the contact page
        }
                
        public ActionResult Cars()
        {
            return View();
        }
    }
}