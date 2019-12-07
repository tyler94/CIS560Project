/*create a new customer (unused)*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.CreateCustomer') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.CreateCustomer
GO
CREATE PROCEDURE Movie.CreateCustomer
   @FullName NVARCHAR(128),
   @CustomerCategoryId INT,
   @CutomerId INT OUTPUT
AS

INSERT Movie.Customer(FullName, CustomerCategoryId)
VALUES(@FullName, @CustomerCategoryId);

SET @CustomerCategoryId = SCOPE_IDENTITY();
GO