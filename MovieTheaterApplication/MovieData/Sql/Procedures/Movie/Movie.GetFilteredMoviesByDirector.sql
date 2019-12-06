/*get movies by director, includes filter for whether or not a movie has been removed*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetFilteredMoviesByDirector') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetFilteredMoviesByDirector
GO
CREATE PROCEDURE Movie.GetFilteredMoviesByDirector
	@FullName NVARCHAR(128),
	@IsRemoved BIT
AS

SELECT M.MovieId, M.MovieName, M.DirectorId, M.ProductionCompanyId, M.ReleaseDate, M.IsRemoved, M.[Length], M.FilmRating
FROM Movie.Director D
INNER JOIN Movie.Movie M ON M.DirectorId = D.DirectorId
WHERE M.IsRemoved = @IsRemoved AND D.FullName LIKE '%' + @FullName + '%'
GO