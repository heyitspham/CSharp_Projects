using Step442_MVC_tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Step442_MVC_tutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\Administrator\source\repos\CSharp_WebApplications\Step442_MVC_tutorial\log.txt", text);

            //Random rnd = new Random(10);
            //int num = rnd.Next();
            ////ViewBag.RandomNumber = num;
            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //return View();

            //return Content("hello");

            //return RedirectToAction("Contact");

            //return View("Contact");

            //List<string> names = new List<string> { "Jesse", "Adam", "Brett"};
            //return View(names);

            //int number = 5;
            //return View(number);

            User user = new User();
            user.Id = 1;
            user.FirstName = "Vinh";
            user.LastName = "Pham";
            user.Age = 32;
            return View(user);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw new Exception("Invalid page");

            return View();
        }

        //public ActionResult Contact(int id = 0)
        public ActionResult Contact(int id = 0)
        {
            //ViewBag.Message = id;
            ViewBag.Message = id;

            return View();
        }
    }
}