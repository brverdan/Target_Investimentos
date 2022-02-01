using AutoMapper;
using Target_Investimento.Services.CasoDeUso.Auxiliares.ObterCidades;
using Target_Investimento.Services.Extensoes;
using Target_Investimento.Services.ServicoExterno.Auxiliares.ObterCidades;

namespace Target_Investimento.CasoDeUso.Auxiliares.ObterCidades
{
    public class ObterCidadesCasoDeUso : IObterCidadesCasoDeUso
    {
        private readonly IObterCidadesServicoExterno _obterCidadesServicoExterno;
        private readonly IMapper _mapper;

        public ObterCidadesCasoDeUso(IObterCidadesServicoExterno obterCidadesServicoExterno, IMapper mapper)
        {
            _obterCidadesServicoExterno = obterCidadesServicoExterno;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ObterCidadesResponse>> Executar(string uf)
        {
            if (uf.IsNullOrEmpty())
                throw new Exception("Uf obrigatória");

            var retornoServicoExterno = await _obterCidadesServicoExterno.Executar(uf);

            return _mapper.Map<IEnumerable<ObterCidadesResponse>>(retornoServicoExterno);
        }
    }
}
