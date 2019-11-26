IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetCustomers') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetCustomers
GO
CREATE PROCEDURE Movie.GetCustomers
AS

SELECT C.CustomerId, C.FullName, C.CustomerCategoryId
FROM Movie.Customer C;
GO