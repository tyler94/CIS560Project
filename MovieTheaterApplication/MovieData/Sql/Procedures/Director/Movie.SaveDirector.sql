/*Update an existing director*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.SaveDirector') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.SaveDirector
GO
CREATE PROCEDURE Movie.SaveDirector
   @DirectorId INT ,
   @FullName NVARCHAR(128),
   @DateOfBirth DATE,
   @Birthplace NVARCHAR(128)
AS

MERGE Movie.Director A
USING
      (
         VALUES(@DirectorId, @FullName, @DateOfBirth, @Birthplace)
      ) S(DirectorId, FullName, DateOfBirth, Birthplace)
   ON S.DirectorId = A.DirectorId
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.FullName, S.DateOfBirth, S.Birthplace
         INTERSECT
         SELECT  A.FullName, A.DateOfBirth, A.Birthplace
      ) THEN
   UPDATE
   SET
      FullName = S.FullName,
      DateOfBirth = S.DateOfBirth,
      Birthplace = S.Birthplace
WHEN NOT MATCHED THEN
   INSERT(FullName, DateOfBirth, Birthplace)
   VALUES(S.FullName, S.DateOfBirth, S.Birthplace);
GO