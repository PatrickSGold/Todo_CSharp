using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Data.Models;

namespace Todo.Data.Services
{
    public class TodoDbContext : DbContext
    {
        public DbSet<TodoTask> Todos { get; set; }
    }
}
