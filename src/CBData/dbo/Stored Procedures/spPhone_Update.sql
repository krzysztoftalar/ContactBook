CREATE PROCEDURE [dbo].[spPhone_Update]
	@Id int,
	@PersonID int,
	@PhoneNumberTypeID int,
	@PhoneNumber nvarchar(25)
AS
begin 
	set nocount on;

	update dbo.Phone
	set PhoneNumber = @PhoneNumber
	where PersonID = @PersonID and PhoneNumberTypeID = @PhoneNumberTypeID

	if @@ROWCOUNT = 0
	insert into dbo.Phone(PersonID, PhoneNumberTypeID, PhoneNumber)
	values(@PersonID, @PhoneNumberTypeID, @PhoneNumber);
end