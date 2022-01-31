namespace Target_Investimento.Services.Usuarios.CriarUsuario
{
    public interface ICriarUsuarioCasoDeUso
    {
        Task<CriarUsuarioResponse> Executar(CriarUsuarioRequest request);
    }
}
