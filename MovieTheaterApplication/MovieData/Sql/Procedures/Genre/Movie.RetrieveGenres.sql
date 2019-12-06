/*retrieve all genres*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.RetrieveGenres') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.RetrieveGenres
GO
CREATE PROCEDURE Movie.RetrieveGenres
AS

SELECT G.GenreId, G.GenreName
FROM Movie.Genre G;
GO