using System;
using System.Collections.Generic;
using System.Linq;
using Todo.Data.Models;

namespace Todo.Data.Services
{
    public class InMemoryData : ITodoData
    {
        readonly List<TodoTask> todoTasks;

        public InMemoryData()
        {
            todoTasks = new List<TodoTask>()
                {
                new TodoTask { Id = 1, TaskName = "Code", TaskDescription = "Code, code and code some more" },
                new TodoTask { Id = 2, TaskName = "Eat", TaskDescription = "Menu: Pizza, Burger, Pasta, Wok, or Lasagna" },
                new TodoTask { Id = 3, TaskName = "Sleep", TaskDescription = "zzZZzzZZzZ for 6-8 hrs" }
                };
        }

        public void Add(TodoTask todo)
        {
            todoTasks.Add(todo);
            todo.Id = todoTasks.Max(t => t.Id) + 1;
        }

        public void Delete(int id)
        {
            var todo = Get(id);
            if (todo != null)
            {
                todoTasks.Remove(todo);
            }
        }

        public TodoTask Get(int id)
        {
            return todoTasks.Find(t => t.Id == id);
        }

        public IEnumerable<TodoTask> GetAll()
        {
            return todoTasks;
        }

        public void Update(TodoTask todo)
        {
            var existing = Get(todo.Id);

            if(existing != null)
            {
                existing.TaskName = todo.TaskName;
                existing.TaskDescription = todo.TaskDescription;
            }
        }
    }
 }

