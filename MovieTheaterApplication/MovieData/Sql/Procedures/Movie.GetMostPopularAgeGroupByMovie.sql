IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetMostPopularAgeGroupByMovie') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetMostPopularAgeGroupByMovie
GO
CREATE PROCEDURE Movie.GetMostPopularAgeGroupByMovie
AS

WITH TempTable (ViewingId, MovieId, CustomerId, CustomerCategoryId, CategoryName) AS
(
	SELECT V.ViewingId, V.MovieId, V.CustomerId, C.CustomerCategoryId, CC.CategoryName
	FROM Movie.Viewing V
	INNER JOIN Movie.Customer C ON V.CustomerId = C.CustomerId
	INNER JOIN Movie.CustomerCategory CC ON C.CustomerCategoryId = CC.CustomerCategoryId
),
TempTable2 (MovieId, MovieName, TotalViewers, CategoryName) AS
(
	SELECT M.MovieId, M.MovieName, COUNT(T.ViewingId) AS TotalViewers, T.CategoryName
	FROM Movie.Movie M
	INNER JOIN TempTable T ON M.MovieId = T.MovieId
	GROUP BY M.MovieId, M.MovieName, T.CategoryName
)

SELECT T2.MovieId, T2.MovieName, T2.CategoryName, T2.TotalViewers
FROM (
	SELECT MovieId, MovieName,  MAX(TotalViewers) AS MostWatchedCount
	FROM TempTable2
	GROUP BY MovieId, MovieName
) AS b 
INNER JOIN TempTable2 T2 ON T2.MovieId = b.MovieId AND T2.TotalViewers = b.MostWatchedCount
GROUP BY T2.MovieId, T2.MovieName, T2.CategoryName, T2.TotalViewers
ORDER BY T2.MovieId ASC
GO