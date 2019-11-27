IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetFilteredMoviesByTitle') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetFilteredMoviesByTitle
GO
CREATE PROCEDURE Movie.GetFilteredMoviesByTitle
	@MovieName NVARCHAR(128),
	@IsRemoved BIT
AS

SELECT M.MovieId, M.MovieName, M.DirectorId, M.ProductionCompanyId, M.ReleaseDate, M.IsRemoved, M.[Length], M.FilmRating
FROM Movie.Movie M
WHERE M.IsRemoved = @IsRemoved AND M.MovieName LIKE '%' + @MovieName + '%'
GO