Create procedure ViewBooks
@BookName Nvarchar(30)
AS
BEGIN
	IF (@BookName = '')
	BEGIN
		Select * from tbl_books
	END
	ELSE
	BEGIN
		Select * from tbl_books Where BookName = @BookName
	END

END