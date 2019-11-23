CREATE OR ALTER PROCEDURE Movie.RetrieveCustomers
AS

SELECT C.CustomerId, C.FullName, C.CustomerCategoryId
FROM Movie.Customer C;
GO