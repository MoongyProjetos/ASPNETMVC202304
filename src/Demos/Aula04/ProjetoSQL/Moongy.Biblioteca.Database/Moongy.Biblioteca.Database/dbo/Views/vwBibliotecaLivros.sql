CREATE VIEW [dbo].[vwBibliotecaLivros]
AS 
SELECT l.Nome AS Livro, b.Nome AS Biblio
FROM Livros AS l
LEFT JOIN Biblioteca AS b ON l.BibliotecaId = b.Id
