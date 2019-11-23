CREATE OR ALTER PROCEDURE Movie.RetrieveActors
AS

SELECT A.ActorId, A.FullName, A.DateOfBirth, A.Birthplace
FROM Movie.Actor A;
GO