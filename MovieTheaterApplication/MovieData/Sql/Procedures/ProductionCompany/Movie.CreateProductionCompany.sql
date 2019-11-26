IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.CreateProductionCompany') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.CreateProductionCompany
GO
CREATE PROCEDURE Movie.CreateProductionCompany
   @CompanyName NVARCHAR(128),
   @DateEstablished DATE,
   @Location NVARCHAR(128),
   @CompanyId INT OUTPUT
AS

INSERT Movie.ProductionCompany(CompanyName, DateEstablished, Location)
VALUES(@CompanyName, @DateEstablished, @Location);

SET @CompanyId = SCOPE_IDENTITY();
GO