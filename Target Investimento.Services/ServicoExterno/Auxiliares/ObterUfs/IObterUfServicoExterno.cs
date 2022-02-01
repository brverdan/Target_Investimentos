namespace Target_Investimento.Services.ServicoExterno.Auxiliares.ObterUfs
{
    public interface IObterUfServicoExterno
    {
        Task<IEnumerable<ObterUfServicoExternoDto>> ExecutarAsync();
    }
}
