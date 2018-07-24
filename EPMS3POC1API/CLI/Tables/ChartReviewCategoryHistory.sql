CREATE TABLE [CLI].[ChartReviewCategoryHistory] (
    [ChartReviewCategoryHistoryId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [CreatedDateTime]              DATETIME     NOT NULL,
    [ModifiedDateTime]             DATETIME     NOT NULL,
    [CreatedByUser]                VARCHAR (80) NOT NULL,
    [ModifiedByUser]               VARCHAR (80) NULL,
    [CreatedByProgram]             VARCHAR (80) NOT NULL,
    [ModifiedByProgram]            VARCHAR (80) NULL,
    [RecordStatus]                 INT          NOT NULL,
    [ChartReviewStatusId]          BIGINT       NULL,
    [PatientChartReviewId]         BIGINT       NULL,
    [ChartReviewCategoryId]        BIGINT       NULL,
    CONSTRAINT [PK_ChartReviewHistory] PRIMARY KEY CLUSTERED ([ChartReviewCategoryHistoryId] ASC),
    CONSTRAINT [R_890] FOREIGN KEY ([ChartReviewStatusId]) REFERENCES [CLI].[ChartReviewStatus] ([ChartReviewStatusId]),
    CONSTRAINT [R_892] FOREIGN KEY ([PatientChartReviewId]) REFERENCES [CLI].[PatientChartReview] ([PatientChartReviewId]),
    CONSTRAINT [R_893] FOREIGN KEY ([ChartReviewCategoryId]) REFERENCES [CLI].[ChartReviewCategory] ([ChartReviewCategoryId])
);

