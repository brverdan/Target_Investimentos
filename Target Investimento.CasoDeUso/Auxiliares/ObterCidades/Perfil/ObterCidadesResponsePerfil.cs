using AutoMapper;
using Target_Investimento.Services.CasoDeUso.Auxiliares.ObterCidades;
using Target_Investimento.Services.ServicoExterno.Auxiliares.ObterCidades;

namespace Target_Investimento.CasoDeUso.Auxiliares.ObterCidades.Perfil
{
    public class ObterCidadesResponsePerfil : Profile
    {
        public ObterCidadesResponsePerfil()
        {
            CreateMap<ObterCidadesServicoExternoDto, ObterCidadesResponse>();
        }
    }
}
