CREATE OR ALTER PROCEDURE Movie.SaveCustomer
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