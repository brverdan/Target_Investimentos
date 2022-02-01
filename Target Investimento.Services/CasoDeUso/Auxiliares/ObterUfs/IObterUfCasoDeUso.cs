namespace Target_Investimento.Services.CasoDeUso.Auxiliares.ObterUfs
{
    public interface IObterUfCasoDeUso
    {
        Task<IEnumerable<ObterUfResponse>> Executar();
    }
}
