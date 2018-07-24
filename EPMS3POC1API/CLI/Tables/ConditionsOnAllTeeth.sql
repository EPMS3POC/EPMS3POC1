CREATE TABLE [CLI].[ConditionsOnAllTeeth] (
    [ConditionsOnAllTeethId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [ConditionsOnAllTeethDescription] VARCHAR (1024) NULL,
    [ConditionsOnAllTeethCode]        CHAR (5)       NULL,
    [ConditionsOnAllTeethName]        VARCHAR (40)   NULL,
    [CreatedDateTime]                 DATETIME       NOT NULL,
    [ModifiedDateTime]                DATETIME       NOT NULL,
    [CreatedByUser]                   VARCHAR (80)   NOT NULL,
    [ModifiedByUser]                  VARCHAR (80)   NULL,
    [CreatedByProgram]                VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]               VARCHAR (80)   NULL,
    [RecordStatus]                    INT            NOT NULL,
    CONSTRAINT [PK_ConditionsOnAllTeeth] PRIMARY KEY CLUSTERED ([ConditionsOnAllTeethId] ASC)
);

