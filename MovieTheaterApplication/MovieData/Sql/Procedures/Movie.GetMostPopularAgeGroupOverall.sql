/*get customer type that comes to the movies most often*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetMostPopularAgeGroupOverall') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetMostPopularAgeGroupOverall
GO
CREATE PROCEDURE Movie.GetMostPopularAgeGroupOverall
AS

SELECT TOP 1 C.CustomerCategoryId, CC.CategoryName, COUNT(V.ViewingId) AS ViewCount
	FROM Movie.Viewing V
	INNER JOIN Movie.Customer C ON V.CustomerId = C.CustomerId
	INNER JOIN Movie.CustomerCategory CC ON C.CustomerCategoryId = CC.CustomerCategoryId
	GROUP BY C.CustomerCategoryId, CC.CategoryName
	ORDER BY ViewCount DESC
GO