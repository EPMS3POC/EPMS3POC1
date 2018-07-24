
CREATE Procedure [dbo].[GetPatientAccount]
AS

BEGIN
	Select
	a.AccountId, -- as [AccountId]
	a.AccountNumber, --as [Account Number]
	p.FirstName, -- as [First Name],
	p.MiddleName, -- as [Middel Name],
	p.LastName, -- as [Last Name],
	s.SuffixName, -- as [Suffix],
	p.SocialSecurityNumber, -- as [SSN],
	p.BirthDate, -- as [Date of Birth],
	DATEDIFF(YEAR,p.BirthDate, GetDate()) as [Age] ,  --  as age From Person,
	g.GenderName, -- as [Sex],
	rt.RelationshipTypeName, -- as [Relationship to Reponsible Party],
	f.FacilityName, -- as [Facility],
	a.AccountGroup, -- [Account Type], "Self Pay"
	ast.AccountStatusCode, -- as [Record Status]
	'('+ph.AreaCode+')'+' - '+ph.NXX+'-'+ph.Line+' ' + CASE WHEN ph.Extension is NULL then '' else 'X'+ph.Extension end AS [HomePhone] , --p.--[Home Phone]
	'admin@aspendental.com' as [Email] --not in the database yet*/

	FROM 
	[ACC].[Account] a
	INNER JOIN [ACC].[AccountStatus] ast ON ast.[AccountStatusId] = a.[AccountStatusId]
	INNER JOIN [PER].[Patient] pa ON  pa.[AccountId] = a.[AccountId]
	INNER JOIN [PER].[Relationship] r ON r.[PatientId] = pa.[PatientId]
	INNER JOIN [PER].[Person] p ON r.[PersonId] = p.[PersonId] 
	INNER JOIN [PER].[Gender] g ON g.[GenderId] = p.[GenderId]
	LEFT JOIN [PER].[Suffix] s ON s.[SuffixId] = p.[SuffixId] -- LEFT Join when child tables can have nulls.
	INNER JOIN [PER].[PersonPhone] perph ON perph.[PersonId] = p.[PersonId]
	INNER JOIN [PER].[Phone] ph ON ph.[PhoneId] = perph.[PhoneId]
	INNER JOIN [PER].[PersonAddress] pad ON pad.[PersonId] = p.[PersonId]
	INNER JOIN [PER].[Address] ad ON ad.[AddressId] = pad.[AddressId]
	INNER JOIN [PER].[County] co ON co.[CountyId] = ad.[CountyId]
	INNER JOIN [PER].[City] c ON c.[CityId] = ad.[CityId]
	INNER JOIN [PER].[State] st ON st.[StateId] = ad.[StateId]
	INNER JOIN [PER].[ZipCode] z ON z.[ZipCodeId] = ad.[ZipCodeId]
	INNER JOIN [PER].[Country] con ON con.[CountryId] = z.[CountryId]
	INNER JOIN [PER].[RelationshipType] rt ON rt.[RelationShipTypeId] = r.[RelationShipTypeId]
	INNER JOIN [USR].[User] u ON u.[UserId] = p.[UserId]
	INNER JOIN [FAC].[Facility] f ON f.[FacilityId] = u.[FacilityId]
	AND rt.RelationshipTypeName = 'Self'
END


/*
Select DATEDIFF(YEAR,year(CONVERT(DATETIME, p.BirthDate)), year(GetDate())) FROm [PER].[Person] p

Select YEAR(CONVERT(DATETIME, p.BirthDate)) -YEAR(GetDate()) FROm [PER].[Person] p

Select p.BirthDate, GetDate() FROm [PER].[Person] p

Truncate Table [PER].[Person]

UPDATE [PER].[PERSON] SET [Birthdate] = (SELECT DATEADD(YEAR, -FLOOR(RAND()*(50-10)+5) , GETDATE())) 

SELECT  DATEADD(YEAR, SELECT FLOOR(RAND()*(50-10)+5) , GETDATE()) as Datetime

DATEADD(YEAR,  , GETDATE());

SELECT  DATEADD(YEAR, FLOOR(RAND()*(50-10)+5) , GETDATE())

WHILE 1 = 1
BEGIN;
UPDATE [PER].[PERSON]
     SET [Birthdate] = DATEADD(YEAR, -FLOOR(RAND()*(50-10)+5) , GETDATE())
	 WHERE PersonID = CONVERT(INT, @@rowcount);

IF @@rowcount < 101 BREAK;


END;

WHILE @@ROWCOUNT > 0

  BEGIN

    UPDATE [PER].[PERSON]

   SET [Birthdate] = DATEADD(YEAR, -FLOOR(RAND()*(50-10)+5) , GETDATE())

    FROM   [PER].[PERSON] WHERE PersonId = @@ROWCOUNT


END

DECLARE @a INT; 
DECLARE @b DATETIME;

SET @a = 81;
WHILE @a < 100
 BEGIN;
set @b = DATEADD(YEAR, -(@a + 20) , GETDATE())

PRINT @b;
 
  PRINT @b;
      UPDATE [PER].[PERSON] SET [Birthdate] = @b
      WHERE PersonId = @a
    SET @a = @a + 1;
END;

EXECUTE [dbo].[GetPatientAccount]

Select * from PER.Person
Select * from PER.PersonPhone
Select * from PER.Phone

UPDATE PER.PersonPhone SET PhoneId = PersonPhoneId*/