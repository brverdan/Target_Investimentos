namespace Target_Investimento.Domain.Usuarios
{
    public class EnderecoUsuario
    {
        public Guid Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }
        public string Complemento { get; private set; }
        public Usuario Usuario { get; private set; }
        public Guid UsuarioId { get; private set; }
    }
}
