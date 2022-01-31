namespace Target_Investimento.Services.Usuarios.CriarUsuario
{
    public class CriarUsuarioRequest
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal RendaMensal { get; set; }
        public EnderecoUsuarioRequest Endereco { get; set; }
    }
}
