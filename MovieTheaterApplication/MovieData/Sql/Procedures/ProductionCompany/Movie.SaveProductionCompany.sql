CREATE OR ALTER PROCEDURE Movie.SaveProductionCompany
   @CompanyId INT ,
   @CompanyName NVARCHAR(128),
   @DateEstablished DATE,
   @Location NVARCHAR(128)
AS

MERGE Movie.Director A
USING
      (
         VALUES(@CompanyId, @CompanyName, @DateEstablished, @Location)
      ) S(CompanyId, CompanyName, DateEstablished, Location)
   ON S.CompanyId = A.CompanyId
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.CompanyName, S.DateEstablished, S.Location
         INTERSECT
         SELECT  A.CompanyName, A.DateEstablished, A.Location
      ) THEN
   UPDATE
   SET
      CompanyName = S.CompanyName,
      DateEstablished = S.DateEstablished,
      Location = S.Location
WHEN NOT MATCHED THEN
   INSERT(CompanyName, DateEstablished, Location)
   VALUES(S.CompanyName, S.DateEstablished, S.Location);
GO