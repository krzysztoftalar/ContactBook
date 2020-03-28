CREATE PROCEDURE [dbo].[spAddressType_Insert]	
	@Id int,
	@Name nvarchar(50)
As
begin
	set nocount on;

	insert into dbo.AddressType([Name])
	values(@Name);

	set @Id = SCOPE_IDENTITY();
	select @Id;
end
