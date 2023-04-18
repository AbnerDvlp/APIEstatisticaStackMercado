using APIEstatisticasStacks.Business.DTOs;
using APIEstatisticasStacks.Business.Interfaces;
using APIEstatisticasStacks.Repository.Interfaces;
using AutoMapper;

namespace APIEstatisticasStacks.Business
{
    public class EstatisticasBusiness : IEstatisticasBusiness
    {
        private readonly IEstatisticaRepository _estatisticaRepository;
        private readonly IMapper _mapper;

        public EstatisticasBusiness(IEstatisticaRepository estatisticaRepository, IMapper mapper)
        {
            _estatisticaRepository = estatisticaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DadosEstatistica>> ObterTodos()
        {
            var ret = _mapper.Map<IEnumerable<DadosEstatistica>>(await _estatisticaRepository.ObterTodos());
            return ret;
        }

        public async Task<IEnumerable<DadosEstatistica>> ObterTodosOrderByPontos()
        {
            var ret = _mapper.Map<IEnumerable<DadosEstatistica>>(await _estatisticaRepository.ObterTodos()).OrderByDescending(x => x.pontos);
            return ret;
        }
    }
}