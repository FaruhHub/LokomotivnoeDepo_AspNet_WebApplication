CREATE PROCEDURE InsertRepair
@TypeRepair char,
@Money money,
@Bonus bit,
@BonusPercent int,
@DateStart datetime,
@DateStop datetime,
@Reason char,
@IDbrigadi int,
@RegNumber int
AS
BEGIN
	SET NOCOUNT ON;
INSERT INTO [dbo].[Remont]
           ([TypeRepair]
           ,[Money]
           ,[Bonus]
           ,[BonusPercent]
           ,[DateStart]
           ,[DateStop]
           ,[Reason]
           ,[IDbrigadi]
           ,[RegNumber])
     VALUES
           (@TypeRepair
           ,@Money
           ,@Bonus
           ,@BonusPercent
           ,@DateStart
           ,@DateStop
           ,@Reason
           ,@IDbrigadi
           ,@RegNumber)
END
GO