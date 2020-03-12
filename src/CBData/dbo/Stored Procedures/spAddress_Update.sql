CREATE PROCEDURE [dbo].[spAddress_Update]
	@Id int,	
	@AddressTypeID int,
	@PersonID int,
	@HomeNumber nvarchar(50),
	@Street nvarchar(50),
	@City nvarchar(50),
	@Country nvarchar(50)
AS
begin
	set nocount on;

	update dbo.[Address]
	set HomeNumber = @HomeNumber,
		Street = @Street,
		City = @City,
		Country = @Country
	where PersonID = @PersonID and AddressTypeID = @AddressTypeID

	if @@ROWCOUNT = 0
	insert into dbo.[Address](AddressTypeID, PersonID, HomeNumber, Street, City, Country)
	values(@AddressTypeID, @PersonID, @HomeNumber, @Street, @City, @Country);
end
