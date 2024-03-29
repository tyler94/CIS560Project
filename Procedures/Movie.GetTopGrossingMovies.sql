/*get highest grossing movies*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetTopGrossingMovies') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetTopGrossingMovies
GO
CREATE PROCEDURE Movie.GetTopGrossingMovies
AS

WITH TempTable (ViewingId, MovieId, CustomerId, CustomerCategoryId, TicketPrice) AS
(
	SELECT V.ViewingId, V.MovieId, V.CustomerId, C.CustomerCategoryId, CC.TicketPrice
	FROM Movie.Viewing V
	INNER JOIN Movie.Customer C ON V.CustomerId = C.CustomerId
	INNER JOIN Movie.CustomerCategory CC ON C.CustomerCategoryId = CC.CustomerCategoryId
)
SELECT M.MovieId, M.MovieName, SUM(T.TicketPrice) AS TotalMovieSales
FROM Movie.Movie M
INNER JOIN TempTable T ON M.MovieId = T.MovieId
GROUP BY M.MovieId, M.MovieName
ORDER BY TotalMovieSales DESC
GO