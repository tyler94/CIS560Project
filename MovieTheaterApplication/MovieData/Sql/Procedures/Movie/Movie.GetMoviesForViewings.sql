/*get movies by name for use with the showings section of the program*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetMoviesForViewings') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetMoviesForViewings
GO
CREATE PROCEDURE Movie.GetMoviesForViewings
	@MovieName NVARCHAR(128)
AS

SELECT M.MovieId, M.MovieName, M.DirectorId, M.ProductionCompanyId, M.ReleaseDate, M.IsRemoved, M.[Length], M.FilmRating
FROM Movie.Movie M
WHERE M.MovieName = @MovieName AND M.IsRemoved = 0
GO