CREATE PROCEDURE GetDepo
AS
BEGIN
	SET NOCOUNT ON;
SELECT [NOdepo] as [№ депо]
      ,[External] as [Внешнее/местное депо]
      ,[BankExternal] as [Банк депо]
      ,[InnExternal] as [ИНН депо]
      ,[AddressExternal] as [Адрес депо]

  FROM [remont_vagonov].[dbo].[Depo]
END
GO
