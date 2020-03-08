CREATE PROCEDURE [dbo].[spPhone_Insert]
	@PersonID int,
	@PhoneNumberTypeID int,
	@PhoneNumber nvarchar(25)
AS
begin 
	set nocount on;

	insert into dbo.Phone(PersonID, PhoneNumberTypeID, PhoneNumber)
	values(@PersonID, @PhoneNumberTypeID, @PhoneNumber);
end
