using Target_Investimento.Services.CasoDeUso.Clientes.AlterarEndereco;
using Target_Investimento.Services.Repositorio.Usuarios;

namespace Target_Investimento.CasoDeUso.Clientes.AlterarEndereco
{
    public partial class AlterarEnderecoCasoDeUso : IAlterarEnderecoCasoDeUso
    {
        private readonly IEnderecoRepositorio _enderecoRepositorio;

        public AlterarEnderecoCasoDeUso(IEnderecoRepositorio enderecoRepositorio)
        {
            _enderecoRepositorio = enderecoRepositorio;
        }

        public async Task<AlterarEnderecoResponse> Executar(Guid clienteId, AlterarEnderecoRequest request)
        {
            ValidarDados(clienteId, request);

            var endereco = await _enderecoRepositorio.ObterEndereco(clienteId);

            endereco.AlterarDados(request.Logradouro, request.Bairro, request.Cep, request.Cidade, request.UF, request.Complemento);

            await _enderecoRepositorio.AlterarEndereco(endereco);

            return new AlterarEnderecoResponse { Mensagem = "Endereço alterado com sucesso" };
        }
    }
}
