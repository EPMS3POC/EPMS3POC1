CREATE TABLE [FAC].[Provider] (
    [ProviderId]                  BIGINT       IDENTITY (1, 1) NOT NULL,
    [ProviderDoseSpotClinicianId] VARCHAR (50) NULL,
    [CreatedDateTime]             DATETIME     NOT NULL,
    [ModifiedDateTime]            DATETIME     NOT NULL,
    [CreatedByUser]               VARCHAR (80) NOT NULL,
    [ModifiedByUser]              VARCHAR (80) NULL,
    [CreatedByProgram]            VARCHAR (80) NOT NULL,
    [ModifiedByProgram]           VARCHAR (80) NULL,
    [RecordStatus]                INT          NOT NULL,
    [EmployeeId]                  BIGINT       NOT NULL,
    [NPINumber]                   VARCHAR (20) NULL,
    CONSTRAINT [XPKProvider] PRIMARY KEY CLUSTERED ([ProviderId] ASC),
    CONSTRAINT [R_852] FOREIGN KEY ([EmployeeId]) REFERENCES [FAC].[Employee] ([EmployeeId])
);

