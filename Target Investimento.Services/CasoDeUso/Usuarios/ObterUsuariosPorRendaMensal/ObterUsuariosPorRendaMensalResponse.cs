namespace Target_Investimento.Services.CasoDeUso.Usuarios.ObterUsuariosPorRendaMensal
{
    public class ObterUsuariosPorRendaMensalResponse
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal RendaMensal { get; set; }
        public bool PlanoVip { get; set; }
        public ObterUsuariosPorRendaMensalEnderecoResponse Endereco { get; set; }
    }
}
