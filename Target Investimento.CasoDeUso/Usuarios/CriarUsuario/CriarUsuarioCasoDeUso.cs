using AutoMapper;
using Target_Investimento.Domain.Usuarios;
using Target_Investimento.Services.CasoDeUso.Usuarios.CriarUsuario;
using Target_Investimento.Services.Extensoes;
using Target_Investimento.Services.Repositorio.Usuarios;
using Target_Investimento.Services.ServicoExterno.Auxiliares.ObterUfs;

namespace Target_Investimento.CasoDeUso.Usuarios.CriarUsuario
{
    public partial class CriarUsuarioCasoDeUso : ICriarUsuarioCasoDeUso
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IMapper _mapper;
        private readonly IObterUfServicoExterno _obterUfServicoExterno;

        public CriarUsuarioCasoDeUso(IUsuarioRepositorio usuarioRepositorio,
                                     IMapper mapper,
                                     IObterUfServicoExterno obterUfServicoExterno)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _mapper = mapper;
            _obterUfServicoExterno = obterUfServicoExterno;
        }

        public async Task<CriarUsuarioResponse> Executar(CriarUsuarioRequest request)
        {
            var listaErros = ValidarDados(request);

            if (!listaErros.IsNullOrEmpty())
                throw new Exception(string.Join(';', listaErros));

            var ufs = await _obterUfServicoExterno.ExecutarAsync();

            var usuario = _mapper.Map<Usuario>(request);

            await _usuarioRepositorio.AdicionarUsuario(usuario);

            var oferecePlanoVip = request.RendaMensal > 6000;

            return new CriarUsuarioResponse { Cadastrado = true, OferecerPlanoVip = oferecePlanoVip};
        }
    }
}
