CREATE OR ALTER PROCEDURE Movie.SaveViewing
   @ViewingId INT ,
   @CustomerId INT,
   @MovieId INT,
   @ViewingDate DATETIME
AS

MERGE Movie.Director A
USING
      (
         VALUES(@ViewingId, @CustomerId, @MovieId, @ViewingDate)
      ) S(ViewingId, CustomerId, MovieId, ViewingDate)
   ON S.ViewingId = A.ViewingId
   AND S.CustomerId = A.CustomerId
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.MovieId, S.ViewingDate
         INTERSECT
         SELECT A.MovieId, A.ViewingDate
      ) THEN
   UPDATE
   SET
      CustomerId = S.CustomerId,
      MovieId = S.MovieId,
      ViewingDate = S.ViewingDate
WHEN NOT MATCHED THEN
   INSERT(CustomerId, MovieId, ViewingDate)
   VALUES(S.CustomerId, S.MovieId, S.ViewingDate);
GO