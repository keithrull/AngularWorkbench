using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularWorkbench.Controllers
{
    public class SamplesController : Controller
    {
        // GET: Samples
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Example1()
        {
            return View();
        }

        public ActionResult Example2()
        {
            return View();
        }

        public ActionResult Example3()
        {
            return View();
        }

        public ActionResult Example4()
        {
            return View();
        }

        public ActionResult Example5()
        {
            return View();
        }
    }
}