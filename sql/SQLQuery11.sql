Create Procedure sp_addissuebook
	@Student_Name Nvarchar(30),
	@ID_No Nvarchar(30),
	@BookName Nvarchar(30),
	@Issue_Date Nvarchar(50),
	@Return_Date Nvarchar(50)
AS
BEGIN
	Insert into issue_book
	(
	Student_Name,
	ID_No,
	BookName,
	Issue_Date,
	Return_Date
	)
	VALUES
	(
	@Student_Name, 
	@ID_No,
	@BookName,
	@Issue_Date,
	@Return_Date
	)
END