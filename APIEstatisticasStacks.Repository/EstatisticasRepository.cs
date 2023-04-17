using APIEstatisticasStacks.Repository;
using APIEstatisticasStacks.Repository.Entitys;
using APIEstatisticasStacks.Repository.Interfaces;

namespace APIEstatisticasStacks.Repositorysitory
{
    public class EstatisticasRepository : RepositoryBase<EstatisticasStackVagas>, IEstatisticaRepository
    {
        public EstatisticasRepository(ApiDbContext apiDb) : base(apiDb)
        {
        }
    }
}