using Microsoft.EntityFrameworkCore;
using SifatSavdo.Data.Contexts;
using SifatSavdo.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SifatSavdo.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal SifatSavdoDbContext _dbContext;
        protected DbSet<T> _dbSet;
        public GenericRepository()
        {
             _dbContext = new SifatSavdoDbContext();
            _dbSet = _dbContext.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            var entry = await _dbSet.AddAsync(entity);

            await _dbContext.SaveChangesAsync();

            return entry.Entity;
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(expression);
            if (entity == null)
                return false;

            _dbSet.Remove(entity);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null)
        {
            return expression == null ? _dbSet : _dbSet.Where(expression);
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return _dbSet.FirstOrDefaultAsync(expression);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var entry = _dbSet.Update(entity);

            await _dbContext.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
