CREATE OR ALTER PROCEDURE Movie.CreateActor
   @FullName NVARCHAR(128),
   @DateOfBirth DATE,
   @Birthplace NVARCHAR(128),
   @ActorId INT OUTPUT
AS

INSERT Movie.Actor(FullName, DateOfBirth, Birthplace)
VALUES(@FullName, @DateOfBirth, @Birthplace);

SET @ActorId = SCOPE_IDENTITY();
GO
