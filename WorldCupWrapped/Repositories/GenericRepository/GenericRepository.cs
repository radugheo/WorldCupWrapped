using WorldCupWrapped.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace WorldCupWrapped.Repository.GenericRepository
{
    public class GenericRepository<TEntity>: IGenericRepository<TEntity> where TEntity: class
    {
        protected readonly ProjectContext _context;
        protected readonly DbSet<TEntity> _table;

        public GenericRepository(ProjectContext context)
        {
            _context = context;
            _table = context.Set<TEntity>();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _table.AsNoTracking().ToListAsync();
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

        public void CreateRange(IEnumerable<TEntity> entities)
        {
            _table.AddRange(entities);
        }

        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities);
        }

        public void Update(TEntity entity)
        {
            _table.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _table.UpdateRange(entities);
        }

        public void Delete(TEntity entity)
        {
            _table.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _table.RemoveRange(entities);
        }

        public void DeleteAll()
        {
            _table.RemoveRange(_table);
        }

        public async Task<TEntity> FindByIdAsync(object id)
        {
            return await _table.FindAsync(id);
        }

        public TEntity? FindById(object id)
        {
            return _table.Find(id);
        }

        public async Task<bool> SaveAsync()
        {
            try
            {
                return await _context.SaveChangesAsync() > 1;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
