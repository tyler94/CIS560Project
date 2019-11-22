IF OBJECT_ID(N'Movie.Movie') IS NULL
BEGIN
   CREATE TABLE Movie.Movie
   (
      MovieId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  MovieName NVARCHAR(128) NOT NULL,
	  DirectorId INT FOREIGN KEY
		REFERENCES Movie.Director(DirectorId),
	  ProductionCompanyId INT FOREIGN KEY
		REFERENCES Movie.ProductionCompany(CompanyId),
	  ReleaseDate DATE,
	  IsRemoved BIT NOT NULL DEFAULT 1,
	  [Length] INT,
	  FilmRating NVARCHAR(128)
   );
END;