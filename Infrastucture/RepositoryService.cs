using Microsoft.EntityFrameworkCore;
using Template.Data;

namespace Template.Infrastucture
{
    public class RepositoryService<T> : IRepository<T> where T : class
    {
        private AppDbContext _context;
        private DbSet<T> dbSet;

        public RepositoryService(AppDbContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }
        public  virtual async Task<T> Create(T entity)
        {
            dbSet.Add(entity);
         await  _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task Delete(int id)
        {
            var entity = await dbSet.FindAsync(id);
            if (entity != null) dbSet.Remove(entity);
        }

        public virtual  async Task<List<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual async Task<T> Update(int id, T entity)
        {
            dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
