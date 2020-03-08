CREATE TABLE [dbo].[Phone]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonID] INT NOT NULL, 
    [PhoneNumberTypeID] INT NOT NULL, 
    [PhoneNumber] NVARCHAR(25) NOT NULL,   
    CONSTRAINT [FK_Phones_ToPhoneNumberType] FOREIGN KEY (PhoneNumberTypeID) REFERENCES PhoneNumberType(Id), 
    CONSTRAINT [FK_Phones_ToPerson] FOREIGN KEY (PersonID) REFERENCES Person(Id)
)
