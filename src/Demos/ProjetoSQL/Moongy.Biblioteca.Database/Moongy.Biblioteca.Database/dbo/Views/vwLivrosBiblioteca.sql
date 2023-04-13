CREATE VIEW [dbo].[vwLivrosBiblioteca]
AS 
SELECT  b.Nome AS Biblio, l.Nome AS Livro
FROM Livros AS l
LEFT JOIN Biblioteca AS b ON l.BibliotecaId = b.Id