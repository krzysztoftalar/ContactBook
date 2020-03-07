CREATE TABLE [dbo].[Phones]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PhoneNumberTypeID] INT NOT NULL, 
    [PhoneNumber] NVARCHAR(25) NOT NULL, 
    CONSTRAINT [FK_Phones_ToPhoneNumbersTypes] FOREIGN KEY (PhoneNumberTypeID) REFERENCES PhoneNumbersTypes(Id),
)
