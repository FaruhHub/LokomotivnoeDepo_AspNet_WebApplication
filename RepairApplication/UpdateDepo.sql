Create procedure [dbo].UpdateDepo
@NOdepo int,
@AddressExternal nchar(80)
AS
 SET NOCOUNT ON;
UPDATE [remont_vagonov].[dbo].[Depo]
   SET [AddressExternal] = @AddressExternal
      
 WHERE [NOdepo] = @NOdepo

GO
