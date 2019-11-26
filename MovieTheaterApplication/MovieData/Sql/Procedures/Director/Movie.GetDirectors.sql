IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetDirectors') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetDirectors
GO
CREATE PROCEDURE Movie.GetDirectors
AS

SELECT D.DirectorId, D.FullName, D.DateOfBirth, D.Birthplace
FROM Movie.Director D;
GO