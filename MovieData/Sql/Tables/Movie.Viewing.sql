IF OBJECT_ID(N'Movie.Viewing') IS NULL
BEGIN
   CREATE TABLE Movie.Viewing
   (
      ViewingId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  CustomerId INT NOT NULL FOREIGN KEY
		REFERENCES Movie.Customer(CustomerId),
	  MovieId INT NOT NULL FOREIGN KEY
		REFERENCES Movie.Movie(MovieId),
	  ViewingDate DATETIME NOT NULL,
   );
END;