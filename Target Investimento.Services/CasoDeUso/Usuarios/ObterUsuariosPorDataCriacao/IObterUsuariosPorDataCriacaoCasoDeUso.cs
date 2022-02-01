namespace Target_Investimento.Services.CasoDeUso.Usuarios.ObterUsuariosPorDataCriacao
{
    public interface IObterUsuariosPorDataCriacaoCasoDeUso
    {
        Task<IEnumerable<ObterUsuariosPorDataCriacaoResponse>> Executar(DateTime dataInicio, DateTime dataFinal);
    }
}
