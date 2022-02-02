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


        public void AlterarDados(string logradouro, string bairro, string cep, string cidade, string uf, string complemento)
        {
            Logradouro = string.IsNullOrEmpty(logradouro) ? Logradouro : logradouro;
            Bairro = string.IsNullOrEmpty(bairro) ? Bairro : bairro; ;
            Cep = string.IsNullOrEmpty(cep) ? Cep : cep; ;
            Cidade = string.IsNullOrEmpty(cidade) ? Cidade : cidade; ;
            UF = string.IsNullOrEmpty(uf) ? UF : uf; ;
            Complemento = string.IsNullOrEmpty(complemento) ? Complemento : complemento; ;
        }
    }
}
