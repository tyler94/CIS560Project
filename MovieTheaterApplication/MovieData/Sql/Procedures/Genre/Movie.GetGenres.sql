/*Get genre by name*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetGenres') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetGenres
GO
CREATE PROCEDURE Movie.GetGenres
	@GenreName NVARCHAR(128)
AS

SELECT G.GenreId, G.GenreName
FROM Movie.Genre G
WHERE G.GenreName = @GenreName
GO