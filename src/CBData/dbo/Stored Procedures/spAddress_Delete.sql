CREATE PROCEDURE [dbo].[spAddress_Delete]
	@Id int
AS
begin
	set nocount on;

	delete from dbo.[Address]
	where PersonID = @Id;
end
