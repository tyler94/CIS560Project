/*get movies by title but only the fields needed for display, includes filter for whether or not a movie has been removed*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetFilteredMoviesByTitleDisplay') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetFilteredMoviesByTitleDisplay
GO
CREATE PROCEDURE Movie.GetFilteredMoviesByTitleDisplay
	@MovieName NVARCHAR(128),
	@IsRemoved BIT
AS

SELECT M.MovieName, D.FullName AS DirectorName, P.CompanyName AS ProductionCompanyName, M.ReleaseDate, M.[Length], M.FilmRating
FROM Movie.Movie M
INNER JOIN Movie.Director D ON D.DirectorId = M.DirectorId
INNER JOIN Movie.ProductionCompany P ON P.CompanyId = M.ProductionCompanyId
WHERE M.IsRemoved = @IsRemoved AND M.MovieName LIKE '%' + @MovieName + '%'
GO