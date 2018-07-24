CREATE TABLE [CLI].[ToothType] (
    [ToothTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [ToothTypeDescription] VARCHAR (1024) NULL,
    [ToothTypeCode]        CHAR (5)       NULL,
    [ToothTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]      DATETIME       NOT NULL,
    [ModifiedDateTime]     DATETIME       NOT NULL,
    [CreatedByUser]        VARCHAR (80)   NOT NULL,
    [ModifiedByUser]       VARCHAR (80)   NULL,
    [CreatedByProgram]     VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]    VARCHAR (80)   NULL,
    [RecordStatus]         INT            NOT NULL,
    CONSTRAINT [PK_ToothType] PRIMARY KEY CLUSTERED ([ToothTypeId] ASC)
);

