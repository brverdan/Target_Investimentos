using Newtonsoft.Json;
using Target_Investimento.Services.ServicoExterno.Auxiliares.ObterUfs;

namespace Target_Investimento.ServicoExterno.Auxiliares.ObterUfs
{
    public class ObterUfServicoExterno : IObterUfServicoExterno
    {
        private readonly HttpClient _httpClient;

        public ObterUfServicoExterno(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ObterUfServicoExternoDto>> ExecutarAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://servicodados.ibge.gov.br/api/v1/localidades/estados?orderBy=nome");

            var response = await _httpClient.SendAsync(request);

            var conteudo = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<ObterUfServicoExternoDto>>(conteudo);

            return result;
        }
    }
}
