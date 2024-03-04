﻿using CapacitacionArquitecturas.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
        }
    }
}
