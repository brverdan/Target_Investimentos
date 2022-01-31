namespace Target_Investimento.Domain.Usuarios
{
    public class Usuario
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public decimal RendaMensal { get; private set; }
        public EnderecoUsuario Endereco { get; private set; }

        public void AssociarEndereco(EnderecoUsuario endereco)
        {
            Endereco = endereco;
        }
    }
}