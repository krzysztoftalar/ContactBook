CREATE PROCEDURE [dbo].[spAddress_Insert]
	@AddressTypeID int,
	@PersonID int,
	@HomeNumber nvarchar(50),
	@Street nvarchar(50),
	@City nvarchar(50),
	@Country nvarchar(50)
AS
begin
	set nocount on;

	insert into dbo.[Address](AddressTypeID, PersonID, HomeNumber, Street, City, Country)
	values(@AddressTypeID, @PersonID, @HomeNumber, @Street, @City, @Country);
end
