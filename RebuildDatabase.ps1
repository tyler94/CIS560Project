Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "tyler94"
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
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Schemas\Movie.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Tables\Movie.CustomerCategory.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Tables\Movie.Customer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Tables\Movie.Director.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Tables\Movie.Studio.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Tables\Movie.Genre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Tables\Movie.Actor.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Tables\Movie.Movie.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Tables\Movie.Cast.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Tables\Movie.MovieGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "MovieData\Sql\Tables\Movie.Viewing.sql"



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
