IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.FetchProductionCompany') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.FetchProductionCompany
GO
CREATE PROCEDURE Movie.FetchProductionCompany
   @CompanyId INT
AS

SELECT C.CompanyName, C.DateEstablished, C.Location
FROM Movie.ProductionCompany C
WHERE C.CompanyId = @CompanyId;
GO
