using Target_Investimento.Services.CasoDeUso.PlanoVip.ObterPlanoVip;

namespace Target_Investimento.CasoDeUso.PlanoVip.ObterPlanoVip
{
    public partial class ObterPlanoVipCasoDeUso : IObterPlanoVipCasoDeUso
    {
        public Task<ObterPlanoVipResponse> Executar()
        {
            var descricao = CriarDescricao();

            var retorno = new ObterPlanoVipResponse { Preco = 50, Descricao = descricao };

            return Task.FromResult(retorno);
        }
    }
}
