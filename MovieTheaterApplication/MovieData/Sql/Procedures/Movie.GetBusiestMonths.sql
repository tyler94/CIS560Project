CREATE OR ALTER PROCEDURE Movie.GetBusiestMonths
   @MyYear DATE
AS

WITH TempTable (ViewingId, MovieId, CustomerId, CustomerCategoryId, TicketPrice, ViewingMonth) AS
(
	SELECT V.ViewingId, V.MovieId, V.CustomerId, C.CustomerCategoryId, CC.TicketPrice, MONTH(V.ViewedOn) AS ViewingMonth
	FROM Movie.Viewing V
	INNER JOIN Movie.Customer C ON V.CustomerId = C.CustomerId
	INNER JOIN Movie.CustomerCategory CC ON C.CustomerCategoryId = CC.CustomerCategoryId
	WHERE YEAR(V.ViewedOn) = YEAR(@MyYear)
)
SELECT T.ViewingMonth, COUNT(T.ViewingId) AS TotalViewers
FROM Movie.Movie M
INNER JOIN TempTable T ON M.MovieId = T.MovieId
GROUP BY T.ViewingMonth
ORDER BY TotalViewers DESC
GO