/*Search for a viewing with a specified date and time (returns id in addition to other fields)*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetViewingsOnDateWithId') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetViewingsOnDateWithId
GO
CREATE PROCEDURE Movie.GetViewingsOnDateWithId
	@MovieName NVARCHAR(128),
	@CustomerName NVARCHAR(128),
	@CustomerCategoryName NVARCHAR(128),
	@ViewedOn DATETIME
AS

SELECT V.ViewingId, C.FullName AS CustomerName, CC.CategoryName AS CustomerCategory, M.MovieName AS MovieTitle, V.ViewedOn AS ShowDate
FROM Movie.Viewing V
INNER JOIN Movie.Movie M ON M.MovieId = V.MovieId
INNER JOIN Movie.Customer C ON V.CustomerId = C.CustomerId
INNER JOIN Movie.CustomerCategory CC ON CC.CustomerCategoryId = C.CustomerCategoryId
WHERE M.MovieName = @MovieName AND C.FullName = @CustomerName AND CC.CategoryName = @CustomerCategoryName AND V.ViewedOn = @ViewedOn
GO