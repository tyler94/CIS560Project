CREATE OR ALTER PROCEDURE Movie.CreateDirector
   @FullName NVARCHAR(128),
   @DateOfBirth DATE,
   @Birthplace NVARCHAR(128),
   @DirectorId INT OUTPUT
AS

INSERT Movie.Director(FullName, DateOfBirth, Birthplace)
VALUES(@FullName, @DateOfBirth, @Birthplace);

SET @DirectorId = SCOPE_IDENTITY();
GO