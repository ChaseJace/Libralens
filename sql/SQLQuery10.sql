Create Table issue_book
(
	Issue_ID int IDENTITY(1,1),
	Student_Name Nvarchar(30),
	ID_No Nvarchar(30),
	BookName Nvarchar(30),
	Issue_Date Nvarchar(50),
	Return_Date Nvarchar(50)
)