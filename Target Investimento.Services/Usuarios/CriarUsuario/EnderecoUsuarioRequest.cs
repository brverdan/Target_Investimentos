namespace Target_Investimento.Services.Usuarios.CriarUsuario
{
    public class EnderecoUsuarioRequest
    {
        public string Logradouro { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }
        public string Complemento { get; private set; }
    }
}
