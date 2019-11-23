CREATE OR ALTER PROCEDURE Movie.CreateProductionCompany
   @CompanyName NVARCHAR(128),
   @DateEstablished DATE,
   @Location NVARCHAR(128),
   @CompanyId INT OUTPUT
AS

INSERT Movie.ProductionCompany(CompanyName, DateEstablished, Location)
VALUES(@CompanyName, @DateEstablished, @Location);

SET @CompanyId = SCOPE_IDENTITY();
GO