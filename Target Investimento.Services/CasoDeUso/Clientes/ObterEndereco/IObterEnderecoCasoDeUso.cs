namespace Target_Investimento.Services.CasoDeUso.Clientes.ObterEndereco
{
    public interface IObterEnderecoCasoDeUso
    {
        Task<ObterEnderecoResponse> Executar(Guid usuarioId);
    }
}
