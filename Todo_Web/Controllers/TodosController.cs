using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Todo.Data.Services;

namespace Todo_Web.Controllers
{
    public class TodosController : Controller
    {
        ITodoData db;

        public TodosController()
        {
            db = new InMemoryData();
        }
        // GET: Todos
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }
    }
}