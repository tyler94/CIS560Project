CREATE OR ALTER PROCEDURE Movie.FetchGenre
   @GenreId INT
AS

SELECT G.GenreName
FROM Movie.Genre G
WHERE G.GenreId = @GenreId;
GO
