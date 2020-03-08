CREATE PROCEDURE [dbo].[spPerson_Lookup]
	@EmailAddress nvarchar(50)
AS
begin
	set nocount on;

	select Id
	from dbo.Person
	where EmailAddress = @EmailAddress;
end
