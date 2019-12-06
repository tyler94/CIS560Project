/*create a new director*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.CreateDirector') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.CreateDirector
GO
CREATE PROCEDURE Movie.CreateDirector
   @FullName NVARCHAR(128),
   @DateOfBirth DATE,
   @Birthplace NVARCHAR(128),
   @DirectorId INT OUTPUT
AS

INSERT Movie.Director(FullName, DateOfBirth, Birthplace)
VALUES(@FullName, @DateOfBirth, @Birthplace);

SET @DirectorId = SCOPE_IDENTITY();
GO