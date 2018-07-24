CREATE TABLE [FAC].[CouponAdjustment] (
    [CouponAdjustmentId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CouponAdjustmentDescription] VARCHAR (1024) NULL,
    [CouponAdjustmentCode]        CHAR (5)       NULL,
    [CouponAdjustmentName]        VARCHAR (40)   NULL,
    [CreatedDateTime]             DATETIME       NOT NULL,
    [ModifiedDateTime]            DATETIME       NOT NULL,
    [CreatedByUser]               VARCHAR (80)   NOT NULL,
    [ModifiedByUser]              VARCHAR (80)   NULL,
    [CreatedByProgram]            VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]           VARCHAR (80)   NULL,
    [RecordStatus]                INT            NOT NULL,
    CONSTRAINT [XPKCouponAdjustment] PRIMARY KEY CLUSTERED ([CouponAdjustmentId] ASC)
);

