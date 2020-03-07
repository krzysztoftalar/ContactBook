CREATE TABLE [dbo].[Persons]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AddressID] INT NOT NULL, 
    [PhoneID] INT NOT NULL,
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [EmailAddress] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_Persons_ToAddresses] FOREIGN KEY (AddressID) REFERENCES Addresses(Id), 
    CONSTRAINT [FK_Persons_ToPhones] FOREIGN KEY (PhoneID) REFERENCES Phones(Id), 
    
)
