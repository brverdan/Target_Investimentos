using Microsoft.AspNetCore.Mvc;
using Target_Investimento.Services.CasoDeUso.Clientes.AlterarEndereco;
using Target_Investimento.Services.CasoDeUso.Clientes.ObterEndereco;

namespace Target_Investimento.Controllers
{
    [ApiController]
    [Route("clientes")]
    [Produces("application/json")]
    public class ClienteController : ControllerBase
    {
        private readonly IObterEnderecoCasoDeUso _obterEnderecoCasoDeUso;
        private readonly IAlterarEnderecoCasoDeUso _alterarEnderecoCasoDeUso;

        public ClienteController(IObterEnderecoCasoDeUso obterEnderecoCasoDeUso, 
                                 IAlterarEnderecoCasoDeUso alterarEnderecoCasoDeUso)
        {
            _obterEnderecoCasoDeUso = obterEnderecoCasoDeUso;
            _alterarEnderecoCasoDeUso = alterarEnderecoCasoDeUso;
        }

        [HttpGet("{clienteId}")]
        public async Task<IActionResult> ObterEndereco([FromRoute] Guid clienteId)
        {
            return Ok(await _obterEnderecoCasoDeUso.Executar(clienteId));
        }

        [HttpPut("{clienteId}")]
        public async Task<IActionResult> AlterarEndereco([FromRoute] Guid clienteId, [FromBody] AlterarEnderecoRequest request)
        {
            return Ok(await _alterarEnderecoCasoDeUso.Executar(clienteId, request));
        }
    }
}
