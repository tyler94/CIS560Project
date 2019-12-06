/*add an existing actor to the cast of an existing movie*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.AddCast') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.AddCast
GO
CREATE PROCEDURE Movie.AddCast
   @MovieId INT,
   @ActorId INT
AS

INSERT Movie.Cast(ActorId, MovieId)
VALUES(@ActorId, @MovieId);
GO
