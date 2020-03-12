CREATE PROCEDURE [dbo].[spPerson_GetById]
	@Id int
AS
begin
	set nocount on;

	select *
	from dbo.Person 
	where Id = @Id;
end