IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetFilteredMoviesByGenre') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetFilteredMoviesByGenre
GO
CREATE PROCEDURE Movie.GetFilteredMoviesByGenre
	@GenreName NVARCHAR(128),
	@IsRemoved BIT
AS

SELECT M.MovieId, M.MovieName, M.DirectorId, M.ProductionCompanyId, M.ReleaseDate, M.IsRemoved, M.[Length], M.FilmRating
FROM Movie.Genre G
INNER JOIN Movie.MovieGenre MG ON MG.GenreId = G.GenreId
INNER JOIN Movie.Movie M ON Mg.MovieId = M.MovieId
WHERE M.IsRemoved = @IsRemoved AND G.GenreName LIKE '%' + @GenreName + '%'
GO