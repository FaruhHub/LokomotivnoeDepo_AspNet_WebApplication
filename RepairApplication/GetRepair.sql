CREATE PROCEDURE GetRepair
AS
BEGIN
	SET NOCOUNT ON;
SELECT *  FROM [remont_vagonov].[dbo].[Remont]
END
GO
