using AutoMapper;
using Target_Investimento.Services.CasoDeUso.Auxiliares.ObterUfs;
using Target_Investimento.Services.ServicoExterno.Auxiliares.ObterUfs;

namespace Target_Investimento.CasoDeUso.Auxiliares.ObterUfs
{
    public class ObterUfCasoDeUso : IObterUfCasoDeUso
    {
        private readonly IObterUfServicoExterno _obterUfServicoExterno;
        private readonly IMapper _mapper;

        public ObterUfCasoDeUso(IObterUfServicoExterno obterUfServicoExterno, IMapper mapper)
        {
            _obterUfServicoExterno = obterUfServicoExterno;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ObterUfResponse>> Executar()
        {
            var retornoServicoExterno = await _obterUfServicoExterno.ExecutarAsync();

            return _mapper.Map<IEnumerable<ObterUfResponse>>(retornoServicoExterno);
        }
    }
}
