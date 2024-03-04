using CapacitacionArquitecturas.Domain.Database;
using CapacitacionArquitecturas.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace CapacitacionArquitecturas._DI
{
    public static class DependencyInjection
    {
        public static void Inject(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<TasksDbContext>(options =>
            {
                options.UseSqlite(builder.Configuration.GetConnectionString("TaskDbConnection"), b => b.MigrationsAssembly("CapacitacionArquitecturas"));
            });

            builder.Services.AddScoped<ITaskRepository, ToDoTaskRepository>();
        }
    }
}
