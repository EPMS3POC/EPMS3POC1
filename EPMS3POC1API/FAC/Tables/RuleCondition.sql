CREATE TABLE [FAC].[RuleCondition] (
    [RuleConditionId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [RuleConditionDescription] VARCHAR (1024) NULL,
    [RuleConditionCode]        CHAR (5)       NULL,
    [RuleConditionName]        VARCHAR (40)   NULL,
    [CreatedDateTime]          DATETIME       NOT NULL,
    [ModifiedDateTime]         DATETIME       NOT NULL,
    [CreatedByUser]            VARCHAR (80)   NOT NULL,
    [ModifiedByUser]           VARCHAR (80)   NULL,
    [CreatedByProgram]         VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]        VARCHAR (80)   NULL,
    [RecordStatus]             INT            NOT NULL,
    CONSTRAINT [XPKRuleCondition] PRIMARY KEY CLUSTERED ([RuleConditionId] ASC)
);

