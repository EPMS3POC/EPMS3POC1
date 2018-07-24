CREATE TABLE [SCH].[ReviewReason] (
    [ReviewReasonId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [ReviewReasonDescription] VARCHAR (1024) NULL,
    [ReviewReasonCode]        CHAR (5)       NULL,
    [ReviewReasonName]        VARCHAR (40)   NULL,
    [CreatedDateTime]         DATETIME       NOT NULL,
    [ModifiedDateTime]        DATETIME       NOT NULL,
    [CreatedByUser]           VARCHAR (80)   NOT NULL,
    [ModifiedByUser]          VARCHAR (80)   NULL,
    [CreatedByProgram]        VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]       VARCHAR (80)   NULL,
    [RecordStatus]            INT            NOT NULL,
    CONSTRAINT [XPKReviewReason] PRIMARY KEY CLUSTERED ([ReviewReasonId] ASC)
);

