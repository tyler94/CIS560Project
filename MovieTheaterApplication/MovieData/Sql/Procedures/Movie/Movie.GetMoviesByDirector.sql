/*get movies by director*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetMoviesByDirector') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetMoviesByDirector
GO
CREATE PROCEDURE Movie.GetMoviesByDirector
	@FullName NVARCHAR(128)
AS

SELECT M.MovieId, M.MovieName, M.DirectorId, M.ProductionCompanyId, M.ReleaseDate, M.IsRemoved, M.[Length], M.FilmRating
FROM Movie.Director D
INNER JOIN Movie.Movie M ON M.DirectorId = D.DirectorId
WHERE D.FullName LIKE '%' + @FullName + '%'
GO