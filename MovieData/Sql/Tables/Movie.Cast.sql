IF OBJECT_ID(N'Movie.MovieGenre') IS NULL
BEGIN
   CREATE TABLE Movie.MovieGenre
   (
	  MovieId INT NOT NULL FOREIGN KEY
		REFERENCES Movie.Movie(MovieId),
	  ActorId INT NOT NULL FOREIGN KEY
		REFERENCES Movie.Actor(ActorId),
	  Role NVARCHAR(128) NOT NULL UNIQUE
		
	  PRIMARY KEY(MovieId, ActorId)
   );
END;