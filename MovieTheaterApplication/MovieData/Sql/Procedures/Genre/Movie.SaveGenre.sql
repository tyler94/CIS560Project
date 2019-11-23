CREATE OR ALTER PROCEDURE Movie.SaveGenre
   @GenreId INT ,
   @GenreName NVARCHAR(128)
AS

MERGE Movie.Genre A
USING
      (
         VALUES(@GenreId, @GenreName)
      ) S(GenreId, GenreName)
   ON S.GenreId = A.GenreId
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.GenreName
         INTERSECT
         SELECT  A.GenreName
      ) THEN
   UPDATE
   SET
      GenreName = S.GenreName
WHEN NOT MATCHED THEN
   INSERT(GenreName)
   VALUES(S.GenreName);
GO