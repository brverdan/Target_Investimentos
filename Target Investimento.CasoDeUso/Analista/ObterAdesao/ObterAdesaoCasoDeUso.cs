using Target_Investimento.Services.CasoDeUso.Analista.ObterAdesao;
using Target_Investimento.Services.Repositorio.Usuarios;

namespace Target_Investimento.CasoDeUso.Analista.ObterAdesao
{
    public class ObterAdesaoCasoDeUso : IObterAdesaoCasoDeUso
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public ObterAdesaoCasoDeUso(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<ObterAdesaoResponse> Executar()
        {
            var totalAderido = await _usuarioRepositorio.ObterTotalClientesAderidosPlanoVip();

            var totalUsuarios = await _usuarioRepositorio.ObterTotalUsuariosSolicitantesPlanoVip();

            var percentual = (totalAderido / (decimal)totalUsuarios) * 100;

            return new ObterAdesaoResponse { TotalAderido = totalAderido, PercentualTotal = percentual };
        }
    }
}
