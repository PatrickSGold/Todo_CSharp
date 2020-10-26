using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Data.Models;

namespace Todo.Data.Services
{
    public class SqlTodoData : ITodoData
    {
        private readonly TodoDbContext db;

        public SqlTodoData(TodoDbContext db)
        {
            this.db = db;
        }

        public void Add(TodoTask todo)
        {
            db.Todos.Add(todo);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var todo = db.Todos.Find(id);
            db.Todos.Remove(todo);
            db.SaveChanges();
        }

        public TodoTask Get(int id)
        {
            return db.Todos.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<TodoTask> GetAll()
        {
            return db.Todos;
        }

        public void Update(TodoTask todo)
        {
            var entry = db.Entry(todo);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
