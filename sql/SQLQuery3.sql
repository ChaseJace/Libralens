Create table tbl_books
(
	BookID INT IDENTITY(1,1),
	BookName Nvarchar(30),
	AuthorName Nvarchar(30),
	publication nvarchar(30),
	purchaseDate nvarchar(40),
	BookPrice Nvarchar(20),
	Quantity Nvarchar(30)
)

select * from tbl_books