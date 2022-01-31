namespace Target_Investimento.Services.Extensoes
{
    public static class CpfExtensao
    {
        public static bool CpfValido(this string cpf)
        {
            if (cpf.IsNullOrEmpty())
            {
                return false;
            }

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = RemoverCaracteresEspeciaisCpf(cpf);

            if (cpf.ToCharArray().All(c => c == cpf[0]))
                return false;

            if (cpf.Length != 11)
                return false;

            if (!long.TryParse(cpf, out long x))
                return false;

            var cpfTemp = cpf.Substring(0, 9);

            var soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpfTemp[i].ToString()) * multiplicador1[i];

            var resto = soma % 11;
            resto = CalcularResto(resto);

            var digito = resto.ToString();
            cpfTemp = cpfTemp + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpfTemp[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            resto = CalcularResto(resto);

            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }
        private static string RemoverCaracteresEspeciaisCpf(string cpf) =>
            cpf.Trim().Replace("-", "").Replace(".", "");

        private static int CalcularResto(int resto) =>
            resto < 2 ? 0 : (11 - resto);
    }
}
