/*Update an existing production company (unused)*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.SaveProductionCompany') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.SaveProductionCompany
GO
CREATE PROCEDURE Movie.SaveProductionCompany
   @CompanyId INT ,
   @CompanyName NVARCHAR(128),
   @DateEstablished DATE,
   @Location NVARCHAR(128)
AS

MERGE Movie.ProductionCompany A
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