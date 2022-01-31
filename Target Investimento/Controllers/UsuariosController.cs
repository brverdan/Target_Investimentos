using Microsoft.AspNetCore.Mvc;
using Target_Investimento.Services.Usuarios.CriarUsuario;

namespace Target_Investimento.Controllers
{
    [ApiController]
    [Route("usuarios")]
    [Produces("application/json")]
    public class UsuariosController : ControllerBase
    {
        private readonly ICriarUsuarioCasoDeUso _criarUsuarioCasoDeUso;

        public UsuariosController(ICriarUsuarioCasoDeUso criarUsuarioCasoDeUso)
        {
            _criarUsuarioCasoDeUso = criarUsuarioCasoDeUso;
        }

        [HttpPost]
        public async Task<IActionResult> CriarUsuario(CriarUsuarioRequest request)
        {
            return Created("", await _criarUsuarioCasoDeUso.Executar(request));
        }
    }
}
