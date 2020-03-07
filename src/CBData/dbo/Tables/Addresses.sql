CREATE TABLE [dbo].[Addresses]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AddressTypeID] INT NOT NULL,
    [HomeNumber] INT NOT NULL, 
    [Street] NVARCHAR(50) NOT NULL, 
    [City] NVARCHAR(50) NOT NULL, 
    [Country] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Addresses_ToAddressesTypes] FOREIGN KEY (AddressTypeID) REFERENCES AddressesTypes(Id)    
)
