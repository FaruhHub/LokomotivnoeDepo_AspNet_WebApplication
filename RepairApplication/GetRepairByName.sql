CREATE PROCEDURE GetRepairByName
@TypeRepair char(40)
AS
BEGIN
	SET NOCOUNT ON;
SELECT [TypeRepair]
      ,[Money]
      ,[Bonus]
      ,[BonusPercent]
      ,[DateStart] 
      ,[DateStop] 
      ,[Reason] 
      ,[IDbrigadi]
      ,[RegNumber]
  FROM [remont_vagonov].[dbo].[Remont]
  where [TypeRepair]= @TypeRepair
END
GO

