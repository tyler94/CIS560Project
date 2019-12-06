/*fetch a customer with the given id*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.FetchCustomer') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.FetchCustomer
GO
CREATE PROCEDURE Movie.FetchCustomer
   @CustomerId INT
AS

SELECT C.FullName, C.CustomerCategoryId
FROM Movie.Customer C
WHERE C.CustomerId = @CustomerId;
GO
