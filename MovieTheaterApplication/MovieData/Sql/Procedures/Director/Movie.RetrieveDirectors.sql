IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.RetrieveDirectors') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.RetrieveDirectors
GO
CREATE PROCEDURE Movie.RetrieveDirectors
AS

SELECT D.DirectorId, D.FullName, D.DateOfBirth, D.Birthplace
FROM Movie.Director D
ORDER BY D.FullName;
GO