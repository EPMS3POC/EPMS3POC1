CREATE TABLE [FAC].[RuleOperator] (
    [RuleOperatorId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [RuleOperatorDescription] VARCHAR (1024) NULL,
    [RuleOperatorCode]        VARCHAR (5)    NULL,
    [RuleOperatorName]        VARCHAR (32)   NULL,
    [CreatedDateTime]         DATETIME       NOT NULL,
    [ModifiedDateTime]        DATETIME       NOT NULL,
    [CreatedByUser]           VARCHAR (80)   NOT NULL,
    [ModifiedByUser]          VARCHAR (80)   NULL,
    [CreatedByProgram]        VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]       VARCHAR (80)   NULL,
    [RecordStatus]            INT            NOT NULL,
    CONSTRAINT [XPKRuleOperator] PRIMARY KEY CLUSTERED ([RuleOperatorId] ASC)
);

