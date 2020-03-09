CREATE PROCEDURE [dbo].[spPerson_GetAll]
AS
begin
	set nocount on

	select Id, FirstName, LastName
	from dbo.Person 
end
