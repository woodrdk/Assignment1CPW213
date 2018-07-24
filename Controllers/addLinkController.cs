using Assignment1CPW213.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1CPW213.Controllers
{
    public class addLinkController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // this will get called after a user submits an html form
        // aka after they post data to the server
        [HttpPost]
        public ActionResult Index(FormCollection formData)
        {

            Information info = new Information
            {
                SiteName = formData["sn"],
                URL = formData["URL"]
            };

            // if everything is valid, add to database
            if (AutoInformation.AddInfo(info))
            {
                // viewbag data only works for the current request
                ViewBag.LinkAdded = true;
            }

            // let the user know it was successful or Display error message(s)
            return View();
        }
    }
}