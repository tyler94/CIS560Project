/*retrieve all viewings*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.RetrieveViewings') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.RetrieveViewings
GO
CREATE PROCEDURE Movie.RetrieveViewings
AS

SELECT V.ViewingId, V.CustomerId, V.MovieId, V.ViewedOn
FROM Movie.Viewing V;
GO