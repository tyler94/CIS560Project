CREATE OR ALTER PROCEDURE Movie.CreateGenre
   @GenreName NVARCHAR(128),
   @GenreId INT OUTPUT
AS

INSERT Movie.Genre(GenreName)
VALUES(@GenreName);

SET @GenreId = SCOPE_IDENTITY();
GO