USE Zoo

SELECT V.Name, V.PhoneNumber, V.Address FROM Volunteers AS V
Join VolunteerDepartments AS VD ON V.DepartmentId = VD.Id
WHERE VD.DepartmentName = 'Education program assistant' 
AND V.Address LIKE '%, Sofia'
ORDER BY V.Name ASC

SELECT A.Name, A.BirthDate, ATY.AnimalType FROM Animals AS A
Join AnimalTypes AS ATY ON ATY.Id = A.AnimalTypeId
WHERE A.OwnerId = NULL AND A.BirthDate >= '01/01/2022'
ORDER BY A.Name

GO

CREATE FUNCTION udf_GetVolunteersCountFromADepartment (@VolunteersDepartment NVARCHAR(255))
RETURNS INT 
AS
BEGIN 
	DECLARE @VOLUNTEERCOUNT INT;
	
	SELECT @VOLUNTEERCOUNT = COUNT(*)
	FROM Volunteers AS V
	Join VolunteersDepartments AS VD ON VD.Id = V.DepartmentId
	WHERE VD.DepartmentName = @VolunteersDepartment;

	RETURN @VOLUNTEERCOUNT;

END

GO

SELECT dbo.udf_GetVolunteersCountFromADepartment('Education program assistant') AS VOLCOUNT;

GO

CREATE PROC usp_AnimalsWithOwnersOrNot(@AnimalName NVARCHAR(255))
AS
SELECT A.Name, ISNULL(O.Name, 'For Adoption') AS OwnerName FROM Animals AS A
Left Join Owners AS O ON O.Id = A.OwnerId
Where A.Name = @AnimalName

GO

EXEC dbo.usp_AnimalsWithOwnersOrNot 'Pumpkinseed Sunfish' 



