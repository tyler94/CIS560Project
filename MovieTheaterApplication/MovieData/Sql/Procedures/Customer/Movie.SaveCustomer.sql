IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.SaveCustomer') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.SaveCustomer
GO
CREATE PROCEDURE Movie.SaveCustomer
   @CustomerId INT ,
   @FullName NVARCHAR(128),
   @CustomerCategoryId INT
AS

MERGE Movie.Customer A
USING
      (
         VALUES(@CustomerId, @FullName, @CustomerCategoryId)
      ) S(CustomerId, FullName, CustomerCategoryId)
   ON S.CustomerId = A.CustomerId
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.FullName, S.CustomerCategoryId
         INTERSECT
         SELECT  A.FullName, A.CustomerCategoryId
      ) THEN
   UPDATE
   SET
      FullName = S.FullName,
      CustomerCategoryId = S.CustomerCategoryId
WHEN NOT MATCHED THEN
   INSERT(FullName, CustomerCategoryId)
   VALUES(S.FullName, S.CustomerCategoryId);
GO