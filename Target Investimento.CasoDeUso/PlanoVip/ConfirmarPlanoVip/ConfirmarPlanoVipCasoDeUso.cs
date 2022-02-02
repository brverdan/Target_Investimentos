using Target_Investimento.Services.CasoDeUso.PlanoVip.ConfirmarPlanoVip;
using Target_Investimento.Services.Extensoes;
using Target_Investimento.Services.Repositorio.Usuarios;

namespace Target_Investimento.CasoDeUso.PlanoVip.ConfirmarPlanoVip
{
    public class ConfirmarPlanoVipCasoDeUso : IConfirmarPlanoVipCasoDeUso
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public ConfirmarPlanoVipCasoDeUso(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<ConfirmarPlanoVipResponse> Executar(ConfirmarPlanoVipRequest request, string cpf)
        {
            if (cpf.IsNullOrEmpty())
                throw new Exception("Cpf obrigatório");

            if (!cpf.CpfValido())
                throw new Exception("Cpf inválido");

            var usuario = await _usuarioRepositorio.ObterUsuario(cpf);

            if (usuario.IsNull())
                throw new Exception("Usuário não encontrado");

            if (request.Confirmacao)
            {
                usuario.ConfirmarPlanoVip(usuario.RendaMensal);
                await _usuarioRepositorio.SalvarMudancas();
            }
            else
            {
                return new ConfirmarPlanoVipResponse { Confimado = false };
            }

            return new ConfirmarPlanoVipResponse { Confimado = true };
        }
    }
}
