CREATE OR ALTER PROCEDURE Movie.RetrieveDirectors
AS

SELECT D.DirectorId, D.FullName, D.DateOfBirth, D.Birthplace
FROM Movie.Director D;
GO