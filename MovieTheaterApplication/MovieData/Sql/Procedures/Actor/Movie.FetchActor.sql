CREATE OR ALTER PROCEDURE Movie.FetchActor
   @ActorId INT
AS

SELECT A.FullName, A.DateOfBirth, A.Birthplace
FROM Movie.Actor A
WHERE A.ActorId = @ActorId;
GO
