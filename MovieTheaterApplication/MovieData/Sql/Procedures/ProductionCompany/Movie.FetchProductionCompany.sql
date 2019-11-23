CREATE OR ALTER PROCEDURE Movie.FetchProductionCompany
   @CompanyId INT
AS

SELECT C.CompanyName, C.DateEstablished, C.Location
FROM Movie.ProductionCompany C
WHERE C.CompanyId = @CompanyId;
GO
