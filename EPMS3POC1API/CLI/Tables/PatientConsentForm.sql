﻿CREATE TABLE [CLI].[PatientConsentForm] (
    [PatientConsentFormId] BIGINT         IDENTITY (1, 1) NOT NULL,
    [PatientId]            BIGINT         NOT NULL,
    [FormType]             NVARCHAR (100) NULL,
    [Notes]                NVARCHAR (1)   NULL,
    [AreaofMouth]          NVARCHAR (100) NULL,
    [DateofService]        DATETIME       NULL,
    [ConsentStatus]        NVARCHAR (100) NULL,
    [IsSigned]             SMALLINT       NULL,
    [SignaturePath]        NVARCHAR (200) NULL,
    [DocumentTitle]        NVARCHAR (200) NULL,
    [DocumentDescription]  NVARCHAR (1)   NULL,
    [UploadedForm]         NVARCHAR (1)   NULL,
    [ConsentDate]          DATETIME       NULL,
    [FacilityId]           BIGINT         NULL,
    [DocumentTypeId]       BIGINT         NULL,
    [EmployeeId]           BIGINT         NULL,
    [CreatedDateTime]      DATETIME       NOT NULL,
    [ModifiedDateTime]     DATETIME       NOT NULL,
    [CreatedByUser]        VARCHAR (80)   NOT NULL,
    [ModifiedByUser]       VARCHAR (80)   NULL,
    [CreatedByProgram]     VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]    VARCHAR (80)   NULL,
    [RecordStatus]         INT            NOT NULL,
    [ConsentFormId]        BIGINT         NULL,
    CONSTRAINT [PK_PatientConsentForms] PRIMARY KEY CLUSTERED ([PatientConsentFormId] ASC),
    CONSTRAINT [R_383] FOREIGN KEY ([PatientId]) REFERENCES [PER].[Patient] ([PatientId]),
    CONSTRAINT [R_483] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId]),
    CONSTRAINT [R_485] FOREIGN KEY ([DocumentTypeId]) REFERENCES [CLI].[DocumentType] ([DocumentTypeId]),
    CONSTRAINT [R_494] FOREIGN KEY ([EmployeeId]) REFERENCES [FAC].[Employee] ([EmployeeId]),
    CONSTRAINT [R_906] FOREIGN KEY ([ConsentFormId]) REFERENCES [CLI].[ConsentForm] ([ConsentFormId])
);
