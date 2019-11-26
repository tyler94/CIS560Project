IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetViewings') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetViewings
GO
CREATE PROCEDURE Movie.GetViewings
AS

SELECT V.ViewingId, V.CustomerId, V.MovieId, V.ViewedOn
FROM Movie.Viewing V;
GO