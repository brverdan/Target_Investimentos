using Microsoft.AspNetCore.Mvc;
using Target_Investimento.Services.CasoDeUso.Analista.ObterAdesao;

namespace Target_Investimento.Controllers
{
    [ApiController]
    [Route("analista")]
    [Produces("application/json")]
    public class AnalistaController : ControllerBase
    {
        private readonly IObterAdesaoCasoDeUso _obterAdesaoCasoDeUso;

        public AnalistaController(IObterAdesaoCasoDeUso obterAdesaoCasoDeUso)
        {
            _obterAdesaoCasoDeUso = obterAdesaoCasoDeUso;
        }

        public async Task<IActionResult> ObterAdesao()
        {
            return Ok(await _obterAdesaoCasoDeUso.Executar());
        }
    }
}
