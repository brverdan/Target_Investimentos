using Microsoft.EntityFrameworkCore;
using Target_Investimento.Domain.Usuarios;
using Target_Investimento.Repository.Context;
using Target_Investimento.Services.Repositorio.Usuarios;

namespace Target_Investimento.Repository.Usuarios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly TargetContext _context;

        public UsuarioRepositorio(TargetContext context) => _context = context;

        public async Task AdicionarUsuario(Usuario entidade)
        {
            _context.Add(entidade);
            await _context.SaveChangesAsync();
        }

        public async Task<Usuario> ObterUsuario(string cpf)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Cpf == cpf);

            return usuario;
        }

        public async Task SalvarMudancas()
        {
            await _context.SaveChangesAsync();
        }
    }
}
