using AutoMapper;
using Target_Investimento.Domain.Usuarios;
using Target_Investimento.Services.CasoDeUso.Usuarios.ObterUsuarios;

namespace Target_Investimento.CasoDeUso.Usuarios.ObterUsuarios.Perfil
{
    public class ObterUsuariosResponsePerfil : Profile
    {
        public ObterUsuariosResponsePerfil()
        {
            CreateMap<Usuario, ObterUsuariosPorDataCriacaoResponse>();
            CreateMap<EnderecoUsuario, ObterUsuariosPorDataCriacaoEnderecoResponse>();
        }
    }
}
