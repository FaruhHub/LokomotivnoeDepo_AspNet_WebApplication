CREATE PROCEDURE DeleteFromRepair
@TypeRepair char(40) 
AS
BEGIN
	SET NOCOUNT ON;
DELETE FROM [dbo].[Remont]
  where [TypeRepair]=@TypeRepair
END
GO
