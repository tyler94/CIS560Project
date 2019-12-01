IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetFilteredMoviesByGenre') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetFilteredMoviesByGenre
GO
CREATE PROCEDURE Movie.GetFilteredMoviesByGenre
	@GenreName NVARCHAR(128),
	@IsRemoved BIT
AS

SELECT M.MovieId, M.MovieName, D.FullName AS DirectorName, P.CompanyName AS ProductionCompanyName, M.ReleaseDate, M.[Length], M.FilmRating
FROM Movie.Genre G
INNER JOIN Movie.MovieGenre MG ON MG.GenreId = G.GenreId
INNER JOIN Movie.Movie M ON Mg.MovieId = M.MovieId
INNER JOIN Movie.Director D ON D.DirectorId = M.DirectorId
INNER JOIN Movie.ProductionCompany P ON P.CompanyId = M.ProductionCompanyId
WHERE M.IsRemoved = @IsRemoved AND G.GenreName LIKE '%' + @GenreName + '%'
GO