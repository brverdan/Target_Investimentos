using AutoMapper;
using Target_Investimento.Domain.Usuarios;
using Target_Investimento.Services.Usuarios.CriarUsuario;

namespace Target_Investimento.CasoDeUso.Usuarios.CriarUsuario.Perfil
{
    public class CriarUsuarioRequestPerfil : Profile
    {
        public CriarUsuarioRequestPerfil()
        {
            CreateMap<CriarUsuarioRequest, Usuario>();
            CreateMap<CriarUsuarioEnderecoUsuarioRequest, EnderecoUsuario>();
        }
    }
}
