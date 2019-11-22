Param(
   [string] $Server = "(localdb)\tyler94",
   [string] $Database = "master"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name Sqlps;

# Install the SQL Server Module
# Install-module -Name SqlServer -Scope CurrentUser

# Import the SQL Server Module.    
# Import-Module Sqlps -DisableNameChecking;

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

Write-Host "Dropping tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieData\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieData\Sql\Schemas\Movie.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieData\Sql\Tables\Movie.CustomerCategory.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieData\Sql\Tables\Movie.Customer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieData\Sql\Tables\Movie.Director.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieData\Sql\Tables\Movie.ProductionCompany.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieData\Sql\Tables\Movie.Genre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieData\Sql\Tables\Movie.Actor.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieData\Sql\Tables\Movie.Movie.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieData\Sql\Tables\Movie.Cast.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieData\Sql\Tables\Movie.MovieGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieData\Sql\Tables\Movie.Viewing.sql"

Write-Host "Populating Actor Table"

Import-Csv -Path Desktop\CIS560\MovieDB\actorsnodups.csv | ForEach-Object {
  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.Actor (FullName) VALUES ('$($_.FullName)')"
  }

  Write-Host "Populating Director Table"

  Import-Csv -Path Desktop\CIS560\MovieDB\directorsnodups.csv | ForEach-Object {
  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.Director (FullName) VALUES ('$($_.FullName)')"
  }

  Write-Host "Populating CustomerCategory Table"

  Import-Csv -Path Desktop\CIS560\MovieDB\customercategories.csv | ForEach-Object {
  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.CustomerCategory (CategoryName, TicketPrice) VALUES ('$($_.CategoryName)','$($_.TicketPrice)')"
  }

  Write-Host "Populating Customer Table"

  Import-Csv -Path Desktop\CIS560\MovieDB\customers.csv | ForEach-Object {
  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.Customer (FullName, CustomerCategoryId) VALUES ('$($_.FullName)','$($_.CustomerCategoryId)')"
  }

  Write-Host "Populating Genre Table"

  Import-Csv -Path Desktop\CIS560\MovieDB\genres.csv | ForEach-Object {
  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.Genre (GenreName) VALUES ('$($_.GenreName)')"
  }

  Write-Host "Populating ProductionCompany Table"

  Import-Csv -Path Desktop\CIS560\MovieDB\productioncompanies.csv | ForEach-Object {
  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.ProductionCompany (CompanyName) VALUES ('$($_.CompanyName)')"
  }

  Write-Host "Populating Movie, MovieGenre, and Cast Tables"

  Import-Csv -Path Desktop\CIS560\MovieDB\movies.csv | ForEach-Object {
  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.Movie (MovieName, ReleaseDate, FilmRating, Length, DirectorId, ProductionCompanyId) VALUES ('$($_.MovieName)','$($_.ReleaseDate)','$($_.FilmRating)', '$($_.duration)', (SELECT DirectorId FROM Movie.Director WHERE FullName = '$($_.director_name)'), (SELECT CompanyId FROM Movie.ProductionCompany WHERE CompanyName = '$($_.production_company)'))"
	  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "IF ('$($_.genre1)' <> '') BEGIN insert into Movie.MovieGenre (MovieId, GenreId) VALUES ((SELECT MovieId FROM Movie.Movie WHERE MovieName = '$($_.MovieName)' AND Length = '$($_.duration)' AND ReleaseDate = '$($_.ReleaseDate)'), (SELECT GenreId FROM Movie.Genre WHERE GenreName = '$($_.genre1)'))END"
	  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "IF ('$($_.genre2)' <> '') BEGIN insert into Movie.MovieGenre (MovieId, GenreId) VALUES ((SELECT MovieId FROM Movie.Movie WHERE MovieName = '$($_.MovieName)' AND Length = '$($_.duration)' AND ReleaseDate = '$($_.ReleaseDate)'), (SELECT GenreId FROM Movie.Genre WHERE GenreName = '$($_.genre2)'))END"
	  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "IF ('$($_.genre3)' <> '') BEGIN insert into Movie.MovieGenre (MovieId, GenreId) VALUES ((SELECT MovieId FROM Movie.Movie WHERE MovieName = '$($_.MovieName)' AND Length = '$($_.duration)' AND ReleaseDate = '$($_.ReleaseDate)'), (SELECT GenreId FROM Movie.Genre WHERE GenreName = '$($_.genre3)'))END"
	  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "IF ('$($_.genre4)' <> '') BEGIN insert into Movie.MovieGenre (MovieId, GenreId) VALUES ((SELECT MovieId FROM Movie.Movie WHERE MovieName = '$($_.MovieName)' AND Length = '$($_.duration)' AND ReleaseDate = '$($_.ReleaseDate)'), (SELECT GenreId FROM Movie.Genre WHERE GenreName = '$($_.genre4)'))END"
	  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "IF ('$($_.genre5)' <> '') BEGIN insert into Movie.MovieGenre (MovieId, GenreId) VALUES ((SELECT MovieId FROM Movie.Movie WHERE MovieName = '$($_.MovieName)' AND Length = '$($_.duration)' AND ReleaseDate = '$($_.ReleaseDate)'), (SELECT GenreId FROM Movie.Genre WHERE GenreName = '$($_.genre5)'))END"
	  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "IF ('$($_.genre6)' <> '') BEGIN insert into Movie.MovieGenre (MovieId, GenreId) VALUES ((SELECT MovieId FROM Movie.Movie WHERE MovieName = '$($_.MovieName)' AND Length = '$($_.duration)' AND ReleaseDate = '$($_.ReleaseDate)'), (SELECT GenreId FROM Movie.Genre WHERE GenreName = '$($_.genre6)'))END"
	  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "IF ('$($_.genre7)' <> '') BEGIN insert into Movie.MovieGenre (MovieId, GenreId) VALUES ((SELECT MovieId FROM Movie.Movie WHERE MovieName = '$($_.MovieName)' AND Length = '$($_.duration)' AND ReleaseDate = '$($_.ReleaseDate)'), (SELECT GenreId FROM Movie.Genre WHERE GenreName = '$($_.genre7)'))END"

	  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "IF ('$($_.actor_1_name)' <> '') BEGIN insert into Movie.Cast (MovieId, ActorId) VALUES ((SELECT MovieId FROM Movie.Movie WHERE MovieName = '$($_.MovieName)' AND Length = '$($_.duration)' AND ReleaseDate = '$($_.ReleaseDate)'), (SELECT ActorId FROM Movie.Actor WHERE FullName = '$($_.actor_1_name)'))END"
	  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "IF ('$($_.actor_2_name)' <> '') BEGIN insert into Movie.Cast (MovieId, ActorId) VALUES ((SELECT MovieId FROM Movie.Movie WHERE MovieName = '$($_.MovieName)' AND Length = '$($_.duration)' AND ReleaseDate = '$($_.ReleaseDate)'), (SELECT ActorId FROM Movie.Actor WHERE FullName = '$($_.actor_2_name)'))END"
	  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "IF ('$($_.actor_3_name)' <> '') BEGIN insert into Movie.Cast (MovieId, ActorId) VALUES ((SELECT MovieId FROM Movie.Movie WHERE MovieName = '$($_.MovieName)' AND Length = '$($_.duration)' AND ReleaseDate = '$($_.ReleaseDate)'), (SELECT ActorId FROM Movie.Actor WHERE FullName = '$($_.actor_3_name)'))END"
  }


#Write-Host "Stored procedures..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Procedures\Movie.CreateMovie.sql"
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Procedures\Movie.RetrieveMovies.sql"
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Procedures\Movie.FetchMovie.sql"
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Procedures\Movie.GetMovie.sql"
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Procedures\Movie.SaveMovieAddress.sql"
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Procedures\Movie.RetrieveAddressesForMovie.sql"

Write-Host "Rebuild completed."
Write-Host ""
