/*get movies by director but only the fields needed for display*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetMoviesByDirectorDisplay') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetMoviesByDirectorDisplay
GO
CREATE PROCEDURE Movie.GetMoviesByDirectorDisplay
	@FullName NVARCHAR(128)
AS

SELECT M.MovieName, D.FullName AS DirectorName, P.CompanyName AS ProductionCompanyName, M.ReleaseDate, M.[Length], M.FilmRating
FROM Movie.Director D
INNER JOIN Movie.Movie M ON M.DirectorId = D.DirectorId
INNER JOIN Movie.ProductionCompany P ON P.CompanyId = M.ProductionCompanyId
WHERE D.FullName LIKE '%' + @FullName + '%'
GO