/*update an existing movie*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.SaveMovie') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.SaveMovie
GO
CREATE PROCEDURE Movie.SaveMovie
   @MovieId INT,
   @MovieName NVARCHAR(128),
   @DirectorId INT,
   @ReleaseDate DATE,
   @ProductionCompanyId INT,
   @FilmLength INT,
   @FilmRating NVARCHAR(128)
AS

MERGE Movie.Movie A
USING
      (
         VALUES(@MovieId, @MovieName, @DirectorId, @ReleaseDate, @ProductionCompanyId, @FilmLength, @FilmRating)
      ) S(MovieId, MovieName, DirectorId, ReleaseDate, ProductionCompanyId, FilmLength, FilmRating)
   ON S.MovieId = A.MovieId
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.MovieName, S.DirectorId, S.ReleaseDate, S.ProductionCompanyId, S.FilmLength, S.FilmRating
         INTERSECT
         SELECT  A.MovieName, A.DirectorId, A.ReleaseDate, A.ProductionCompanyId, A.[Length], A.FilmRating
      ) THEN
   UPDATE
   SET
      MovieName = S.MovieName,
	  DirectorId = S.DirectorId,
      ReleaseDate = S.ReleaseDate,
	  ProductionCompanyId = S.ProductionCompanyId,
	  [Length] = S.FilmLength,
      FilmRating = S.FilmRating
WHEN NOT MATCHED THEN
   INSERT(MovieName, DirectorId, ReleaseDate, ProductionCompanyId, [Length], FilmRating)
   VALUES(S.MovieName, S.DirectorId, S.ReleaseDate, S.ProductionCompanyId, S.FilmLength, S.FilmRating);
GO