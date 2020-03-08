CREATE PROCEDURE [dbo].[spPhoneNumberType_GetAll]	
AS
begin 
	set nocount on;

	select Id, [Name]
	from dbo.PhoneNumberType
	order by [Name];
end
