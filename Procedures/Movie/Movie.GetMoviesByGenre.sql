/*get movies by genre*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetMoviesByGenre') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetMoviesByGenre
GO
CREATE PROCEDURE Movie.GetMoviesByGenre
	@GenreName NVARCHAR(128)
AS

SELECT M.MovieId, M.MovieName, M.DirectorId, M.ProductionCompanyId, M.ReleaseDate, M.IsRemoved, M.[Length], M.FilmRating
FROM Movie.Genre G
INNER JOIN Movie.MovieGenre MG ON MG.GenreId = G.GenreId
INNER JOIN Movie.Movie M ON Mg.MovieId = M.MovieId
WHERE G.GenreName LIKE '%' + @GenreName + '%'
GO