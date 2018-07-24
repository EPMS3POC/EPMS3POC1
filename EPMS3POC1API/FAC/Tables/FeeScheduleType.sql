CREATE TABLE [FAC].[FeeScheduleType] (
    [FeeScheduleTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [FeeScheduleTypeDescription] VARCHAR (1024) NULL,
    [FeeScheduleTypeCode]        CHAR (5)       NULL,
    [FeeScheduleTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]            DATETIME       NOT NULL,
    [ModifiedDateTime]           DATETIME       NOT NULL,
    [CreatedByUser]              VARCHAR (80)   NOT NULL,
    [ModifiedByUser]             VARCHAR (80)   NULL,
    [CreatedByProgram]           VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]          VARCHAR (80)   NULL,
    [RecordStatus]               INT            NOT NULL,
    CONSTRAINT [XPKFeeScheduleType] PRIMARY KEY CLUSTERED ([FeeScheduleTypeId] ASC)
);

