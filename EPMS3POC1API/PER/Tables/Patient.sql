CREATE TABLE [PER].[Patient] (
    [PatientId]                 BIGINT       IDENTITY (1, 1) NOT NULL,
    [PatientDoseSpotIdentifier] INT          NULL,
    [CreatedDateTime]           DATETIME     NOT NULL,
    [ModifiedDateTime]          DATETIME     NOT NULL,
    [CreatedByUser]             VARCHAR (80) NOT NULL,
    [ModifiedByUser]            VARCHAR (80) NULL,
    [CreatedByProgram]          VARCHAR (80) NOT NULL,
    [ModifiedByProgram]         VARCHAR (80) NULL,
    [RecordStatus]              INT          NOT NULL,
    [AccountId]                 BIGINT       NOT NULL,
    [PatientCode]               VARCHAR (20) NULL,
    CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED ([PatientId] ASC),
    CONSTRAINT [R_908] FOREIGN KEY ([AccountId]) REFERENCES [ACC].[Account] ([AccountId])
);

