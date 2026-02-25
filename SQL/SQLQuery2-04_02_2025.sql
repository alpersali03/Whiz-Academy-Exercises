--Create a stored procedure usp_GetTownsStartingWith 
--that accepts a string as parameter and returns 
--all town names starting with that string.
USE Whiz

GO

CREATE PROC  sp_GetTownsStartingWith(@value varchar(70))
AS
SELECT T.Name
FROM Towns AS T
WHERE T.Name LIKE @value + '%'

EXEC dbo.sp_GetTownsStartingWith 'S'
