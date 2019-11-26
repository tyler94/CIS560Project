IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetActors') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetActors
GO
CREATE PROCEDURE Movie.GetActors
AS

SELECT A.ActorId, A.FullName, A.DateOfBirth, A.Birthplace
FROM Movie.Actor A;
GO