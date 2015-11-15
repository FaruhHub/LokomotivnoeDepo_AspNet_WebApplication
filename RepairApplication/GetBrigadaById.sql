CREATE PROCEDURE GetBrigadaById
@NOdepo int 
AS
BEGIN
	SET NOCOUNT ON;
SELECT [IDbrigadi] as [№ бригады]
      ,[FIOChief] as [ФИО бригадира]
      ,[Base] as [Образование бригадира]
      ,[NOdepo] as [№ депо]
  FROM [remont_vagonov].[dbo].[Chief]
  where [NOdepo]=@NOdepo
END
GO
