﻿IF OBJECT_ID(N'Movie.Cast') IS NULL
BEGIN
   CREATE TABLE Movie.Cast
   (
	  MovieId INT NOT NULL FOREIGN KEY
		REFERENCES Movie.Movie(MovieId),
	  ActorId INT NOT NULL FOREIGN KEY
		REFERENCES Movie.Actor(ActorId),
	  Role NVARCHAR(128) NOT NULL UNIQUE,
		
	  PRIMARY KEY(MovieId, ActorId)
   );
END;