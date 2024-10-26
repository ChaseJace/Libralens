Create Procedure Update_issueBook
@ID Nvarchar(30),
@Return_Date Nvarchar(30)
AS
BEGIN
	Update issue_book set Return_Date = @Return_Date
	where issue_ID = @ID
END