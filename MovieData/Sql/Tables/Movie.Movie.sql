IF OBJECT_ID(N'Movie.MovieGenre') IS NULL
BEGIN
   CREATE TABLE Movie.MovieGenre
   (
      MovieId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  MovieName NVARCHAR(128) NOT NULL UNIQUE,
	  DirectorId INT NOT NULL FOREIGN KEY
		REFERENCES Movie.Director(DirectorId),
	  StudioId INT NOT NULL FOREIGN KEY
		REFERENCES Movie.Studio(StudioId),
	  ReleaseDate DATE NOT NULL,
	  IsRemoved BOOLEAN NOT NULL,
	  [Length] TIME NOT NULL,
	  FilmRating DECIMAL(4, 2)
   );
END;