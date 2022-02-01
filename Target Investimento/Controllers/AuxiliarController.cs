using Microsoft.AspNetCore.Mvc;
using Target_Investimento.Services.CasoDeUso.Auxiliares.ObterCidades;
using Target_Investimento.Services.CasoDeUso.Auxiliares.ObterUfs;

namespace Target_Investimento.Controllers
{
    [ApiController]
    [Route("auxiliares")]
    [Produces("application/json")]
    public class AuxiliarController : ControllerBase
    {
        private readonly IObterUfCasoDeUso _obterUfCasoDeUso;
        private readonly IObterCidadesCasoDeUso _obterCidadesCasoDeUso;

        public AuxiliarController(IObterUfCasoDeUso obterUfCasoDeUso, 
                                  IObterCidadesCasoDeUso obterCidadesCasoDeUso)
        {
            _obterUfCasoDeUso = obterUfCasoDeUso;
            _obterCidadesCasoDeUso = obterCidadesCasoDeUso;
        }

        [HttpGet("ufs")]
        public async Task<IActionResult> ObterUfs()
        {
            return Ok(await _obterUfCasoDeUso.Executar());
        }

        [HttpGet("cidades/{uf}")]
        public async Task<IActionResult> ObterCidades([FromRoute] string uf)
        {
            return Ok(await _obterCidadesCasoDeUso.Executar(uf));
        }
    }
}
