CREATE TABLE [CLI].[DocumentMapping] (
    [DocumentMappingId]     BIGINT       IDENTITY (1, 1) NOT NULL,
    [DocumentCategoryId]    BIGINT       NOT NULL,
    [StateId]               BIGINT       NULL,
    [TemplateId]            VARCHAR (1)  NULL,
    [FacilityId]            BIGINT       NULL,
    [CreatedDateTime]       DATETIME     NOT NULL,
    [ModifiedDateTime]      DATETIME     NOT NULL,
    [CreatedByUser]         VARCHAR (80) NOT NULL,
    [ModifiedByUser]        VARCHAR (80) NULL,
    [CreatedByProgram]      VARCHAR (80) NOT NULL,
    [ModifiedByProgram]     VARCHAR (80) NULL,
    [RecordStatus]          INT          NOT NULL,
    [PatientNoteTemplateId] BIGINT       NULL,
    [EmployeeId]            BIGINT       NULL,
    CONSTRAINT [PK_DocumentMapping] PRIMARY KEY CLUSTERED ([DocumentMappingId] ASC),
    CONSTRAINT [R_392] FOREIGN KEY ([DocumentCategoryId]) REFERENCES [CLI].[DocumentCategory] ([DocumentCategoryId]),
    CONSTRAINT [R_393] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId]),
    CONSTRAINT [R_394] FOREIGN KEY ([StateId]) REFERENCES [PER].[State] ([StateId]),
    CONSTRAINT [R_756] FOREIGN KEY ([PatientNoteTemplateId]) REFERENCES [CLI].[PatientNoteTemplate] ([PatientNoteTemplateId]),
    CONSTRAINT [R_787] FOREIGN KEY ([EmployeeId]) REFERENCES [FAC].[Employee] ([EmployeeId])
);

