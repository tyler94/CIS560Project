IF OBJECT_ID(N'Movie.Actor') IS NULL
BEGIN
   CREATE TABLE Movie.Actor
   (
      ActorId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  FullName NVARCHAR(128) NOT NULL,
	  DateOfBirth DATE,
	  Birthplace NVARCHAR(128)
   );
END;