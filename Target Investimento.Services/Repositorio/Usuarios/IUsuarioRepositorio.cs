using Target_Investimento.Domain.Usuarios;

namespace Target_Investimento.Services.Repositorio.Usuarios
{
    public interface IUsuarioRepositorio
    {
        Task AdicionarUsuario(Usuario entidade);
        Task<Usuario> ObterUsuario(string cpf);
        Task SalvarMudancas();
        Task<IEnumerable<Usuario>> ListarUsuariosPorData(DateTime dataInicial, DateTime dataFinal);
        Task<IEnumerable<Usuario>> ListarUsuariosPorRenda(decimal rendaMensal);
        Task<int> ObterTotalClientesAderidosPlanoVip();

        Task<int> ObterTotalUsuarios();
    }
}