CREATE TABLE [CLI].[ConsentForm] (
    [ConsentFormId]     BIGINT         IDENTITY (1, 1) NOT NULL,
    [FormType]          NVARCHAR (100) NULL,
    [Notes]             NVARCHAR (1)   NULL,
    [AreaofMouth]       SMALLINT       NULL,
    [DateofService]     SMALLINT       NULL,
    [FacilityId]        BIGINT         NULL,
    [EmployeeId]        BIGINT         NULL,
    [CreatedDateTime]   DATETIME       NOT NULL,
    [ModifiedDateTime]  DATETIME       NOT NULL,
    [CreatedByUser]     VARCHAR (80)   NOT NULL,
    [ModifiedByUser]    VARCHAR (80)   NULL,
    [CreatedByProgram]  VARCHAR (80)   NOT NULL,
    [ModifiedByProgram] VARCHAR (80)   NULL,
    [RecordStatus]      INT            NOT NULL,
    CONSTRAINT [PK_ConsentForms] PRIMARY KEY CLUSTERED ([ConsentFormId] ASC),
    CONSTRAINT [R_388] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId]),
    CONSTRAINT [R_621] FOREIGN KEY ([EmployeeId]) REFERENCES [FAC].[Employee] ([EmployeeId])
);

