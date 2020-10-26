using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Todo.Data.Models;
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
        
        [HttpGet]
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if(model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TodoTask todo)
        {
            if (ModelState.IsValid)
            {
                db.Add(todo);
                return View();
            }
            return View();
        }
    }
}