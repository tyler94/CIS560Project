CREATE OR ALTER PROCEDURE Movie.CreateViewing
   @CustomerId INT,
   @MovieId INT,
   @ViewingDate DATETIME,
   @ViewingId INT OUTPUT
AS

INSERT Movie.Viewing(CustomerId, MovieId, ViewingDate)
VALUES(@CustomerId, @MovieId, @ViewingDate);

SET @ViewingId = SCOPE_IDENTITY();
GO