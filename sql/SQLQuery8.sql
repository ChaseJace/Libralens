Create procedure [dbo].[ViewStudents]
@ID_No Nvarchar(30)
AS
BEGIN
	IF (@ID_No = '')
	BEGIN
		Select * from students
	END
	ELSE
	BEGIN
		Select * from students Where ID_No = @ID_No
	END

END

select * from students