CREATE OR ALTER PROCEDURE Movie.GetMostViewedGenres
AS

WITH TempTable (ViewingId, MovieId, CustomerId, CustomerCategoryId, TicketPrice) AS
(
	SELECT V.ViewingId, V.MovieId, V.CustomerId, C.CustomerCategoryId, CC.TicketPrice
	FROM Movie.Viewing V
	INNER JOIN Movie.Customer C ON V.CustomerId = C.CustomerId
	INNER JOIN Movie.CustomerCategory CC ON C.CustomerCategoryId = CC.CustomerCategoryId
),
TempTable2 (MovieId, GenreId, GenreName) AS
(
	SELECT MG.MovieId, MG.GenreId, G.GenreName
	FROM Movie.MovieGenre MG
	INNER JOIN Movie.Genre G ON MG.GenreId = G.GenreId
)
SELECT T2.GenreId, T2.GenreName, COUNT(DISTINCT T1.ViewingId) AS ViewCount
FROM TempTable T1
INNER JOIN TempTable2 T2 ON T1.MovieId = T2.MovieId
GROUP BY T2.GenreId, T2.GenreName
ORDER BY ViewCount DESC
GO