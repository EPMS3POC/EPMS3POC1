CREATE TABLE [FAC].[CouponType] (
    [CouponTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CouponTypeDescription] VARCHAR (1024) NULL,
    [CouponTypeCode]        CHAR (5)       NULL,
    [CouponTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]       DATETIME       NOT NULL,
    [ModifiedDateTime]      DATETIME       NOT NULL,
    [CreatedByUser]         VARCHAR (80)   NOT NULL,
    [ModifiedByUser]        VARCHAR (80)   NULL,
    [CreatedByProgram]      VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]     VARCHAR (80)   NULL,
    [RecordStatus]          INT            NOT NULL,
    CONSTRAINT [XPKCouponType] PRIMARY KEY CLUSTERED ([CouponTypeId] ASC)
);

