CREATE TABLE [SCH].[ChartAuditStatus] (
    [ChartAuditStatusId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [ChartAuditStatusDescription] VARCHAR (1024) NULL,
    [ChartAuditStatusCode]        CHAR (5)       NULL,
    [ChartAuditStatusName]        VARCHAR (40)   NULL,
    [CreatedDateTime]             DATETIME       NOT NULL,
    [ModifiedDateTime]            DATETIME       NOT NULL,
    [CreatedByUser]               VARCHAR (80)   NOT NULL,
    [ModifiedByUser]              VARCHAR (80)   NULL,
    [CreatedByProgram]            VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]           VARCHAR (80)   NULL,
    [RecordStatus]                INT            NOT NULL,
    CONSTRAINT [XPKChartAuditStatus] PRIMARY KEY CLUSTERED ([ChartAuditStatusId] ASC)
);

