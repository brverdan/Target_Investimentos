using Target_Investimento.Services.CasoDeUso.Clientes.AlterarEndereco;
using Target_Investimento.Services.Extensoes;

namespace Target_Investimento.CasoDeUso.Clientes.AlterarEndereco
{
    public partial class AlterarEnderecoCasoDeUso
    {
        public void ValidarDados(Guid clienteId, AlterarEnderecoRequest request)
        {
            if (clienteId.IsNull())
                throw new Exception("Cliente id obrigatório");

            if (request.IsNull())
                throw new Exception("Request obrigatório");
        }
    }
}
