IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.FetchGenre') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.FetchGenre
GO
CREATE PROCEDURE Movie.FetchGenre
   @GenreId INT
AS

SELECT G.GenreName
FROM Movie.Genre G
WHERE G.GenreId = @GenreId;
GO
