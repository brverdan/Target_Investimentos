using Microsoft.EntityFrameworkCore;
using Target_Investimento.Domain.Usuarios;
using Target_Investimento.Repository.Context;
using Target_Investimento.Services.Repositorio.Usuarios;

namespace Target_Investimento.Repository.Usuarios
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        private readonly TargetContext _context;

        public EnderecoRepositorio(TargetContext context) => _context = context;

        public async Task<EnderecoUsuario> ObterEndereco(Guid id)
        {
            var endereco = await _context.EnderecoUsuario.FirstOrDefaultAsync(e => e.UsuarioId == id);

            return endereco;
        }

        public async Task AlterarEndereco(EnderecoUsuario endereco)
        {
            _context.EnderecoUsuario.Update(endereco);
            await _context.SaveChangesAsync();
        }
    }
}
