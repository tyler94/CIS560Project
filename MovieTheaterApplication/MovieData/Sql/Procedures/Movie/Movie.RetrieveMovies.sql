IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.RetrieveMovies') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.RetrieveMovies
GO
CREATE PROCEDURE Movie.RetrieveMovies
AS

SELECT M.MovieId, M.MovieName, M.DirectorId, M.ProductionCompanyId, M.ReleaseDate, M.IsRemoved, M.[Length], M.FilmRating
FROM Movie.Movie M;
GO