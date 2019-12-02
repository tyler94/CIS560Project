IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetViewings') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetViewings
GO
CREATE PROCEDURE Movie.GetViewings
	@MovieName NVARCHAR(128),
	@CustomerName NVARCHAR(128),
	@CustomerCategoryName NVARCHAR(128)
AS

SELECT V.ViewingId, C.FullName, CC.CategoryName, M.MovieName, V.ViewedOn
FROM Movie.Viewing V
INNER JOIN Movie.Movie M ON M.MovieId = V.MovieId
INNER JOIN Movie.Customer C ON V.CustomerId = C.CustomerId
INNER JOIN Movie.CustomerCategory CC ON CC.CustomerCategoryId = C.CustomerCategoryId
WHERE M.MovieName LIKE '%' + @MovieName + '%' AND C.FullName LIKE '%' + @CustomerName + '%' AND CC.CategoryName LIKE '%' + @CustomerCategoryName + '%'
GO