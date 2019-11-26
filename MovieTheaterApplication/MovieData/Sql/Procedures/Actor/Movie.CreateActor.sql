IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.CreateActor') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.CreateActor
GO
CREATE PROCEDURE Movie.CreateActor
   @FullName NVARCHAR(128),
   @DateOfBirth DATE,
   @Birthplace NVARCHAR(128),
   @ActorId INT OUTPUT
AS

INSERT Movie.Actor(FullName, DateOfBirth, Birthplace)
VALUES(@FullName, @DateOfBirth, @Birthplace);

SET @ActorId = SCOPE_IDENTITY();
GO
