--Criação de Tabelas
CREATE TABLE [dbo].[Produtos] (
    [produto_id]     INT           IDENTITY (1, 1) NOT NULL,
    [descricao]      VARCHAR (255) NOT NULL,
    [marca]          VARCHAR (255) NOT NULL,
    [unidade_medida] VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([produto_id] ASC)
);
CREATE TABLE [dbo].[Enderecos] (
    [endereco_id] INT           IDENTITY (1, 1) NOT NULL,
    [cep]         VARCHAR (8)   NOT NULL,
    [logradouro]  VARCHAR (255) NOT NULL,
    [bairro]      VARCHAR (255) NOT NULL,
    [localidade]  VARCHAR (255) NOT NULL,
    [uf]          VARCHAR (2)   NOT NULL,
    PRIMARY KEY CLUSTERED ([endereco_id] ASC)
);

CREATE TABLE [dbo].[Fornecedores] (
    [fornecedor_id] INT           IDENTITY (1, 1) NOT NULL,
    [nome]          VARCHAR (255) NOT NULL,
    [cnpj]          VARCHAR (18)  NOT NULL,
    [telefone]      VARCHAR (20)  NOT NULL,
    [endereco_id]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([fornecedor_id] ASC),
    UNIQUE NONCLUSTERED ([cnpj] ASC),
    CONSTRAINT [FK_Endereco] FOREIGN KEY ([endereco_id]) REFERENCES [dbo].[Enderecos] ([endereco_id])
);

CREATE TABLE [dbo].[Produtos_Fornecedores] (
    [produto_fornecedor_id] INT             IDENTITY (1, 1) NOT NULL,
    [fornecedor_id]         INT             NOT NULL,
    [produto_id]            INT             NOT NULL,
    [valor_compra]          DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([produto_fornecedor_id] ASC),
    FOREIGN KEY ([fornecedor_id]) REFERENCES [dbo].[Fornecedores] ([fornecedor_id]),
    FOREIGN KEY ([produto_id]) REFERENCES [dbo].[Produtos] ([produto_id])
);

CREATE TABLE [dbo].[UnidadeMedidas] (
    [id]        INT          IDENTITY (1, 1) NOT NULL,
    [descricao] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

insert into UnidadeMedidas ([descricao])
values ('Unidade')

insert into UnidadeMedidas ([descricao])
values ('Quilograma')

insert into UnidadeMedidas ([descricao])
values ('Gramas')

insert into UnidadeMedidas ([descricao])
values ('Metro')

insert into UnidadeMedidas ([descricao])
values ('Centimetro')

