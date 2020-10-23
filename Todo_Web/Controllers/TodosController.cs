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
        private readonly ITodoData db;

        public TodosController(ITodoData db)
        {
            this.db = db;
        }
        // GET: Todos
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult Create()
        {

            return View();
        }

        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            return View(model);
        }
    }
}