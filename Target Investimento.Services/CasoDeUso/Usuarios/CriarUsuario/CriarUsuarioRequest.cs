namespace Target_Investimento.Services.CasoDeUso.Usuarios.CriarUsuario
{
    public class CriarUsuarioRequest
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal RendaMensal { get; set; }
        public DateTime DataCadastramento{ get; set; }
        public CriarUsuarioEnderecoUsuarioRequest Endereco { get; set; }
    }
}
