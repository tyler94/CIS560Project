IF OBJECT_ID(N'Movie.Customer') IS NULL
BEGIN
   CREATE TABLE Movie.Customer
   (
      CustomerId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	  FullName NVARCHAR(128) NOT NULL UNIQUE,
	  CustomerCategoryId INT NOT NULL FOREIGN KEY
		REFERENCES Movie.CustomerCategory(CustomerCategoryId)
   );
END;