Create procedure sp_addStudents
	@Student_Name Nvarchar(20),
	@ID_No Nvarchar(30),
	@Department Nvarchar(30)
	AS
	BEGIN
		INSERT INTO students (
		Student_Name, ID_No, Department
		)
		VALUES
		(
		@Student_Name, @ID_No, @Department
		)
	END

select * from students