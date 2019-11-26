IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.RetrieveActors') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.RetrieveActors
GO
CREATE PROCEDURE Movie.RetrieveActors
AS

SELECT A.ActorId, A.FullName, A.DateOfBirth, A.Birthplace
FROM Movie.Actor A;
GO