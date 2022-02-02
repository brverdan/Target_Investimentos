CREATE DATABASE [TargetInvestimentosDB];

CREATE TABLE [TargetInvestimentosDB]..[Usuarios] (
    [Id]                UNIQUEIDENTIFIER NOT NULL,
    [Nome]              VARCHAR (200)    NOT NULL,
    [Cpf]               VARCHAR (200)    NOT NULL,
    [DataNascimento]    DATETIME2        NOT NULL,
    [RendaMensal]       DECIMAL (18)     NOT NULL,
    [PlanoVip]          BIT              DEFAULT ((0)) NOT NULL,
    [DataCadastramento] DATETIME2        NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [TargetInvestimentosDB]..[EnderecoUsuario] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Logradouro]  VARCHAR (200)    NOT NULL,
    [Bairro]      VARCHAR (50)     NOT NULL,
    [Cep]         VARCHAR (8)      NOT NULL,
    [Cidade]      VARCHAR (50)     NOT NULL,
    [UF]          VARCHAR (50)     NOT NULL,
    [Complemento] VARCHAR (50)     NULL,
    [UsuarioId]   UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UsuarioId]) REFERENCES [TargetInvestimentosDB]..[Usuarios] ([Id]) ON DELETE CASCADE
);