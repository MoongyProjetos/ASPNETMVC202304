--Create
--Read
--Update
--Delete

--INSERT INTO Biblioteca (Nome, Endereco, Telefone) 
--VALUES ('Barreiro', 'Rua da Biblioteca', '+351999999')


-- SELECT * FROM Biblioteca

--INSERT INTO Livros (Nome, Autor, Editora) VALUES ('Harry Potter', 'JK', 'Editora')

UPDATE Livros SET BibliotecaId = 1 WHERE Id = 2

SELECT * FROM livros


SELECT bib.Nome, liv.Nome, liv.Autor
FROM Biblioteca bib
LEFT JOIN Livros liv ON liv.BibliotecaId = bib.Id

