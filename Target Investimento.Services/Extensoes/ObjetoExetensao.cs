namespace Target_Investimento.Services.Extensoes
{
    public static class ObjetoExetensao
    {
        public static bool IsNull<T>(this T objeto) =>
            Equals(objeto, default);

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> objeto) =>
            Equals(objeto, default(IEnumerable<T>)) || !objeto.Any();
    }
}
