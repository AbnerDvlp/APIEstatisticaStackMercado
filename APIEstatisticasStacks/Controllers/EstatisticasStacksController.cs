using APIEstatisticasStacks.Business.DTOs;
using APIEstatisticasStacks.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIEstatisticasStacks.Controllers
{
    [ApiController]
    [Route("api/estatisticas")]
    public class EstatisticasStacksController : ControllerBase
    {
        private readonly IEstatisticasBusiness _estatisticasBusiness;

        public EstatisticasStacksController(IEstatisticasBusiness estatisticasBusiness)
        {
            _estatisticasBusiness = estatisticasBusiness;
        }

        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<DadosEstatistica>>> Get()
        {
            var ret = await _estatisticasBusiness.ObterTodos();
            return Ok(ret);
        }
    }
}