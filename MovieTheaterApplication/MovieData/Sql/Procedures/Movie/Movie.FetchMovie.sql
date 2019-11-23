CREATE OR ALTER PROCEDURE Movie.FetchMovie
   @MovieId INT
AS

SELECT M.MovieName, M.DirectorId, M.ProductionCompanyId, M.ReleaseDate, M.IsRemoved, M.[Length], M.FilmRating
FROM Movie.Movie M
WHERE M.MovieId = @MovieId;
GO
