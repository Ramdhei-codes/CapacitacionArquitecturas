using CapacitacionArquitecturas.Domain.Database;
using CapacitacionArquitecturas.Domain.Tasks;

namespace CapacitacionArquitecturas.Infrastructure.DataAccess
{
    public class ToDoTaskRepository : ITaskRepository
    {
        private readonly TasksDbContext _dbContext;

        public ToDoTaskRepository(TasksDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ToDoTask> Create(ToDoTask task)
        {
            _dbContext.Tasks.Add(task);
            await _dbContext.SaveChangesAsync();
            return task;
        }

        public async Task Delete(ToDoTask task)
        {
            _dbContext.Remove(task);
            await _dbContext.SaveChangesAsync();
        }

        public ToDoTask GetById(string id)
        {
            return _dbContext.Tasks.FirstOrDefault(task => task.Id == id)!; 
        }

        public async Task<ToDoTask> Update(ToDoTask task)
        {
            _dbContext.Tasks.Update(task);
            await _dbContext.SaveChangesAsync();
            return task;
        }
    }
}
