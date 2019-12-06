/*get movies by title*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetMoviesByTitle') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetMoviesByTitle
GO
CREATE PROCEDURE Movie.GetMoviesByTitle
	@MovieName NVARCHAR(128)
AS

SELECT M.MovieId, M.MovieName, M.DirectorId, M.ProductionCompanyId, M.ReleaseDate, M.IsRemoved, M.[Length], M.FilmRating
FROM Movie.Movie M
WHERE M.MovieName LIKE '%' + @MovieName + '%'
GO