/*search through production companies*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.GetProductionCompanies') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.GetProductionCompanies
GO
CREATE PROCEDURE Movie.GetProductionCompanies
	@CompanyName NVARCHAR(128)
AS

SELECT P.CompanyId, P.CompanyName, P.DateEstablished, P.Location
FROM Movie.ProductionCompany P
WHERE P.CompanyName = @CompanyName
GO