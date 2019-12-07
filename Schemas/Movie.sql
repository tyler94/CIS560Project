IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'Movie'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [Movie] AUTHORIZATION [dbo]');
END;
