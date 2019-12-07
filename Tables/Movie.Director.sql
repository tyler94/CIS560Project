IF OBJECT_ID(N'Movie.Director') IS NULL
BEGIN
   CREATE TABLE Movie.Director
   (
      DirectorId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  FullName NVARCHAR(128) NOT NULL,
	  DateOfBirth DATE,
	  Birthplace NVARCHAR(128)
   );
END;