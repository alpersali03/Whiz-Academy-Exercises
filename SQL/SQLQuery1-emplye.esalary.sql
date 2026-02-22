USE Whiz

Go 

CREATE PROC usp_GetEmployeesSalaryAbove35000 (@salaryAbove35000 int)
AS
SELECT E.FirstName, E.LastName FROM Employees AS E
WHERE E.Salary > 35000

EXEC dbo.usp_GetEmployeesSalaryAbove35000 35000

Go

DROP PROCEDURE IF EXISTS usp_GetEmployeesSalaryAboveNumber;
GO

CREATE PROC usp_GetEmployeesSalaryAboveNumber(@number DECIMAL(18,4))  
AS  
BEGIN  
    SELECT E.FirstName, E.LastName  
    FROM Employees AS E  
    WHERE E.Salary >= @number  
END

EXEC usp_GetEmployeesSalaryAboveNumber 48100;

GO

DROP PROCEDURE IF EXISTS usp_GetTownsStartingWith
GO

CREATE PROC usp_GetTownsStartingWith ( @string varchar(40))
AS
SELECT * FROM Employees AS E
Join Addresses AS A ON E.AddressID = A.AddressID
Join Towns AS T ON A.TownID = T.TownID
WHERE T.Name LIKE @string + '%';

EXEC dbo.usp_GetTownsStartingWith 'b'

GO

CREATE PROC usp_GetEmployeesFromTown (@TownName varchar(40))
AS
SELECT E.FirstName, E.LastName FROM Employees AS E
Join Addresses AS A ON E.AddressID = A.AddressID
Join Towns AS T ON T.TownID = A.TownID
WHERE T.Name = @TownName

EXEC dbo.usp_GetEmployeesFromTown 'Sofia'

GO


 CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
 RETURNS VARCHAR(40) AS
	BEGIN
	DECLARE @SALARYLEVEL VARCHAR(40)
	IF (@salary < 30000)
	SET @SALARYLEVEL = ('LOW')
	ELSE IF (@salary > 30000 AND @salary < 50000)
	SET @SALARYLEVEL = ('AVG')
	ELSE
	RETURN ('HIGH')
	RETURN @SALARYLEVEL
END

GO

SELECT dbo.ufn_GetSalaryLevelBySalary(45000)

GO

 CREATE PROCEDURE usp_EmployeesBySalaryLevel (@levelofsalary varchar(40))
 AS
 SELECT E.FirstName, E.LastName FROM Employees AS E
 WHERE dbo.ufn_GetSalaryLevel(E.Salary) = @levelofsalary

 GO

 EXEC dbo.usp_EmployeesBySalaryLevel 'LOW'

 GO
 CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
 RETURNS VARCHAR(40) AS
	BEGIN
	DECLARE @SALARYLEVEL VARCHAR(40)
	IF

 
 GO

 CREATE FUNCTION ufn_IsWordComprised (@setOfLetters varchar(40), @word varchar(40))
 RETURNS VARCHAR(40)
	BEGIN
			DECLARE @RESULT INT
			IF ( @setOfLetters = @word)
			SET @RESULT = 1
			ELSE
			SET @RESULT = 0
	RETURN @RESULT
	END
SELECT dbo.ufn_IsWordComprised 

GO

CREATE PROC usp_DeleteEmployeesFromDepartment (@departmentId INT)
AS
SELECT E.EmployeeID FROM Employees AS E 
Join Departments AS D ON E.DepartmentID = D.DepartmentID
WHERE 