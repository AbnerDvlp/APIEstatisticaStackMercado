using APIEstatisticasStacks.Repository.Entitys;
using APIEstatisticasStacks.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace APIEstatisticasStacks.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity, new()
    {
        protected readonly ApiDbContext _db;
        protected readonly DbSet<TEntity> _dbSet;

        protected RepositoryBase(ApiDbContext apiDb)
        {
            _db = apiDb;
            _dbSet = _db.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicado)
        {
            return await _dbSet.AsNoTracking().Where(predicado).ToListAsync();
        }

        public virtual async Task<TEntity?> ObterPorId(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<Entity>> ObterTodos()
        {
            return await _dbSet.ToListAsync();
        }
    }
}