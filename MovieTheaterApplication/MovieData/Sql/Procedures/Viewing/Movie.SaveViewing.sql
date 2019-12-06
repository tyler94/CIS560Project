/*update an existing viewing*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.SaveViewing') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.SaveViewing
GO
CREATE PROCEDURE Movie.SaveViewing
   @ViewingId INT,
   @CustomerId INT,
   @MovieId INT,
   @ViewedOn DATETIME
AS

MERGE Movie.Viewing A
USING
      (
         VALUES(@ViewingId, @CustomerId, @MovieId, @ViewedOn)
      ) S(ViewingId, CustomerId, MovieId, ViewedOn)
   ON S.ViewingId = A.ViewingId
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.MovieId, S.ViewedOn
         INTERSECT
         SELECT A.MovieId, A.ViewedOn
      ) THEN
   UPDATE
   SET
      CustomerId = S.CustomerId,
      MovieId = S.MovieId,
      ViewedOn = S.ViewedOn;

GO