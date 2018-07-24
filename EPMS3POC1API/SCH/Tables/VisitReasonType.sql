CREATE TABLE [SCH].[VisitReasonType] (
    [VisitReasonTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [IsPriority]                 SMALLINT       NULL,
    [IsForceAllowed]             SMALLINT       NULL,
    [VisitReasonTypeDescription] VARCHAR (1024) NULL,
    [VisitReasonTypeCode]        CHAR (5)       NULL,
    [VisitReasonTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]            DATETIME       NOT NULL,
    [ModifiedDateTime]           DATETIME       NOT NULL,
    [CreatedByUser]              VARCHAR (80)   NOT NULL,
    [ModifiedByUser]             VARCHAR (80)   NULL,
    [CreatedByProgram]           VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]          VARCHAR (80)   NULL,
    [RecordStatus]               INT            NOT NULL,
    CONSTRAINT [XPKVisitReasonType] PRIMARY KEY CLUSTERED ([VisitReasonTypeId] ASC)
);

