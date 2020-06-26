IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Fornecedores] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] nvarchar(max) NULL,
    [Documento] nvarchar(max) NULL,
    [TipoFornecedor] int NOT NULL,
    [Ativo] bit NOT NULL,
    CONSTRAINT [PK_Fornecedores] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Enderecos] (
    [Id] uniqueidentifier NOT NULL,
    [FornecedorId] uniqueidentifier NOT NULL,
    [Logradouro] nvarchar(max) NULL,
    [Numero] nvarchar(max) NULL,
    [Complemento] nvarchar(max) NULL,
    [Cep] nvarchar(max) NULL,
    [Bairro] nvarchar(max) NULL,
    [Cidade] nvarchar(max) NULL,
    [Estado] nvarchar(max) NULL,
    CONSTRAINT [PK_Enderecos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Enderecos_Fornecedores_FornecedorId] FOREIGN KEY ([FornecedorId]) REFERENCES [Fornecedores] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Produtos] (
    [Id] uniqueidentifier NOT NULL,
    [FornecedorId] uniqueidentifier NOT NULL,
    [Nome] nvarchar(max) NULL,
    [Descricao] nvarchar(max) NULL,
    [Imagem] nvarchar(max) NULL,
    [Valor] decimal(18,2) NOT NULL,
    [DataCadastro] datetime2 NOT NULL,
    [Ativo] bit NOT NULL,
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Produtos_Fornecedores_FornecedorId] FOREIGN KEY ([FornecedorId]) REFERENCES [Fornecedores] ([Id]) ON DELETE NO ACTION
);

GO

CREATE UNIQUE INDEX [IX_Enderecos_FornecedorId] ON [Enderecos] ([FornecedorId]);

GO

CREATE INDEX [IX_Produtos_FornecedorId] ON [Produtos] ([FornecedorId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200512150901_Initial', N'3.0.0');

GO

