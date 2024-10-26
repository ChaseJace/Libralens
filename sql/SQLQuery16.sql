Create procedure Reports
@report nvarchar(30)
AS
BEGIN
	IF(@report = 'Issue')
	BEGIN
		select * from dbo.issue_book where
		Return_Date = ''
	END
	ELSE IF(@report = 'Return')
	BEGIN
		select * from dbo.issue_book where
		Return_Date != ''
	END
END