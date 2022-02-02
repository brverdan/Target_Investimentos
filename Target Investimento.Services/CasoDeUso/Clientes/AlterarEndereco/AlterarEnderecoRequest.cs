namespace Target_Investimento.Services.CasoDeUso.Clientes.AlterarEndereco
{
    public class AlterarEnderecoRequest
    {
        public string? Logradouro { get; set; }
        public string? Bairro { get; set; }
        public string? Cep { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
        public string? Complemento { get; set; }
    }
}
