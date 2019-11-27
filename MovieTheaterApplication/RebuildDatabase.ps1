Param(
   [string] $Server = "(localdb)\560Project",
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
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Schemas\Movie.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Tables\Movie.CustomerCategory.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Tables\Movie.Customer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Tables\Movie.Director.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Tables\Movie.ProductionCompany.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Tables\Movie.Genre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Tables\Movie.Actor.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Tables\Movie.Movie.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Tables\Movie.Cast.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Tables\Movie.MovieGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Tables\Movie.Viewing.sql"

Write-Host "Populating Actor Table"

Import-Csv -Path Desktop\CIS560\MovieDB\MovieTheaterApplication\csvs\actorsnodups.csv | ForEach-Object {
  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.Actor (FullName) VALUES ('$($_.FullName)')"
  }

  Write-Host "Populating Director Table"

  Import-Csv -Path Desktop\CIS560\MovieDB\MovieTheaterApplication\csvs\directorsnodups.csv | ForEach-Object {
  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.Director (FullName) VALUES ('$($_.FullName)')"
  }

  Write-Host "Populating CustomerCategory Table"

  Import-Csv -Path Desktop\CIS560\MovieDB\MovieTheaterApplication\csvs\customercategories.csv | ForEach-Object {
  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.CustomerCategory (CategoryName, TicketPrice) VALUES ('$($_.CategoryName)','$($_.TicketPrice)')"
  }

  Write-Host "Populating Customer Table"

  Import-Csv -Path Desktop\CIS560\MovieDB\MovieTheaterApplication\csvs\customers.csv | ForEach-Object {
  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.Customer (FullName, CustomerCategoryId) VALUES ('$($_.FullName)','$($_.CustomerCategoryId)')"
  }

  Write-Host "Populating Genre Table"

  Import-Csv -Path Desktop\CIS560\MovieDB\MovieTheaterApplication\csvs\genres.csv | ForEach-Object {
  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.Genre (GenreName) VALUES ('$($_.GenreName)')"
  }

  Write-Host "Populating ProductionCompany Table"

  Import-Csv -Path Desktop\CIS560\MovieDB\MovieTheaterApplication\csvs\productioncompanies.csv | ForEach-Object {
  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.ProductionCompany (CompanyName) VALUES ('$($_.CompanyName)')"
  }

  Write-Host "Populating Movie, MovieGenre, and Cast Tables"

  Import-Csv -Path Desktop\CIS560\MovieDB\MovieTheaterApplication\csvs\movies.csv | ForEach-Object {
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
  
  Import-Csv -Path Desktop\CIS560\MovieDB\MovieTheaterApplication\csvs\viewings.csv | ForEach-Object {
  Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.Viewing (MovieId, CustomerId, ViewedOn) VALUES ('$($_.MovieId)', '$($_.CustomerId)', '$($_.ViewedOn)')"
  }


#Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie.GetBusiestMonths.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie.GetMostViewedGenres.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie.GetMostViewedMovies.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie.GetHighestCustomerCountByDay.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie.GetHighestCustomerCountByMonth.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie.GetHighestCustomerCountByYear.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie.GetTopGrossingMovies.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie.GetMostPopularAgeGroupByMovie.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie.GetMostPopularAgeGroupByMovieV2.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie.GetMostPopularAgeGroupOverall.sql"


Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Viewing\Movie.CreateViewing.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Viewing\Movie.FetchViewing.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Viewing\Movie.GetViewings.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Viewing\Movie.RetrieveViewings.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Viewing\Movie.SaveViewing.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\ProductionCompany\Movie.CreateProductionCompany.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\ProductionCompany\Movie.FetchProductionCompany.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\ProductionCompany\Movie.GetProductionCompanies.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\ProductionCompany\Movie.RetrieveProductionCompanies.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\ProductionCompany\Movie.SaveProductionCompany.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie\Movie.CreateMovie.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie\Movie.FetchMovie.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie\Movie.GetFilteredMoviesByDirector.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie\Movie.GetFilteredMoviesByGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie\Movie.GetFilteredMoviesByTitle.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie\Movie.GetMovies.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie\Movie.GetMoviesByDirector.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie\Movie.GetMoviesByGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie\Movie.GetMoviesByTitle.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie\Movie.RetrieveMovies.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Movie\Movie.SaveMovie.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Genre\Movie.CreateGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Genre\Movie.AddMovieGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Genre\Movie.FetchGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Genre\Movie.GetGenres.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Genre\Movie.RetrieveGenres.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Genre\Movie.SaveGenre.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Director\Movie.CreateDirector.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Director\Movie.FetchDirector.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Director\Movie.GetDirectors.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Director\Movie.RetrieveDirectors.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Director\Movie.SaveDirector.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Customer\Movie.CreateCustomer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Customer\Movie.FetchCustomer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Customer\Movie.GetCustomers.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Customer\Movie.RetrieveCustomers.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Customer\Movie.SaveCustomer.sql"

Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Actor\Movie.CreateActor.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Actor\Movie.AddCast.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Actor\Movie.FetchActor.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Actor\Movie.GetActors.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Actor\Movie.RetrieveActors.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Desktop\CIS560\MovieDB\MovieTheaterApplication\MovieData\Sql\Procedures\Actor\Movie.SaveActor.sql"

Write-Host "Rebuild completed."
Write-Host ""
