CREATE TABLE [dbo].[Biblioteca] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Nome]     VARCHAR (50)  NOT NULL,
    [Endereco] VARCHAR (250) NULL,
    [Telefone] VARCHAR (10)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

