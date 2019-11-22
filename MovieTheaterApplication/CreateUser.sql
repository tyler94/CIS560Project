CREATE LOGIN [tylertest] WITH PASSWORD = 'test';
CREATE USER [tylertest] FOR LOGIN [tylertest];
exec sp_addrolemember 'db_owner', 'tylertest'