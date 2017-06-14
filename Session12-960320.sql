CREATE DATABASE Session12
GO
USE Session12
GO
CREATE TABLE Student
(
	Id INT PRIMARY KEY IDENTITY,
	FullName NVARCHAR(50)
)
GO
CREATE TABLE Scores
(
	Id INT PRIMARY KEY IDENTITY,
	StudentId INT FOREIGN KEY REFERENCES Student(Id),
	CourseName NVARCHAR(50),
	Score DECIMAL(5,2)
)
GO
CREATE FUNCTION GetStudentAverage
(
	@StudentId INT
)
RETURNS DECIMAL(5,2)
AS
BEGIN
	DECLARE @Result DECIMAL(5,2)
	SELECT @Result = AVG(Score) 
	FROM Scores
	WHERE StudentId = @StudentId
	RETURN @Result
END
GO
SELECT dbo.GetStudentAverage(2)
GO
SELECT Id, FullName, dbo.GetStudentAverage(Id)
FROM Student
GO
CREATE FUNCTION GetStudentsByCourseName
(
	@CourseName NVARCHAR(50)
)
RETURNS @Result TABLE
(
	StudentId INT,
	FullName NVARCHAR(50)
)
AS
BEGIN

	INSERT INTO @Result
	SELECT Id, FullName
	FROM Student
	WHERE Id IN
	(
		SELECT StudentId FROM Scores
		WHERE CourseName LIKE '%' + @CourseName + '%'
	)
	RETURN
END
GO
SELECT *
FROM GetStudentsByCourseName('SQL')
GO
ALTER FUNCTION GetTopStudentsByScore
(
	@MinScore DECIMAL(5,2)
)
RETURNS TABLE
AS
RETURN 
	SELECT s.Id, s.FullName , sc.CourseName, sc.Score
	FROM Student s
	INNER JOIN Scores sc
	ON s.Id = sc.StudentId
	WHERE sc.Score > @MinScore
GO
SELECT * 
FROM GetTopStudentsByScore(85)
GO
SELECT USER_NAME()
GO
CREATE TABLE Customer
(
	Id INT PRIMARY KEY IDENTITY,
	FullName NVARCHAR(50),
	AccessedBy NVARCHAR(50)
)
GO
CREATE FUNCTION fn_SecurityFilter 
(
@ColumnName sysname
)
RETURNS TABLE
WITH SCHEMABINDING
AS
RETURN 
SELECT 1   AS [fn_SecurityFilter_result]
FROM dbo.Customer
WHERE @ColumnName = user_name()
GO
CREATE SECURITY POLICY fn_security
ADD FILTER PREDICATE
dbo.fn_SecurityFilter(AccessedBy)
ON dbo.Customer
