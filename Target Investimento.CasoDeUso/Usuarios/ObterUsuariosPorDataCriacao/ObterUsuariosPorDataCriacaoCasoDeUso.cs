using AutoMapper;
using Target_Investimento.Services.CasoDeUso.Usuarios.ObterUsuariosPorDataCriacao;
using Target_Investimento.Services.Extensoes;
using Target_Investimento.Services.Repositorio.Usuarios;

namespace Target_Investimento.CasoDeUso.Usuarios.ObterUsuariosPorDataCriacao
{
    public class ObterUsuariosPorDataCriacaoCasoDeUso : IObterUsuariosPorDataCriacaoCasoDeUso
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IMapper _mapper;

        public ObterUsuariosPorDataCriacaoCasoDeUso(IUsuarioRepositorio usuarioRepositorio, IMapper mapper)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ObterUsuariosPorDataCriacaoResponse>> Executar(DateTime dataInicio, DateTime dataFinal)
        {
            if (dataInicio.IsNull())
                throw new Exception("Data de início obrigatória");

            if(dataFinal.IsNull())
                throw new Exception("Data final obrigatória");

            if (dataFinal < dataInicio)
                throw new Exception("A data inicial não pode ser maior que a final");

            var usuarios = await _usuarioRepositorio.ListarUsuariosPorData(dataInicio, dataFinal);

            return _mapper.Map<IEnumerable<ObterUsuariosPorDataCriacaoResponse>>(usuarios);
        }
    }
}
