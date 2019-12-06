/*retrieve all customers*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.RetrieveCustomers') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.RetrieveCustomers
GO
CREATE PROCEDURE Movie.RetrieveCustomers
AS

SELECT C.CustomerId, C.FullName, C.CustomerCategoryId
FROM Movie.Customer C;
GO