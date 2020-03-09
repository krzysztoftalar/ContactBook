CREATE TABLE [dbo].[Address]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AddressTypeID] INT NOT NULL,
    [PersonID] INT NOT NULL, 
    [HomeNumber] NVARCHAR(50) NULL, 
    [Street] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NULL, 
    [Country] NVARCHAR(50) NULL,
    CONSTRAINT [FK_Addresses_ToAddressType] FOREIGN KEY (AddressTypeID) REFERENCES AddressType(Id), 
    CONSTRAINT [FK_Address_ToPerson] FOREIGN KEY (PersonID) REFERENCES Person(Id)    
)
