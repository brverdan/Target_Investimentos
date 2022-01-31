using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Target_Investimento.IoC
{
    public static class InjecaoDependencia
    {
        public static void AddMyDependencies(this IServiceCollection servicos)
        {
            #region Casos de uso
            servicos.Scan(scan => scan.FromApplicationDependencies()
                                      .AddClasses(c => c.Where(x => x.Name.EndsWith("CasoDeUso")))
                                      .AsImplementedInterfaces()
                                      .WithScopedLifetime());
            #endregion

            #region Repositórios

            #endregion
        }
    }
}