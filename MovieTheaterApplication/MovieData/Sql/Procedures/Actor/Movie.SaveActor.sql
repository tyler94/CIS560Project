CREATE OR ALTER PROCEDURE Movie.SaveActor
   @ActorId INT ,
   @FullName NVARCHAR(128),
   @DateOfBirth DATE,
   @Birthplace NVARCHAR(128)
AS

MERGE Movie.Actor A
USING
      (
         VALUES(@ActorId, @FullName, @DateOfBirth, @BirthPlace)
      ) S(ActorId, FullName, DateOfBirth, BirthPlace)
   ON S.ActorId = A.ActorId
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.FullName, S.DateOfBirth, S.BirthPlace
         INTERSECT
         SELECT  A.FullName, A.DateOfBirth, A.BirthPlace
      ) THEN
   UPDATE
   SET
      FullName = S.FullName,
      DateOfBirth = S.DateOfBirth,
      BirthPlace = S.BirthPlace
WHEN NOT MATCHED THEN
   INSERT(FullName, DateOfBirth, BirthPlace)
   VALUES(S.FullName, S.DateOfBirth, S.BirthPlace);
GO