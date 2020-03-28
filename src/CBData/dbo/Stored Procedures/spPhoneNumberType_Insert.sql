CREATE PROCEDURE [dbo].[spPhoneNumberType_Insert]	
	@Id int,
	@Name nvarchar(50)
As
begin
	set nocount on;

	insert into dbo.PhoneNumberType([Name])
	values(@Name);

	set @Id = SCOPE_IDENTITY();
	select @Id;
end
