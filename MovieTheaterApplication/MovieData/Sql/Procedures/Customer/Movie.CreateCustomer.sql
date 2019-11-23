CREATE OR ALTER PROCEDURE Movie.CreateCustomer
   @FullName NVARCHAR(128),
   @CustomerCategoryId INT,
   @CutomerId INT OUTPUT
AS

INSERT Movie.Customer(FullName, CustomerCategoryId)
VALUES(@FullName, @CustomerCategoryId);

SET @CustomerCategoryId = SCOPE_IDENTITY();
GO