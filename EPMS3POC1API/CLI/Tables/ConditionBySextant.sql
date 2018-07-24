CREATE TABLE [CLI].[ConditionBySextant] (
    [ConditionBySextantId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [ConditionBySextantDescription] VARCHAR (1024) NULL,
    [ConditionBySextantCode]        CHAR (5)       NULL,
    [ConditionBySextantName]        VARCHAR (40)   NULL,
    [CreatedDateTime]               DATETIME       NOT NULL,
    [ModifiedDateTime]              DATETIME       NOT NULL,
    [CreatedByUser]                 VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                VARCHAR (80)   NULL,
    [CreatedByProgram]              VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]             VARCHAR (80)   NULL,
    [RecordStatus]                  INT            NOT NULL,
    CONSTRAINT [PK_ConditionBySextant] PRIMARY KEY CLUSTERED ([ConditionBySextantId] ASC)
);

