using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Data.Models;

namespace Todo.Data.Services
{
    public interface ITodoData
    {
        IEnumerable<TodoTask> GetAll();
        TodoTask Get(int id);
        void Add(TodoTask todo);
        void Update(TodoTask todo);
        void Delete(int id);
    }
}
