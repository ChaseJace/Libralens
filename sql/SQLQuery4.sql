Create Procedure SP_add_books
	@BookName Nvarchar(30),
	@AuthorName Nvarchar(30),
	@publication nvarchar(30),
	@purchaseDate nvarchar(40),
	@BookPrice Nvarchar(20),
	@Quantity Nvarchar(30)
AS
BEGIN
	INSERT INTO tbl_books (
	BookName, AuthorName, publication,
	purchaseDate, BookPrice, Quantity)
	VALUES
	(
	@BookName, @AuthorName, @publication,
	@purchaseDate, @BookPrice, @Quantity
	)
END