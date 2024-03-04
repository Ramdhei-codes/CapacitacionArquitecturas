using CapacitacionArquitecturas.Domain.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionArquitecturas.Infrastructure.DataAccess
{
    public class TasksDbContext : DbContext
    {
        public DbSet<ToDoTask> Tasks { get; set;}

        public TasksDbContext(DbContextOptions<TasksDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ToDoTask>(entity =>
            {
                entity.HasKey(entity => entity.Id);
                entity.Property(entity => entity.Id).HasDefaultValueSql("NEWID()");
            });

            // Seed initial data if needed
            modelBuilder.Entity<ToDoTask>().HasData(
                new ToDoTask {Id = Guid.NewGuid().ToString(), Title = "Sample Task 1", Description = "Description 1", IsCompleted = false },
                new ToDoTask {Id = Guid.NewGuid().ToString(), Title = "Sample Task 2", Description = "Description 2", IsCompleted = true }
            );
        }
    }
}
