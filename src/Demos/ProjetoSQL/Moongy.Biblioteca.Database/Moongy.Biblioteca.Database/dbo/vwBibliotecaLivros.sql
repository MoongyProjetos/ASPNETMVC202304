CREATE VIEW [dbo].[vwBibliotecaLivros]
AS 
	SELECT l.Nome AS NomeLivro, b.Nome AS NomeBiblioteca
	FROM Livros AS l
	LEFT JOIN Biblioteca AS b ON l.BibliotecaId = b.Id
