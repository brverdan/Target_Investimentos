namespace Target_Investimento.Services.CasoDeUso.Usuarios.ObterUsuariosPorDataCriacao
{
    public class ObterUsuariosPorDataCriacaoResponse
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal RendaMensal { get; set; }
        public bool PlanoVip { get; set; }
        public ObterUsuariosPorDataCriacaoEnderecoResponse Endereco { get; set; }
    }
}
