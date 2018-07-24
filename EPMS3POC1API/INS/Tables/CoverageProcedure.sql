CREATE TABLE [INS].[CoverageProcedure] (
    [CoverageProcedureId]     BIGINT       IDENTITY (1, 1) NOT NULL,
    [Note]                    NVARCHAR (1) NULL,
    [CoverageNetworkTypeId]   BIGINT       NULL,
    [IsCovered]               INT          NULL,
    [ProcedureCodeCategoryId] BIGINT       NULL,
    [CoverageBookId]          BIGINT       NULL,
    [CreatedDateTime]         DATETIME     NOT NULL,
    [ModifiedDateTime]        DATETIME     NOT NULL,
    [CreatedByUser]           VARCHAR (80) NOT NULL,
    [ModifiedByUser]          VARCHAR (80) NULL,
    [CreatedByProgram]        VARCHAR (80) NOT NULL,
    [ModifiedByProgram]       VARCHAR (80) NULL,
    [RecordStatus]            INT          NOT NULL,
    CONSTRAINT [XPKCoverageProcedure] PRIMARY KEY CLUSTERED ([CoverageProcedureId] ASC),
    CONSTRAINT [R_744] FOREIGN KEY ([CoverageNetworkTypeId]) REFERENCES [INS].[CoverageNetworkType] ([CoverageNetworkTypeId]),
    CONSTRAINT [R_745] FOREIGN KEY ([ProcedureCodeCategoryId]) REFERENCES [INS].[ProcedureCodeCategory] ([ProcedureCodeCategoryId]),
    CONSTRAINT [R_746] FOREIGN KEY ([CoverageBookId]) REFERENCES [INS].[CoverageBook] ([CoverageBookId])
);

