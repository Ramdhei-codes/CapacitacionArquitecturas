using CapacitacionArquitecturas.Domain.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionArquitecturas.Domain.Database
{
    public interface ITaskRepository
    {
        ToDoTask GetById(string id);
        Task<ToDoTask> Create(ToDoTask task);
        Task<ToDoTask> Update(ToDoTask task);
        Task Delete(ToDoTask task);

    }
}
