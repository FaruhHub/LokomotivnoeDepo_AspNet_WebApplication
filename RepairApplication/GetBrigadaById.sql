CREATE PROCEDURE GetBrigadaById
@NOdepo int 
AS
BEGIN
	SET NOCOUNT ON;
SELECT [IDbrigadi] as [� �������]
      ,[FIOChief] as [��� ���������]
      ,[Base] as [����������� ���������]
      ,[NOdepo] as [� ����]
  FROM [remont_vagonov].[dbo].[Chief]
  where [NOdepo]=@NOdepo
END
GO
