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
        object Get(int id);
    }
}
