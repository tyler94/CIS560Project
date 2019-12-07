/*get customer by name and category*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetCustomers') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetCustomers
GO
CREATE PROCEDURE Movie.GetCustomers
	@FullName NVARCHAR(128),
	@CategoryName NVARCHAR(128)
AS

SELECT C.CustomerId, C.FullName, C.CustomerCategoryId
FROM Movie.Customer C
INNER JOIN Movie.CustomerCategory CC ON C.CustomerCategoryId = CC.CustomerCategoryId
WHERE C.FullName = @FullName AND CC.CategoryName = @CategoryName
GO