IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.FetchActor') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.FetchActor
GO
CREATE PROCEDURE Movie.FetchActor
   @ActorId INT
AS

SELECT A.FullName, A.DateOfBirth, A.Birthplace
FROM Movie.Actor A
WHERE A.ActorId = @ActorId;
GO
