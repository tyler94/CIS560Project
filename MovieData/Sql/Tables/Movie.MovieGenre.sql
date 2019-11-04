IF OBJECT_ID(N'Movie.MovieGenre') IS NULL
BEGIN
   CREATE TABLE Movie.MovieGenre
   (
	  MovieId INT NOT NULL FOREIGN KEY
		REFERENCES Movie.Movie(MovieId),
	  GenreId INT NOT NULL FOREIGN KEY
		REFERENCES Movie.Genre(GenreId)
		
	  PRIMARY KEY(MovieId, GenreId)
   );
END;