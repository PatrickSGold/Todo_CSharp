using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Data.Models
{
    public class TodoTask
    {
        public int Id { get; set; }
        
        [Required]
        public string TaskName { get; set; }
        
        public string TaskDescription { get; set; }
        
        public bool Completed { get; set; }
    }
}
