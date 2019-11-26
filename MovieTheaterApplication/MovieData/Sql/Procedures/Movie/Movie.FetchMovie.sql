IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.FetchMovie') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.FetchMovie
GO
CREATE PROCEDURE Movie.FetchMovie
   @MovieId INT
AS

SELECT M.MovieName, M.DirectorId, M.ProductionCompanyId, M.ReleaseDate, M.IsRemoved, M.[Length], M.FilmRating
FROM Movie.Movie M
WHERE M.MovieId = @MovieId;
GO
