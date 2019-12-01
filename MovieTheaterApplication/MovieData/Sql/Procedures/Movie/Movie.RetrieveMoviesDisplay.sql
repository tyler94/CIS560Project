IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.RetrieveMoviesDisplay') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.RetrieveMoviesDisplay
GO
CREATE PROCEDURE Movie.RetrieveMoviesDisplay
AS

SELECT M.MovieName, D.FullName AS DirectorName, P.CompanyName AS ProductionCompanyName, M.ReleaseDate, M.[Length], M.FilmRating
FROM Movie.Movie M
INNER JOIN Movie.Director D ON D.DirectorId = M.DirectorId
INNER JOIN Movie.ProductionCompany P ON P.CompanyId = M.ProductionCompanyId
GO