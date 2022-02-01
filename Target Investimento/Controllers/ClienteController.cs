using Microsoft.AspNetCore.Mvc;
using Target_Investimento.Services.CasoDeUso.Clientes.ObterEndereco;

namespace Target_Investimento.Controllers
{
    [ApiController]
    [Route("clientes")]
    [Produces("application/json")]
    public class ClienteController : ControllerBase
    {
        private readonly IObterEnderecoCasoDeUso _obterEnderecoCasoDeUso;

        public ClienteController(IObterEnderecoCasoDeUso obterEnderecoCasoDeUso)
        {
            _obterEnderecoCasoDeUso = obterEnderecoCasoDeUso;
        }

        [HttpGet("{clienteId}")]
        public async Task<IActionResult> ObterEndereco([FromRoute] Guid clienteId)
        {
            return Ok(await _obterEnderecoCasoDeUso.Executar(clienteId));
        }
    }
}
