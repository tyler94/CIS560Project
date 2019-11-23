CREATE OR ALTER PROCEDURE Movie.RetrieveGenres
AS

SELECT G.GenreId, G.GenreName
FROM Movie.Genre G;
GO