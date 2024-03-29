/*Create new movie genre and add it to an existing movie*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.CreateGenre') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.CreateGenre
GO
CREATE PROCEDURE Movie.CreateGenre
   @GenreName NVARCHAR(128),
   @MovieId INT,
   @GenreId INT OUTPUT
AS

INSERT Movie.Genre(GenreName)
VALUES(@GenreName);

SET @GenreId = SCOPE_IDENTITY();

INSERT Movie.MovieGenre(GenreId, MovieId)
VALUES(@GenreId, @MovieId);
GO