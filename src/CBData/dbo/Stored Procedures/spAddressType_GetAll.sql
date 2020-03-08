CREATE PROCEDURE [dbo].[spAddressType_GetAll]
AS
begin 
	set nocount on

	select Id, [Name]
	from dbo.AddressType
	order by [Name];
end
go
