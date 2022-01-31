using Microsoft.EntityFrameworkCore;
using Target_Investimento.Domain.Usuarios;

namespace Target_Investimento.Repository.Context
{
    public class TargetContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public TargetContext(DbContextOptions<TargetContext> options) : base(options)
        { }
    }
}
