CREATE PROCEDURE [dbo].[spPhone_Delete]
	@Id int
AS
begin
	set nocount on;

	delete from dbo.Phone
	where PersonID = @Id or Id = @Id;
end
