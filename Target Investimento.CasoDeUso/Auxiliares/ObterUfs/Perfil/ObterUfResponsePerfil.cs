using AutoMapper;
using Target_Investimento.Services.CasoDeUso.Auxiliares.ObterUfs;
using Target_Investimento.Services.ServicoExterno.Auxiliares.ObterUfs;

namespace Target_Investimento.CasoDeUso.Auxiliares.ObterUfs.Perfil
{
    public class ObterUfResponsePerfil : Profile
    {
        public ObterUfResponsePerfil()
        {
            CreateMap<ObterUfServicoExternoDto, ObterUfResponse>();
        }
    }
}
