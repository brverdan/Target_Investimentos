using Microsoft.AspNetCore.Mvc;
using Target_Investimento.Services.CasoDeUso.PlanoVip.ConfirmarPlanoVip;
using Target_Investimento.Services.CasoDeUso.PlanoVip.ObterPlanoVip;

namespace Target_Investimento.Controllers
{
    [ApiController]
    [Route("planoVip")]
    [Produces("application/json")]
    public class PlanoVipController : ControllerBase
    {
        private readonly IObterPlanoVipCasoDeUso _obterPlanoVipCasoDeUso;
        private readonly IConfirmarPlanoVipCasoDeUso _confirmarPlanoVipCasoDeUso;

        public PlanoVipController(IObterPlanoVipCasoDeUso obterPlanoVipCasoDeUso, 
                                  IConfirmarPlanoVipCasoDeUso confirmarPlanoVipCasoDeUso)
        {
            _obterPlanoVipCasoDeUso = obterPlanoVipCasoDeUso;
            _confirmarPlanoVipCasoDeUso = confirmarPlanoVipCasoDeUso;
        }

        [HttpGet]
        public async Task<IActionResult> ObterPlanoVip()
        {
            return Ok(await _obterPlanoVipCasoDeUso.Executar());
        }

        [HttpPost("{cpf}")]
        public async Task<IActionResult> ConfirmarPlanoVip([FromBody] ConfirmarPlanoVipRequest request, [FromRoute] string cpf)
        {
            return Ok(await _confirmarPlanoVipCasoDeUso.Executar(request, cpf));
        }
    }
}
