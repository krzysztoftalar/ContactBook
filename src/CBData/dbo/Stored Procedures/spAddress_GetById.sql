CREATE PROCEDURE [dbo].[spAddress_GetById]
	@Id int
AS
begin
	set nocount on;

	select *
	from dbo.Address
	where PersonID = @Id;
end