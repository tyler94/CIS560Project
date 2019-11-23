CREATE OR ALTER PROCEDURE Movie.FetchCustomer
   @CustomerId INT
AS

SELECT C.FullName, C.CustomerCategoryId
FROM Movie.Customer C
WHERE C.CustomerId = @CustomerId;
GO
