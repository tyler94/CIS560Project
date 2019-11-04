IF OBJECT_ID(N'Movie.CustomerCategory') IS NULL
BEGIN
   CREATE TABLE Movie.CustomerCategory
   (
      CustomerCategoryId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  CategoryName NVARCHAR(128) NOT NULL UNIQUE,
	  TicketPrice DECIMAL(4, 2) NOT NULL,
   );
END;