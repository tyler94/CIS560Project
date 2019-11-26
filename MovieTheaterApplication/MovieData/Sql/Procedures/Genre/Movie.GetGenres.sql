IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetGenres') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetGenres
GO
CREATE PROCEDURE Movie.GetGenres
AS

SELECT G.GenreId, G.GenreName
FROM Movie.Genre G;
GO