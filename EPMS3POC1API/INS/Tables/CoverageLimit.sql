CREATE TABLE [INS].[CoverageLimit] (
    [CoverageLimitId]       BIGINT       IDENTITY (1, 1) NOT NULL,
    [LimitAmount]           MONEY        NULL,
    [UsedAmount]            MONEY        NULL,
    [RemainingAmount]       MONEY        NULL,
    [CoverageNetworkTypeId] BIGINT       NULL,
    [CoveragePlanTypeId]    BIGINT       NULL,
    [CoverageLimitTypeId]   BIGINT       NULL,
    [CoverageBookId]        BIGINT       NULL,
    [CreatedDateTime]       DATETIME     NOT NULL,
    [ModifiedDateTime]      DATETIME     NOT NULL,
    [CreatedByUser]         VARCHAR (80) NOT NULL,
    [ModifiedByUser]        VARCHAR (80) NULL,
    [CreatedByProgram]      VARCHAR (80) NOT NULL,
    [ModifiedByProgram]     VARCHAR (80) NULL,
    [RecordStatus]          INT          NOT NULL,
    CONSTRAINT [XPKCoverageLimit] PRIMARY KEY CLUSTERED ([CoverageLimitId] ASC),
    CONSTRAINT [R_739] FOREIGN KEY ([CoverageNetworkTypeId]) REFERENCES [INS].[CoverageNetworkType] ([CoverageNetworkTypeId]),
    CONSTRAINT [R_740] FOREIGN KEY ([CoveragePlanTypeId]) REFERENCES [INS].[CoveragePlanType] ([CoveragePlanTypeId]),
    CONSTRAINT [R_741] FOREIGN KEY ([CoverageLimitTypeId]) REFERENCES [INS].[CoverageLimitType] ([CoverageLimitTypeId]),
    CONSTRAINT [R_742] FOREIGN KEY ([CoverageBookId]) REFERENCES [INS].[CoverageBook] ([CoverageBookId])
);

