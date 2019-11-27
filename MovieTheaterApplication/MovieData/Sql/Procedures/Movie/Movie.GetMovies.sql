IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetMovies') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetMovies
GO
CREATE PROCEDURE Movie.GetMovies
	@MovieName NVARCHAR(128)
AS

SELECT M.MovieId, M.MovieName, M.DirectorId, M.ProductionCompanyId, M.ReleaseDate, M.IsRemoved, M.[Length], M.FilmRating
FROM Movie.Movie M
WHERE M.MovieName = @MovieName
GO