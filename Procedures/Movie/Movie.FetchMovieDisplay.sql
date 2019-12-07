/*fetch movie by id but only return fields needed for the data grid view*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.FetchMovieDisplay') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.FetchMovieDisplay
GO
CREATE PROCEDURE Movie.FetchMovieDisplay
   @MovieId INT
AS

SELECT M.MovieName, D.FullName AS DirectorName, P.CompanyName AS ProductionCompanyName, M.ReleaseDate, M.[Length], M.FilmRating
FROM Movie.Movie M
INNER JOIN Movie.Director D ON D.DirectorId = M.DirectorId
INNER JOIN Movie.ProductionCompany P ON P.CompanyId = M.ProductionCompanyId
WHERE M.MovieId = @MovieId;
GO
