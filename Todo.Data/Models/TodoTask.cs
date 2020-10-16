using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Data.Models
{
    public class TodoTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime Deadline { get; set; }
        public bool Completed { get; set; }
        public List<TodoSubTask> subTasks { get; set; }

    }
}
