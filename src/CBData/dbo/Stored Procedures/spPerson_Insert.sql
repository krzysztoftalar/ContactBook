CREATE PROCEDURE [dbo].[spPerson_Insert]
	@Id int output,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(50),
	@Description nvarchar(MAX)
AS
begin
	set nocount on;

	insert into dbo.Person(FirstName, LastName, EmailAddress, [Description])
	values(@FirstName, @LastName, @EmailAddress, @Description);

	select @Id = SCOPE_IDENTITY();
end
