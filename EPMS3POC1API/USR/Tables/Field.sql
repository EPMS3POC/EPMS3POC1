CREATE TABLE [USR].[Field] (
    [FieldId]           BIGINT         IDENTITY (1, 1) NOT NULL,
    [FieldCode]         CHAR (5)       NULL,
    [FieldName]         VARCHAR (40)   NULL,
    [FieldDescription]  VARCHAR (1024) NULL,
    [CreatedDateTime]   DATETIME       NOT NULL,
    [ModifiedDateTime]  DATETIME       NOT NULL,
    [CreatedByUser]     VARCHAR (80)   NOT NULL,
    [ModifiedByUser]    VARCHAR (80)   NULL,
    [CreatedByProgram]  VARCHAR (80)   NOT NULL,
    [ModifiedByProgram] VARCHAR (80)   NULL,
    [RecordStatus]      INT            NOT NULL,
    [ViewId]            BIGINT         NULL,
    CONSTRAINT [PK_Field] PRIMARY KEY CLUSTERED ([FieldId] ASC),
    CONSTRAINT [R_866] FOREIGN KEY ([ViewId]) REFERENCES [USR].[View] ([ViewId])
);

