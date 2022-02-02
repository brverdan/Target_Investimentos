using AutoMapper;
using Target_Investimento.Services.CasoDeUso.Clientes.ObterEndereco;
using Target_Investimento.Services.Extensoes;
using Target_Investimento.Services.Repositorio.Usuarios;

namespace Target_Investimento.CasoDeUso.Clientes.ObterEndereco
{
    public class ObterEnderecoCasoDeUso : IObterEnderecoCasoDeUso
    {
        private readonly IEnderecoRepositorio _enderecoRepositorio;
        private readonly IMapper _mapper;

        public ObterEnderecoCasoDeUso(IEnderecoRepositorio enderecoRepositorio, IMapper mapper)
        {
            _enderecoRepositorio = enderecoRepositorio;
            _mapper = mapper;
        }

        public async Task<ObterEnderecoResponse> Executar(Guid clienteId)
        {
            if (clienteId.IsNull())
                throw new Exception("Id do cliente obrigatório");

            var endereco = await _enderecoRepositorio.ObterEndereco(clienteId);

            if (endereco.IsNull())
                throw new Exception("Endereço não encontrado");

            return _mapper.Map<ObterEnderecoResponse>(endereco);
        }
    }
}
