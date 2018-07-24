CREATE TABLE [FAC].[DemographicRule] (
    [DemographicRuleId]  BIGINT       IDENTITY (1, 1) NOT NULL,
    [RuleConditionId]    BIGINT       NULL,
    [RuleOperatorId]     BIGINT       NULL,
    [CouponId]           BIGINT       NULL,
    [DemographicFieldId] BIGINT       NULL,
    [RuleValueCode]      VARCHAR (20) NULL,
    [CreatedDateTime]    DATETIME     NOT NULL,
    [ModifiedDateTime]   DATETIME     NOT NULL,
    [CreatedByUser]      VARCHAR (80) NOT NULL,
    [ModifiedByUser]     VARCHAR (80) NULL,
    [CreatedByProgram]   VARCHAR (80) NOT NULL,
    [ModifiedByProgram]  VARCHAR (80) NULL,
    [RecordStatus]       INT          NOT NULL,
    CONSTRAINT [XPKDemographicRule] PRIMARY KEY CLUSTERED ([DemographicRuleId] ASC),
    CONSTRAINT [R_641] FOREIGN KEY ([RuleConditionId]) REFERENCES [FAC].[RuleCondition] ([RuleConditionId]),
    CONSTRAINT [R_642] FOREIGN KEY ([RuleOperatorId]) REFERENCES [FAC].[RuleOperator] ([RuleOperatorId]),
    CONSTRAINT [R_643] FOREIGN KEY ([CouponId]) REFERENCES [FAC].[Coupon] ([CouponId]),
    CONSTRAINT [R_645] FOREIGN KEY ([DemographicFieldId]) REFERENCES [FAC].[DemographicField] ([DemographicFieldId])
);

