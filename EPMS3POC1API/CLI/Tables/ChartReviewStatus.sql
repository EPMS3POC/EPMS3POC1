﻿CREATE TABLE [CLI].[ChartReviewStatus] (
    [ChartReviewStatusId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [ChartReviewStatusDescription] VARCHAR (1024) NULL,
    [ChartReviewStatusCode]        CHAR (5)       NULL,
    [ChartReviewStatusName]        VARCHAR (50)   NULL,
    [CreatedDateTime]              DATETIME       NOT NULL,
    [ModifiedDateTime]             DATETIME       NOT NULL,
    [CreatedByUser]                VARCHAR (80)   NOT NULL,
    [ModifiedByUser]               VARCHAR (80)   NULL,
    [CreatedByProgram]             VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]            VARCHAR (80)   NULL,
    [RecordStatus]                 INT            NOT NULL,
    CONSTRAINT [PK_ChartReviewCategoryStatus] PRIMARY KEY CLUSTERED ([ChartReviewStatusId] ASC)
);

