﻿(defconventions :domainevents {:inherit [Test.Diesel.IDomainEvent]})

(namespace Test.Diesel.Generated 
	(defvaluetype EmployeeNumber)
	(defvaluetype EmailAddress string)
	(defvaluetype EmployeeName (string FirstName, string LastName))
	(defvaluetype EmployeeMetadata (string Source, int? SourceId))
	(defvaluetype EmployeeRatings (int EmployeeNumber, int[] Ratings))
	(defvaluetype EmployeeRoles (int EmployeeNumber, string[] Roles))
	(defdomainevent EmployeeImported (Guid Id, int EmployeeNumber, string FirstName, string LastName, int? SourceId))
	(defapplicationservice ImportService
		(defcommand ImportEmployee (Guid CommandId, int EmployeeNumber, string FirstName, string LastName, int? SourceId))
		(defcommand ImportConsultant (string FirstName, string LastName, string Company))))

