using APIEstatisticasStacks.Repository.Entitys;
using System.Linq.Expressions;

namespace APIEstatisticasStacks.Repository.Interfaces
{
    public interface IRepositoryBase<TEntity>
    {
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicado);

        Task<TEntity?> ObterPorId(int id);

        Task<IEnumerable<Entity>> ObterTodos();
    }
}