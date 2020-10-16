using System;

namespace Todo.Data.Models
{
    public class TodoSubTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime Deadline { get; set; }
        public bool Completed { get; set; }
    }
}