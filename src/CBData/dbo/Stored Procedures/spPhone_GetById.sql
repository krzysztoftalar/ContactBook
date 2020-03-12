CREATE PROCEDURE [dbo].[spPhone_GetById]
	@Id int
AS
begin
	set nocount on;

	select *
	from dbo.Phone
	where PersonID = @Id;
end
