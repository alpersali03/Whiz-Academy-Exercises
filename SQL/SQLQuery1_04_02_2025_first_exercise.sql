-- 1.	Employees with Salary Above 35000
-- Create stored procedure usp_GetEmployeesSalaryAbove35000 that returns all employees' 
-- first and last names, whose salary above 35000. 
 
 
 
CREATE PROC usp_GetEmployeesSalaryAbove35001
AS
SELECT e.FirstName + ' ' + e.LastName
	FROM Employees as e
	WHERE e.Salary > 35001
 
 
EXEC dbo.usp_GetEmployeesSalaryAbove35001
 
 
--Create a stored procedure usp_GetEmployeesSalaryAboveNumber that accepts 
--a number (of type DECIMAL(18,4)) as parameter and returns all employees'
--first and last names, whose salary is above or equal to the given number. 
go
 
create proc usp_GetEmployeesSalaryAboveNumber(@num Decimal(18,4))
	as
select e.FirstName, e.LastName 
	from Employees as e
	where e.Salary >= @num
 
 
	exec dbo.usp_GetEmployeesSalaryAboveNumber 48100