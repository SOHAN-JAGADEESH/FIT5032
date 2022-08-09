
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codesnippet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            Models.Exercise.Student student = new Models.Exercise.Student("Sohan", "0478842939");

            Models.Exercise.ExampleDictionary dict = new Models.Exercise.ExampleDictionary();
            ViewBag.Message = dict.Example();

            return View();


        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}