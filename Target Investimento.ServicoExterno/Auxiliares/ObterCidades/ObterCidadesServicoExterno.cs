using Newtonsoft.Json;
using Target_Investimento.Services.ServicoExterno.Auxiliares.ObterCidades;

namespace Target_Investimento.ServicoExterno.Auxiliares.ObterCidades
{
    public class ObterCidadesServicoExterno : IObterCidadesServicoExterno
    {
        private readonly HttpClient _httpClient;

        public ObterCidadesServicoExterno(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ObterCidadesServicoExternoDto>> Executar(string uf)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://servicodados.ibge.gov.br/api/v1/localidades/estados/{uf}/distritos");

            var response = await _httpClient.SendAsync(request);

            var conteudo = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<ObterCidadesServicoExternoDto>>(conteudo);

            return result;
        }
    }
}
