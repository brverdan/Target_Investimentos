namespace Target_Investimento.Services.CasoDeUso.Auxiliares.ObterCidades
{
    public interface IObterCidadesCasoDeUso
    {
        Task<IEnumerable<ObterCidadesResponse>> Executar(string uf);
    }
}
