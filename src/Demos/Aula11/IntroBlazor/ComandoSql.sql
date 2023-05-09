CREATE TABLE [dbo].[Estudantes]
(
	[EstudanteId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Email] VARCHAR(255) NULL, 
    [Nome] NVARCHAR(255) NOT NULL, 
    [Idade] INT NULL
)
