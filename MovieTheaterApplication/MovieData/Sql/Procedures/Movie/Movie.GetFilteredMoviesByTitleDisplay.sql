IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetFilteredMoviesByTitle') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetFilteredMoviesByTitle
GO
CREATE PROCEDURE Movie.GetFilteredMoviesByTitle
	@MovieName NVARCHAR(128),
	@IsRemoved BIT
AS

SELECT M.MovieId, M.MovieName, D.FullName AS DirectorName, P.CompanyName AS ProductionCompanyName, M.ReleaseDate, M.[Length], M.FilmRating
FROM Movie.Movie M
INNER JOIN Movie.Director D ON D.DirectorId = M.DirectorId
INNER JOIN Movie.ProductionCompany P ON P.CompanyId = M.ProductionCompanyId
WHERE M.IsRemoved = @IsRemoved AND M.MovieName LIKE '%' + @MovieName + '%'
GO