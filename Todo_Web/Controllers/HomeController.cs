using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Todo.Data.Services;
using Todo_Web.Models;

namespace Todo_Web.Controllers
{
    public class HomeController : Controller
    {
        ITodoData db;

        public HomeController()
        {
            db = new InMemoryData();
        }

        public ActionResult Index()
        {
            var model = new GreetingViewModel();
            model.Message = ConfigurationManager.AppSettings["message"];
            return View(model);
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