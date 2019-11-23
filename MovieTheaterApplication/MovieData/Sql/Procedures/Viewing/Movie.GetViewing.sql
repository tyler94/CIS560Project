CREATE OR ALTER PROCEDURE Movie.RetrieveViewings
AS

SELECT V.ViewingId, V.CustomerId, V.MovieId, V.ViewingDate
FROM Movie.Viewing V;
GO