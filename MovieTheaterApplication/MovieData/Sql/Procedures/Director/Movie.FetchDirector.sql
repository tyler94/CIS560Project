IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.FetchDirector') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.FetchDirector
GO
CREATE PROCEDURE Movie.FetchDirector
   @DirectorId INT
AS

SELECT D.FullName, D.DateOfBirth, D.Birthplace
FROM Movie.Director D
WHERE D.DirectorId = @DirectorId;
GO
