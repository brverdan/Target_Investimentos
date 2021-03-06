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
            _context.Usuarios.Add(entidade);
            await _context.SaveChangesAsync();
        }

        public async Task<Usuario> ObterUsuario(string cpf)
        {
            var usuario = await _context.Usuarios.Include(x => x.Endereco)
                                        .FirstOrDefaultAsync(u => u.Cpf == cpf);

            return usuario;
        }

        public async Task SalvarMudancas()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Usuario>> ListarUsuariosPorData(DateTime dataInicial, DateTime dataFinal)
        {
            var usuarios = await _context.Usuarios.Include(u => u.Endereco)
                                         .Where(u => u.DataCadastramento >= dataInicial && u.DataCadastramento <= dataFinal)
                                         .ToListAsync();

            return usuarios;
        }

        public async Task<IEnumerable<Usuario>> ListarUsuariosPorRenda(decimal rendaMensal)
        {
            var usuarios = await _context.Usuarios.Include(u => u.Endereco)
                                         .Where(u => u.RendaMensal >= rendaMensal)
                                         .ToListAsync();

            return usuarios;
        }

        public async Task<int> ObterTotalClientesAderidosPlanoVip()
        {
            var totalAderido = await _context.Usuarios.Where(u => u.RendaMensal >= 6000 && u.PlanoVip).CountAsync();

            return totalAderido;
        }

        public async Task<int> ObterTotalUsuariosSolicitantesPlanoVip()
        {
            var totalUsuarios = await _context.Usuarios.Where(u => u.RendaMensal >= 6000).ToListAsync();

            return totalUsuarios.Count;
        }
    }
}
