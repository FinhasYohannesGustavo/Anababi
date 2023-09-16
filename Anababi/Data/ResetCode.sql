DELETE FROM [References];
DELETE FROM [Users];
DELETE FROM [Creators];
DELETE FROM [ReferenceLocations];
DELETE FROM [Libraries];

DBCC CHECKIDENT ('References', RESEED, 0);
DBCC CHECKIDENT ('Users', RESEED, 0);
DBCC CHECKIDENT ('Creators', RESEED, 0);
DBCC CHECKIDENT ('ReferenceLocations', RESEED, 0);
DBCC CHECKIDENT ('Libraries', RESEED, 0);