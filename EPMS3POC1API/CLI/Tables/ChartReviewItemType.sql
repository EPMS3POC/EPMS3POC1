CREATE TABLE [CLI].[ChartReviewItemType] (
    [ChartReviewItemTypeId]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [ChartReviewItemTypeName] NVARCHAR (50) NULL,
    [CreatedDateTime]         DATETIME      NOT NULL,
    [ModifiedDateTime]        DATETIME      NOT NULL,
    [CreatedByUser]           VARCHAR (80)  NOT NULL,
    [ModifiedByUser]          VARCHAR (80)  NULL,
    [CreatedByProgram]        VARCHAR (80)  NOT NULL,
    [ModifiedByProgram]       VARCHAR (80)  NULL,
    [RecordStatus]            INT           NOT NULL,
    [ChartReviewCategoryId]   BIGINT        NULL,
    CONSTRAINT [PK_ChartReviewItemType] PRIMARY KEY CLUSTERED ([ChartReviewItemTypeId] ASC),
    CONSTRAINT [R_894] FOREIGN KEY ([ChartReviewCategoryId]) REFERENCES [CLI].[ChartReviewCategory] ([ChartReviewCategoryId])
);

