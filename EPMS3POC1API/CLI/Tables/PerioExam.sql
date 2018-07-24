CREATE TABLE [CLI].[PerioExam] (
    [PerioExamId]       BIGINT       IDENTITY (1, 1) NOT NULL,
    [PerioExamNumber]   BIGINT       NULL,
    [PerioExamDate]     DATETIME     NULL,
    [FlossingsPerDay]   INT          NULL,
    [BrushesPerDay]     INT          NULL,
    [EmployeeId]        BIGINT       NULL,
    [PatientId]         BIGINT       NULL,
    [Diagnosis]         VARCHAR (50) NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKPerioExam] PRIMARY KEY CLUSTERED ([PerioExamId] ASC),
    CONSTRAINT [R_773] FOREIGN KEY ([EmployeeId]) REFERENCES [FAC].[Employee] ([EmployeeId]),
    CONSTRAINT [R_774] FOREIGN KEY ([PatientId]) REFERENCES [PER].[Patient] ([PatientId])
);

