CREATE OR ALTER PROCEDURE Movie.RetrieveProductionCompanies
AS

SELECT P.CompanyId, P.CompanyName, P.DateEstablished, P.Location
FROM Movie.ProductionCompany P;
GO