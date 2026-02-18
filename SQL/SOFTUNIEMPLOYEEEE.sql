USE Whiz

SELECT TOP 5 E.EmployeeID, E.JobTitle, A.AddressID, A.AddressText FROM Employees AS E
Join Addresses AS A ON E.AddressID = A.AddressID
ORDER BY AddressID ASC

SELECT TOP 50 E.FirstName, E.LastName, T.Name, A.AddressText FROM Employees AS E
Join Addresses AS A ON E.AddressID = A.AddressID
Join Towns AS T ON T.TownID = A.TownID
ORDER BY E.FirstName, E.LastName ASC

SELECT E.EmployeeID, E.FirstName, E.LastName, D.Name  FROM Employees AS E
Join Departments AS D ON E.DepartmentID = D.DepartmentID
WHERE D.Name = 'Sales'
ORDER  BY EmployeeID ASC

SELECT TOP 5 E.EmployeeID, E.FirstName, E.Salary, D.Name FROM Employees AS E
Join Departments AS D ON E.DepartmentID = D.DepartmentID
WHERE Salary > 15000
ORDER BY E.DepartmentID ASC

SELECT E.EmployeeID, E.FirstName, EP.EmployeeID FROM Employees AS E
Left Join EmployeesProjects AS EP ON E.EmployeeID = EP.EmployeeID
WHERE EP.ProjectID = NULL

SELECT E.FirstName, E.LastName, E.HireDate, D.Name FROM Employees AS E
Join Departments AS D ON E.DepartmentID = D.DepartmentID
WHERE E.HireDate > '1999-01-01'AND D.Name = 'Sales' OR D.Name = 'Finance'
ORDER BY E.HireDate ASC

SELECT TOP 5 E.EmployeeID , E.EmployeeID, E.FirstName, P.Name FROM Employees AS E 
Join EmployeesProjects AS EP ON E.EmployeeID = EP.EmployeeID
Join Projects AS P ON EP.EmployeeID = P.ProjectID
WHERE P.StartDate > '2002-08-13'
ORDER BY E.EmployeeID ASC

SELECT E.EmployeeID, E.FirstName, P.Name FROM Employees AS E
Join EmployeesProjects AS EP ON E.EmployeeID = EP.EmployeeID
Join Projects AS P ON P.ProjectID = EP.ProjectID
WHERE E.EmployeeID = 24 AND P.StartDate >= '2005'

SELECT E.EmployeeID, E.FirstName, E.LastName, M.FirstName, M.LastName  FROM Employees AS E
Join Employees AS M ON E.ManagerID = M.EmployeeID
WHERE M.ManagerID >= 3 OR M.ManagerID >= 7
ORDER BY E.EmployeeID ASC

SELECT AVG(Salary) AS AverageSalary
FROM Employees



