using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target_Investimento.Services.CasoDeUso.Usuarios.ObterUsuariosPorRendaMensal
{
    public interface IObterUsuariosPorRendaMensalCasoDeUso
    {
        Task<IEnumerable<ObterUsuariosPorRendaMensalResponse>> Executar(decimal rendaMensal);
    }
}
