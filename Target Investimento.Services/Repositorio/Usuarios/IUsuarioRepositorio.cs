﻿using Target_Investimento.Domain.Usuarios;

namespace Target_Investimento.Services.Repositorio.Usuarios
{
    public interface IUsuarioRepositorio
    {
        Task AdicionarUsuario(Usuario entidade);
        Task<Usuario> ObterUsuario(string cpf);
        Task SalvarMudancas();
    }
}