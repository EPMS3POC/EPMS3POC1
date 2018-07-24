
CREATE Procedure [dbo].[GetPatientPerson]
AS

BEGIN
--Use [EPMS3POC1]
Select Distinct
p.PersonId, --as [Id],
p.FirstName, -- as [First Name],
p.LastName, -- as [Last Name],
p.BirthDate, -- as [Date of Birth],
g.GenderName, -- as [Sex],
p.SocialSecurityNumber, -- as [SSN],
rt.RelationshipTypeName, -- as [Relationship to Reponsible Party],
f.FacilityName, -- as [Facility],
a.AppointmentDate, -- as [Next Appt],
p.RecordStatus -- as [Record Status]

FROM 
--GenderName g ON [PER].[Person].[GenderId] = [PER].[Gender].[GenderId
[PER].[Person] p
INNER JOIN [PER].[Gender] g ON g.[GenderId] = p.[GenderId]
INNER JOIN [PER].[Relationship] r ON r.[PersonId] = p.[PersonId]
INNER JOIN [PER].[RelationshipType] rt ON rt.[RelationShipTypeId] = r.[RelationShipTypeId]
INNER JOIN [USR].[User] u ON u.[UserId] = p.[UserId]
INNER JOIN [FAC].[Facility] f ON f.[FacilityId] = u.[FacilityId]
INNER JOIN [TRE].[PatientTreatmentPlan] ptp ON ptp.[PatientId] = r.[PatientId]
INNER JOIN [SCH].[Visit] v ON v.[PatientTreatmentPlanId] = ptp.[PatientTreatmentPlanId]
INNER JOIN [SCH].[Appointment] a ON a.[VisitId] = v.[VisitId]
AND a.AppointmentDate = (Select max(a.AppointmentDate) from [SCH].[Appointment] a WHERE a.[VisitId] = v.[VisitId])
AND rt.RelationshipTypeName = 'Self'
END
-------------------------------------------------------------------------------
