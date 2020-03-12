CREATE PROCEDURE [dbo].[spPerson_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(50),
	@Description nvarchar(MAX)
AS
begin
	set nocount on;

	update dbo.Person
	set FirstName = @FirstName,
		LastName = @LastName,
		EmailAddress = @EmailAddress,
		[Description] = @Description
	where Id = @Id;
end