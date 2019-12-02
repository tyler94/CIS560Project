IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetViewingsOnDate') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetViewingsOnDate
GO
CREATE PROCEDURE Movie.GetViewingsOnDate
	@MovieName NVARCHAR(128),
	@CustomerName NVARCHAR(128),
	@CustomerCategoryName NVARCHAR(128),
	@ViewedOn DATE
AS

SELECT C.FullName AS CustomerName, CC.CategoryName AS CustomerCategory, M.MovieName AS MovieTitle, V.ViewedOn AS ShowDate
FROM Movie.Viewing V
INNER JOIN Movie.Movie M ON M.MovieId = V.MovieId
INNER JOIN Movie.Customer C ON V.CustomerId = C.CustomerId
INNER JOIN Movie.CustomerCategory CC ON CC.CustomerCategoryId = C.CustomerCategoryId
WHERE M.MovieName LIKE '%' + @MovieName + '%' AND C.FullName LIKE '%' + @CustomerName + '%' AND CC.CategoryName LIKE '%' + @CustomerCategoryName + '%' AND V.ViewedOn = @ViewedOn
GO