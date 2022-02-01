namespace Target_Investimento.Services.CasoDeUso.PlanoVip.ConfirmarPlanoVip
{
    public interface IConfirmarPlanoVipCasoDeUso
    {
        Task<ConfirmarPlanoVipResponse> Executar(ConfirmarPlanoVipRequest request, string cpf);
    }
}
