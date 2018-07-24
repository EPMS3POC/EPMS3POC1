CREATE TABLE [CLI].[ChartReviewItemHistory] (
    [ChartReviewItemHistoryId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [ChartReviewStatusId]      BIGINT       NOT NULL,
    [PatientId]                BIGINT       NULL,
    [CreatedDateTime]          DATETIME     NOT NULL,
    [ModifiedDateTime]         DATETIME     NOT NULL,
    [CreatedByUser]            VARCHAR (80) NOT NULL,
    [ModifiedByUser]           VARCHAR (80) NULL,
    [CreatedByProgram]         VARCHAR (80) NOT NULL,
    [ModifiedByProgram]        VARCHAR (80) NULL,
    [RecordStatus]             INT          NOT NULL,
    [PatientChartReviewId]     BIGINT       NULL,
    [ChartReviewItemTypeId]    BIGINT       NULL,
    CONSTRAINT [PK_ChartReviewItemHistory] PRIMARY KEY CLUSTERED ([ChartReviewItemHistoryId] ASC),
    CONSTRAINT [R_366] FOREIGN KEY ([PatientId]) REFERENCES [PER].[Patient] ([PatientId]),
    CONSTRAINT [R_862] FOREIGN KEY ([ChartReviewStatusId]) REFERENCES [CLI].[ChartReviewStatus] ([ChartReviewStatusId]),
    CONSTRAINT [R_891] FOREIGN KEY ([PatientChartReviewId]) REFERENCES [CLI].[PatientChartReview] ([PatientChartReviewId]),
    CONSTRAINT [R_895] FOREIGN KEY ([ChartReviewItemTypeId]) REFERENCES [CLI].[ChartReviewItemType] ([ChartReviewItemTypeId])
);

