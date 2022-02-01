using Microsoft.AspNetCore.Mvc;
using Target_Investimento.Services.CasoDeUso.Usuarios.CriarUsuario;
using Target_Investimento.Services.CasoDeUso.Usuarios.ObterUsuariosPorDataCriacao;
using Target_Investimento.Services.CasoDeUso.Usuarios.ObterUsuariosPorRendaMensal;

namespace Target_Investimento.Controllers
{
    [ApiController]
    [Route("usuarios")]
    [Produces("application/json")]
    public class UsuariosController : ControllerBase
    {
        private readonly ICriarUsuarioCasoDeUso _criarUsuarioCasoDeUso;
        private readonly IObterUsuariosPorDataCriacaoCasoDeUso _obterUsuariosPorDataCriacaoCasoDeUso;
        private readonly IObterUsuariosPorRendaMensalCasoDeUso _obterUsuariosPorRendaMensalCasoDeUso;

        public UsuariosController(ICriarUsuarioCasoDeUso criarUsuarioCasoDeUso, 
                                  IObterUsuariosPorDataCriacaoCasoDeUso obterUsuariosPorDataCriacaoCasoDeUso,
                                  IObterUsuariosPorRendaMensalCasoDeUso obterUsuariosPorRendaMensalCasoDeUso)
        {
            _criarUsuarioCasoDeUso = criarUsuarioCasoDeUso;
            _obterUsuariosPorDataCriacaoCasoDeUso = obterUsuariosPorDataCriacaoCasoDeUso;
            _obterUsuariosPorRendaMensalCasoDeUso = obterUsuariosPorRendaMensalCasoDeUso;
        }

        [HttpPost]
        public async Task<IActionResult> CriarUsuario([FromBody] CriarUsuarioRequest request)
        {
            return Created("", await _criarUsuarioCasoDeUso.Executar(request));
        }

        [HttpGet("dataCadastramento")]
        public async Task<IActionResult> ObterUsuariosPorDataCriacao([FromQuery] DateTime dataInicial, [FromQuery] DateTime dataFinal)
        {
            return Ok(await _obterUsuariosPorDataCriacaoCasoDeUso.Executar(dataInicial, dataFinal));
        }

        [HttpGet("rendaMensal")]
        public async Task<IActionResult> ObterUsuariosPorRendaMensal([FromQuery] decimal rendaMensal)
        {
            return Ok(await _obterUsuariosPorRendaMensalCasoDeUso.Executar(rendaMensal));
        }
    }
}