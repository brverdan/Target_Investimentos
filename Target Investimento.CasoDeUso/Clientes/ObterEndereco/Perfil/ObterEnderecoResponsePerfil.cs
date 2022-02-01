using AutoMapper;
using Target_Investimento.Domain.Usuarios;
using Target_Investimento.Services.CasoDeUso.Clientes.ObterEndereco;

namespace Target_Investimento.CasoDeUso.Clientes.ObterEndereco.Perfil
{
    public class ObterEnderecoResponsePerfil : Profile
    {
        public ObterEnderecoResponsePerfil()
        {
            CreateMap<EnderecoUsuario, ObterEnderecoResponse>();
        }
    }
}
