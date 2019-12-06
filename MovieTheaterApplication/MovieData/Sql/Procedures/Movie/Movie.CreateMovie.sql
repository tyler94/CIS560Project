/*create new movie*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.CreateMovie') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.CreateMovie
GO
CREATE PROCEDURE Movie.CreateMovie
   @MovieName NVARCHAR(128),
   @DirectorId INT,
   @ProductionCompanyId INT,
   @ReleaseDate DATE,
   @FilmRating NVARCHAR(128),
   @MovieLength INT,
   @MovieId INT OUTPUT
AS

INSERT Movie.Movie(MovieName, DirectorId, ProductionCompanyId, ReleaseDate, FilmRating, [Length])
VALUES(@MovieName, @DirectorId, @ProductionCompanyId, @ReleaseDate, @FilmRating, @MovieLength)

SET @MovieId = SCOPE_IDENTITY();
GO