IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.SaveMovie') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.SaveMovie
GO
CREATE PROCEDURE Movie.SaveMovie
   @MovieId INT,
   @MovieName NVARCHAR(128),
   @ReleaseDate DATE,
   @FilmRating NVARCHAR(128)
AS

MERGE Movie.Movie A
USING
      (
         VALUES(@MovieId, @MovieName, @ReleaseDate, @FilmRating)
      ) S(MovieId, MovieName, ReleaseDate, FilmRating)
   ON S.MovieId = A.MovieId
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.MovieName, S.ReleaseDate, S.FilmRating
         INTERSECT
         SELECT  A.MovieName, A.ReleaseDate, A.FilmRating
      ) THEN
   UPDATE
   SET
      MovieName = S.MovieName,
      ReleaseDate = S.ReleaseDate,
      FilmRating = S.FilmRating
WHEN NOT MATCHED THEN
   INSERT(MovieName, ReleaseDate, FilmRating)
   VALUES(S.MovieName, S.ReleaseDate, S.FilmRating);
GO