using CapacitacionArquitecturas.Domain.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionArquitecturas.Infrastructure.DataAccess
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {
        private readonly TasksDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(TasksDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public TEntity Create(TEntity entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity Update(TEntity entity)
        {
            _dbSet.Update(entity);
            return entity;
        }
    }
}
