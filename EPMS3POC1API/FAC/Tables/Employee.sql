CREATE TABLE [FAC].[Employee] (
    [EmployeeId]         BIGINT       IDENTITY (1, 1) NOT NULL,
    [UserId]             BIGINT       NOT NULL,
    [FacilityScheduleId] BIGINT       NULL,
    [CreatedDateTime]    DATETIME     NOT NULL,
    [ModifiedDateTime]   DATETIME     NOT NULL,
    [CreatedByUser]      VARCHAR (80) NOT NULL,
    [ModifiedByUser]     VARCHAR (80) NULL,
    [CreatedByProgram]   VARCHAR (80) NOT NULL,
    [ModifiedByProgram]  VARCHAR (80) NULL,
    [RecordStatus]       INT          NOT NULL,
    [ProviderTypeId]     BIGINT       NULL,
    [EmployeeTypeId]     BIGINT       NULL,
    [FacilityId]         BIGINT       NULL,
    CONSTRAINT [PK_Employee1] PRIMARY KEY CLUSTERED ([EmployeeId] ASC),
    CONSTRAINT [R_293] FOREIGN KEY ([UserId]) REFERENCES [USR].[User] ([UserId]),
    CONSTRAINT [R_849] FOREIGN KEY ([ProviderTypeId]) REFERENCES [FAC].[ProviderType] ([ProviderTypeId]),
    CONSTRAINT [R_860] FOREIGN KEY ([EmployeeTypeId]) REFERENCES [FAC].[EmployeeType] ([EmployeeTypeId]),
    CONSTRAINT [R_914] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId])
);

