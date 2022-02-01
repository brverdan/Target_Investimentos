using AutoMapper;
using Target_Investimento.Services.CasoDeUso.Usuarios.ObterUsuariosPorRendaMensal;
using Target_Investimento.Services.Extensoes;
using Target_Investimento.Services.Repositorio.Usuarios;

namespace Target_Investimento.CasoDeUso.Usuarios.ObterUsuariosPorRendaMensal
{
    public class ObterUsuariosPorRendaMensalCasoDeUso : IObterUsuariosPorRendaMensalCasoDeUso
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IMapper _mapper;

        public ObterUsuariosPorRendaMensalCasoDeUso(IUsuarioRepositorio usuarioRepositorio, 
                                                    IMapper mapper)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ObterUsuariosPorRendaMensalResponse>> Executar(decimal rendaMensal)
        {
            if (rendaMensal.IsNull())
                throw new Exception("Renda mensal obrigatória");

            var usuarios = await _usuarioRepositorio.ListarUsuariosPorRenda(rendaMensal);

            return _mapper.Map<IEnumerable<ObterUsuariosPorRendaMensalResponse>>(usuarios);
        }
    }
}
