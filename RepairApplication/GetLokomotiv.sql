CREATE PROCEDURE GetLokomotiv
@NOdepo int
AS
BEGIN
	SET NOCOUNT ON;
SELECT *  FROM [remont_vagonov].[dbo].[Lokomotiv]
where [NOdepo]=@NOdepo
END
GO
