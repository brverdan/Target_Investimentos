using AutoMapper;
using Target_Investimento.Domain.Usuarios;
using Target_Investimento.Services.CasoDeUso.Usuarios.ObterUsuariosPorRendaMensal;

namespace Target_Investimento.CasoDeUso.Usuarios.ObterUsuariosPorRendaMensal.Perfil
{
    public class ObterUsuariosPorRendaMensalResponsePerfil : Profile
    {
        public ObterUsuariosPorRendaMensalResponsePerfil()
        {
            CreateMap<Usuario, ObterUsuariosPorRendaMensalResponse>();
            CreateMap<EnderecoUsuario, ObterUsuariosPorRendaMensalEnderecoResponse>();
        }
    }
}
