namespace Target_Investimento.Services.ServicoExterno.Auxiliares.ObterCidades
{
    public interface IObterCidadesServicoExterno
    {
        Task<IEnumerable<ObterCidadesServicoExternoDto>> Executar(string uf);
    }
}
