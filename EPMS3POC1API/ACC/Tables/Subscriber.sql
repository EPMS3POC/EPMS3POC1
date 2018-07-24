CREATE TABLE [ACC].[Subscriber] (
    [SubscriberId]      BIGINT       IDENTITY (1, 1) NOT NULL,
    [PersonId]          BIGINT       NOT NULL,
    [CoverageTypeId]    BIGINT       NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKSubscriber] PRIMARY KEY CLUSTERED ([SubscriberId] ASC),
    CONSTRAINT [R_312] FOREIGN KEY ([PersonId]) REFERENCES [PER].[Person] ([PersonId]),
    CONSTRAINT [R_440] FOREIGN KEY ([CoverageTypeId]) REFERENCES [INS].[CoverageType] ([CoverageTypeId])
);

