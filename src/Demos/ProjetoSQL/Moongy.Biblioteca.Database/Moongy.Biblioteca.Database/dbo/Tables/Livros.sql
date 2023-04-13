CREATE TABLE [dbo].[Livros] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Nome]          VARCHAR (50)  NOT NULL,
    [Autor]         VARCHAR (250) NULL,
    [Editora]       VARCHAR (10)  NULL,
    [BibliotecaId]  INT           NOT NULL,
    [NumeroPaginas] INT           DEFAULT ((0)) NULL,
    [Isbn] VARCHAR(14) NULL
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([BibliotecaId]) REFERENCES [dbo].[Biblioteca] ([Id])
);

