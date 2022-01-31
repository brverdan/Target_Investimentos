using AutoMapper;
using Target_Investimento.Domain.Usuarios;
using Target_Investimento.Services.Extensoes;
using Target_Investimento.Services.Repositorio.Usuarios;
using Target_Investimento.Services.Usuarios.CriarUsuario;

namespace Target_Investimento.CasoDeUso.Usuarios.CriarUsuario
{
    public partial class CriarUsuarioCasoDeUso : ICriarUsuarioCasoDeUso
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IMapper _mapper;

        public CriarUsuarioCasoDeUso(IUsuarioRepositorio usuarioRepositorio,
                                     IMapper mapper)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _mapper = mapper;
        }

        public async Task<CriarUsuarioResponse> Executar(CriarUsuarioRequest request)
        {
            var listaErros = ValidarDados(request);

            if (!listaErros.IsNullOrEmpty())
                throw new Exception(string.Join(';', listaErros));

            var usuario = _mapper.Map<Usuario>(request);

            await _usuarioRepositorio.AdicionarUsuario(usuario);

            var oferecePlanoVip = request.RendaMensal > 6000;

            return new CriarUsuarioResponse { Cadastrado = true, OferecerPlanoVip = oferecePlanoVip};
        }
    }
}
