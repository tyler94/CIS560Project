CREATE OR ALTER PROCEDURE Movie.FetchViewing
   @ViewingId INT
AS

SELECT V.CustomerId, V.MovieId, V.ViewingDate
FROM Movie.Viewing V
WHERE V.ViewingId = @ViewingId;
GO
