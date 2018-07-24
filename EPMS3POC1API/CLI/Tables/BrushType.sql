CREATE TABLE [CLI].[BrushType] (
    [BrushTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [BrushTypeDescription] VARCHAR (1024) NULL,
    [BrushTypeCode]        CHAR (5)       NULL,
    [BrushTypeName]        VARCHAR (40)   NULL,
    [CreatedDateTime]      DATETIME       NOT NULL,
    [ModifiedDateTime]     DATETIME       NOT NULL,
    [CreatedByUser]        VARCHAR (80)   NOT NULL,
    [ModifiedByUser]       VARCHAR (80)   NULL,
    [CreatedByProgram]     VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]    VARCHAR (80)   NULL,
    [RecordStatus]         INT            NOT NULL,
    CONSTRAINT [PK_BrushType] PRIMARY KEY CLUSTERED ([BrushTypeId] ASC)
);

