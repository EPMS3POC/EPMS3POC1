CREATE TABLE [FAC].[CouponStatus] (
    [CouponStatusId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CouponStatusDescription] VARCHAR (1024) NULL,
    [CouponStatusCode]        CHAR (5)       NULL,
    [CouponStatusName]        VARCHAR (40)   NULL,
    [CreatedDateTime]         DATETIME       NOT NULL,
    [ModifiedDateTime]        DATETIME       NOT NULL,
    [CreatedByUser]           VARCHAR (80)   NOT NULL,
    [ModifiedByUser]          VARCHAR (80)   NULL,
    [CreatedByProgram]        VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]       VARCHAR (80)   NULL,
    [RecordStatus]            INT            NOT NULL,
    CONSTRAINT [XPKCouponStatus] PRIMARY KEY CLUSTERED ([CouponStatusId] ASC)
);

