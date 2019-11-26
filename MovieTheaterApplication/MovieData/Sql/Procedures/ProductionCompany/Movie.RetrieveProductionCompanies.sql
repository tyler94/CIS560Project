IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.RetrieveProductionCompanies') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.RetrieveProductionCompanies
GO
CREATE PROCEDURE Movie.RetrieveProductionCompanies
AS

SELECT P.CompanyId, P.CompanyName, P.DateEstablished, P.Location
FROM Movie.ProductionCompany P;
GO