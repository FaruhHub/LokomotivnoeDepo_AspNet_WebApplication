CREATE PROCEDURE GetMoneyByRepair
AS
BEGIN
	SET NOCOUNT ON;
select w.TypeRepair, count(*) [Number]
from Remont w
where DateStop between '2014-01-01 00:00:00.000' AND CURRENT_TIMESTAMP
group by w.TypeRepair
END
GO