using Target_Investimento.Domain.Usuarios;

namespace Target_Investimento.Services.Repositorio.Usuarios
{
    public interface IEnderecoRepositorio
    {
        Task<EnderecoUsuario> ObterEndereco(Guid clienteId);
        Task AlterarEndereco(EnderecoUsuario endereco);
    }
}
