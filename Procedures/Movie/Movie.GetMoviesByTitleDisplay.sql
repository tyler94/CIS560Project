/*get movies by title but only the fields needed for display*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetMoviesByTitleDisplay') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetMoviesByTitleDisplay
GO
CREATE PROCEDURE Movie.GetMoviesByTitleDisplay
	@MovieName NVARCHAR(128)
AS

SELECT M.MovieName, D.FullName AS DirectorName, P.CompanyName AS ProductionCompanyName, M.ReleaseDate, M.[Length], M.FilmRating
FROM Movie.Movie M
INNER JOIN Movie.Director D ON D.DirectorId = M.DirectorId
INNER JOIN Movie.ProductionCompany P ON P.CompanyId = M.ProductionCompanyId
WHERE M.MovieName LIKE '%' + @MovieName + '%'
GO