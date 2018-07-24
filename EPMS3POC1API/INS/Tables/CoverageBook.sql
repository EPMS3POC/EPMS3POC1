CREATE TABLE [INS].[CoverageBook] (
    [CoverageBookId]     BIGINT       IDENTITY (1, 1) NOT NULL,
    [InsuranceId]        BIGINT       NULL,
    [PatientId]          BIGINT       NULL,
    [SubscriberId]       BIGINT       NULL,
    [CoverageName]       NVARCHAR (1) NULL,
    [PlanName]           NVARCHAR (1) NULL,
    [CreatedDateTime]    DATETIME     NOT NULL,
    [ModifiedDateTime]   DATETIME     NOT NULL,
    [CreatedByUser]      VARCHAR (80) NOT NULL,
    [ModifiedByUser]     VARCHAR (80) NULL,
    [CreatedByProgram]   VARCHAR (80) NOT NULL,
    [ModifiedByProgram]  VARCHAR (80) NULL,
    [RecordStatus]       INT          NOT NULL,
    [InsurancePayerId]   BIGINT       NULL,
    [CoverageBookTypeId] BIGINT       NULL,
    CONSTRAINT [XPKCoverageBook] PRIMARY KEY CLUSTERED ([CoverageBookId] ASC),
    CONSTRAINT [R_736] FOREIGN KEY ([InsuranceId]) REFERENCES [INS].[Insurance] ([InsuranceId]),
    CONSTRAINT [R_737] FOREIGN KEY ([PatientId]) REFERENCES [PER].[Patient] ([PatientId]),
    CONSTRAINT [R_738] FOREIGN KEY ([SubscriberId]) REFERENCES [ACC].[Subscriber] ([SubscriberId]),
    CONSTRAINT [R_757] FOREIGN KEY ([InsurancePayerId]) REFERENCES [INS].[InsurancePayer] ([InsurancePayerId]),
    CONSTRAINT [R_758] FOREIGN KEY ([CoverageBookTypeId]) REFERENCES [INS].[CoverageBookType] ([CoverageBookTypeId])
);

