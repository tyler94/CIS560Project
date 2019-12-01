IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetFilteredMoviesByDirector') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetFilteredMoviesByDirector
GO
CREATE PROCEDURE Movie.GetFilteredMoviesByDirector
	@FullName NVARCHAR(128),
	@IsRemoved BIT
AS

SELECT M.MovieId, M.MovieName, D.FullName AS DirectorName, P.CompanyName AS ProductionCompanyName, M.ReleaseDate, M.[Length], M.FilmRating
FROM Movie.Director D
INNER JOIN Movie.Movie M ON M.DirectorId = D.DirectorId
INNER JOIN Movie.ProductionCompany P ON P.CompanyId = M.ProductionCompanyId
WHERE M.IsRemoved = @IsRemoved AND D.FullName LIKE '%' + @FullName + '%'
GO