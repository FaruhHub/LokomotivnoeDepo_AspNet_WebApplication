CREATE PROCEDURE GetDepo
AS
BEGIN
	SET NOCOUNT ON;
SELECT [NOdepo] as [� ����]
      ,[External] as [�������/������� ����]
      ,[BankExternal] as [���� ����]
      ,[InnExternal] as [��� ����]
      ,[AddressExternal] as [����� ����]

  FROM [remont_vagonov].[dbo].[Depo]
END
GO
