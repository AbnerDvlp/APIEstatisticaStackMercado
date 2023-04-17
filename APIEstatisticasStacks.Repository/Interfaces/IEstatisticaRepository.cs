using APIEstatisticasStacks.Repository.Entitys;

namespace APIEstatisticasStacks.Repository.Interfaces
{
    public interface IEstatisticaRepository
    {
        Task<IEnumerable<Entity>> ObterTodos();
    }
}