using Assignment1CPW213.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1CPW213.Controllers
{
    public class addModelBindingController : Controller
    {
        // GET: addModelBinding
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Information info)
        {
            // this ensures all validation rules for the model have passed
            if (ModelState.IsValid)
            {
                if (AutoInformation.AddInfo(info))
                {
                    ViewBag.Added = true;
                }
            }
            return View();
        }
    }
}