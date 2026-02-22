USE Whiz

GO
CREATE PROC  usp_GetEmployeesFromTow (@TownName varchar(50) )
AS 
SELECT E.FirstName, E.LastName FROM Employees AS E 
Join Addresses AS A ON E.AddressID = A.AddressID
Join Towns AS T ON A.TownID = T.TownID
WHERE T.Name = @TownName

EXEC dbo.usp_GetEmployeesFromTow 'Sofia'

GO

CREATE FUNCTION ufn_GetSalaryLevelBySalary(@salary DECIMAL(18,2))
RETURNS VARCHAR(40) AS
    BEGIN 
            DECLARE @SALARYLEVEL VARCHAR(40) 
            IF(@salary < 30000)
            SET @SALARYLEVEL = 'LOW'
            ELSE IF(@salary > 30000 and @salary < 50000)
            set @SALARYLEVEL = 'AVG'
            ELSE 
            RETURN 'HIGH'
    RETURN @SALARYLEVEL

    END
    go

    SELECT dbo.ufn_GetSalaryLevelBySalary(45000) as SalaryLl