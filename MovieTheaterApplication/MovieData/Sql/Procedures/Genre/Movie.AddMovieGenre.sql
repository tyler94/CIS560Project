IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.AddMovieGenre') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.AddMovieGenre
GO
CREATE PROCEDURE Movie.AddMovieGenre
   @MovieId INT,
   @GenreId INT
AS

INSERT Movie.MovieGenre(MovieId, GenreId)
VALUES(@MovieId, @GenreId);
GO