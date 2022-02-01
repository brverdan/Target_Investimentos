namespace Target_Investimento.Services.CasoDeUso.Usuarios.ObterUsuarios
{
    public interface IObterUsuariosPorDataCriacaoCasoDeUso
    {
        Task<IEnumerable<ObterUsuariosPorDataCriacaoResponse>> Executar(DateTime dataInicio, DateTime dataFinal);
    }
}
