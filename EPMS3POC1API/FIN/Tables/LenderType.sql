CREATE TABLE [FIN].[LenderType] (
    [LenderTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [LenderTypeName]        VARCHAR (40)   NULL,
    [LenderTypeDescription] VARCHAR (1024) NULL,
    [LenderTypeCode]        CHAR (5)       NULL,
    [CreatedDateTime]       DATETIME       NOT NULL,
    [ModifiedDateTime]      DATETIME       NOT NULL,
    [CreatedByUser]         VARCHAR (80)   NOT NULL,
    [ModifiedByUser]        VARCHAR (80)   NULL,
    [CreatedByProgram]      VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]     VARCHAR (80)   NULL,
    [RecordStatus]          INT            NOT NULL,
    CONSTRAINT [XPKLenderType] PRIMARY KEY CLUSTERED ([LenderTypeId] ASC)
);

