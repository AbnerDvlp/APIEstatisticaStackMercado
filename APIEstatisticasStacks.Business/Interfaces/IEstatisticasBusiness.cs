using APIEstatisticasStacks.Business.DTOs;

namespace APIEstatisticasStacks.Business.Interfaces
{
    public interface IEstatisticasBusiness
    {
        Task<IEnumerable<DadosEstatistica>> ObterTodos();
    }
}