CREATE TABLE [CLI].[ChartReviewCategory] (
    [ChartReviewCategoryId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [ChartReviewCategoryDescription] VARCHAR (1024) NULL,
    [ChartReviewCategoryCode]        CHAR (5)       NULL,
    [ChartReviewCategoryName]        VARCHAR (50)   NULL,
    [CreatedDateTime]                DATETIME       NOT NULL,
    [ModifiedDateTime]               DATETIME       NOT NULL,
    [CreatedByUser]                  VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                 VARCHAR (80)   NULL,
    [CreatedByProgram]               VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]              VARCHAR (80)   NULL,
    [RecordStatus]                   INT            NOT NULL,
    CONSTRAINT [PK_ChartReviewCategory] PRIMARY KEY CLUSTERED ([ChartReviewCategoryId] ASC)
);

