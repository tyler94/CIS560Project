/*fetches a viewing with the provided id*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.FetchViewing') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.FetchViewing
GO
CREATE PROCEDURE Movie.FetchViewing
   @ViewingId INT
AS

SELECT V.CustomerId, V.MovieId, V.ViewedOn
FROM Movie.Viewing V
WHERE V.ViewingId = @ViewingId;
GO
