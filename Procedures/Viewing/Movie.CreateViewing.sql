/*Creates a new viewing*/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Movie.CreateViewing') AND type in (N'P', N'PC'))
  DROP PROCEDURE Movie.CreateViewing
GO
CREATE PROCEDURE Movie.CreateViewing
   @MovieId INT,
   @CustomerId INT,
   @ViewedOn DATETIME
AS

INSERT Movie.Viewing(CustomerId, MovieId, ViewedOn)
VALUES(@CustomerId, @MovieId, @ViewedOn);
GO