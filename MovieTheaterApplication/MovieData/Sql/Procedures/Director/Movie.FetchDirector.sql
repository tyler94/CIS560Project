CREATE OR ALTER PROCEDURE Movie.FetchDirector
   @DirectorId INT
AS

SELECT D.FullName, D.DateOfBirth, D.Birthplace
FROM Movie.Director D
WHERE D.DirectorId = @DirectorId;
GO
