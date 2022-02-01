using Microsoft.AspNetCore.Mvc;
using Target_Investimento.Services.CasoDeUso.Usuarios.CriarUsuario;
using Target_Investimento.Services.CasoDeUso.Usuarios.ObterUsuarios;

namespace Target_Investimento.Controllers
{
    [ApiController]
    [Route("usuarios")]
    [Produces("application/json")]
    public class UsuariosController : ControllerBase
    {
        private readonly ICriarUsuarioCasoDeUso _criarUsuarioCasoDeUso;
        private readonly IObterUsuariosPorDataCriacaoCasoDeUso _obterUsuariosPorDataCriacaoCasoDeUso;

        public UsuariosController(ICriarUsuarioCasoDeUso criarUsuarioCasoDeUso, 
                                  IObterUsuariosPorDataCriacaoCasoDeUso obterUsuariosPorDataCriacaoCasoDeUso)
        {
            _criarUsuarioCasoDeUso = criarUsuarioCasoDeUso;
            _obterUsuariosPorDataCriacaoCasoDeUso = obterUsuariosPorDataCriacaoCasoDeUso;
        }

        [HttpPost]
        public async Task<IActionResult> CriarUsuario([FromBody] CriarUsuarioRequest request)
        {
            return Created("", await _criarUsuarioCasoDeUso.Executar(request));
        }

        [HttpGet]
        public async Task<IActionResult> ObterUsuariosPorDataCriacao([FromQuery] DateTime dataInicial, [FromQuery] DateTime dataFinal)
        {
            return Ok(await _obterUsuariosPorDataCriacaoCasoDeUso.Executar(dataInicial, dataFinal));
        }
    }
}