namespace Target_Investimento.Services.CasoDeUso.Clientes.AlterarEndereco
{
    public interface IAlterarEnderecoCasoDeUso
    {
        Task<AlterarEnderecoResponse> Executar(Guid clienteId, AlterarEnderecoRequest request);
    }
}
