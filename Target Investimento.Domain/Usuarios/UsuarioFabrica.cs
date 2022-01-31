namespace Target_Investimento.Domain.Usuarios
{
    public partial class Usuario
    {
        public static Usuario Criar(string nome, string cpf, DateTime dataNascimento, decimal rendaMensal) => new Usuario
        {
            Nome = nome,
            Cpf = cpf,
            DataNascimento = dataNascimento,
            RendaMensal = rendaMensal
        };
    }
}
