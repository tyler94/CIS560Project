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

#Import-Csv -Path Desktop\CIS560\MovieDB\testdata.csv | Format-Table

#Import-Csv -Path Desktop\CIS560\MovieDB\actorsnodups.csv | ForEach-Object {
 # Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.Actor VALUES ('$($_.FullName)')"
  #}

  #Import-Csv -Path Desktop\CIS560\MovieDB\directorsnodups.csv | ForEach-Object {
  #Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.Director VALUES ('$($_.FullName)')"
  #}

  #Import-Csv -Path Desktop\CIS560\MovieDB\customercategories.csv | ForEach-Object {
  #Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.CustomerCategory VALUES ('$($_.Category)','$($_.TicketPrice)')"
  #}

  #Import-Csv -Path Desktop\CIS560\MovieDB\customers.csv | ForEach-Object {
  #Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.Customer VALUES ('$($_.FullName)','$($_.CustomerCategoryId)')"
  #}

  #Import-Csv -Path Desktop\CIS560\MovieDB\genres.csv | ForEach-Object {
  #Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.Genre VALUES ('$($_.GenreName)')"
  #}

  #Import-Csv -Path Desktop\CIS560\MovieDB\productioncompanies.csv | ForEach-Object {
  #Invoke-SqlCmd -ServerInstance $Server -Database $Database -Query "insert into Movie.ProductionCompany VALUES ('$($_.CompanyName)')"
  #}

  #Import-Csv -Path Desktop\CIS560\MovieDB\movies.csv | ForEach-Object {
  #Invoke-SqlCmd -ServerInstance $Server -Database $Database
  #-Query "insert into Movie.Movie VALUES ('$($_.Column1)','$($_.Column2)')"
  #}

  #TODO Cast and MovieGenre Tables (Possibly Viewing as well)

#Write-Host "Stored procedures..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Procedures\Movie.CreateMovie.sql"
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Procedures\Movie.RetrieveMovies.sql"
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Procedures\Movie.FetchMovie.sql"
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Procedures\Movie.GetMovie.sql"
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Procedures\Movie.SaveMovieAddress.sql"
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Procedures\Movie.RetrieveAddressesForMovie.sql"

#Write-Host "Inserting data..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Data\Movie.AddressType.sql"

Write-Host "Rebuild completed."
Write-Host ""
