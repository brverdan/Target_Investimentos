using Target_Investimento.Services.Extensoes;
using Target_Investimento.Services.Usuarios.CriarUsuario;

namespace Target_Investimento.CasoDeUso.Usuarios.CriarUsuario
{
    public partial class CriarUsuarioCasoDeUso
    {
        public List<string> ValidarDados(CriarUsuarioRequest request)
        {
            var listaErros = new List<string>();

            if(request.IsNull())
                listaErros.Add("Request obrigatório");

            if(request.Nome.IsNullOrEmpty())
                listaErros.Add("Nome obrigatório");

            if (request.Cpf.IsNullOrEmpty())
                listaErros.Add("Cpf obrigatório");

            if (!request.Cpf.CpfValido())
                listaErros.Add("Cpf inválido");

            if (request.DataNascimento.IsNull())
                listaErros.Add("Data de nascimento obrigatório");

            if (request.RendaMensal.IsNull())
                listaErros.Add("Renda mensal obrigatória");

            ValidarEndereco(request.Endereco, listaErros);

            return listaErros;
        }

        private void ValidarEndereco(CriarUsuarioEnderecoUsuarioRequest requestEndereco, List<string> listaErros)
        {
            if(requestEndereco.IsNull())
                listaErros.Add("Request de endereço obrigatório");

            if (requestEndereco.Logradouro.IsNullOrEmpty())
                listaErros.Add("Logradouro obrigatório");

            if (requestEndereco.Bairro.IsNullOrEmpty())
                listaErros.Add("Bairro obrigatório");

            if (requestEndereco.Cep.IsNullOrEmpty())
                listaErros.Add("Cep obrigatório");

            if (requestEndereco.Cidade.IsNullOrEmpty())
                listaErros.Add("Cidade obrigatória");

            if (requestEndereco.UF.IsNull())
                listaErros.Add("Uf obrigatório");
        }
    }
}
