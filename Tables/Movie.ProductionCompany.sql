IF OBJECT_ID(N'Movie.ProductionCompany') IS NULL
BEGIN
   CREATE TABLE Movie.ProductionCompany
   (
      CompanyId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  CompanyName NVARCHAR(128) NOT NULL UNIQUE,
	  DateEstablished DATE,
	  Location NVARCHAR(128)
   );
END;
