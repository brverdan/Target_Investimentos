namespace Target_Investimento.Services.CasoDeUso.Usuarios.CriarUsuario
{
    public interface ICriarUsuarioCasoDeUso
    {
        Task<CriarUsuarioResponse> Executar(CriarUsuarioRequest request);
    }
}
