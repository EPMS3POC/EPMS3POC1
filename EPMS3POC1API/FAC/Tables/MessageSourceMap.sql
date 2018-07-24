CREATE TABLE [FAC].[MessageSourceMap] (
    [MessageSourceMapId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [MessageId]          BIGINT       NOT NULL,
    [CreatedDateTime]    DATETIME     NOT NULL,
    [ModifiedDateTime]   DATETIME     NOT NULL,
    [CreatedByUser]      VARCHAR (80) NOT NULL,
    [ModifiedByUser]     VARCHAR (80) NULL,
    [CreatedByProgram]   VARCHAR (80) NOT NULL,
    [ModifiedByProgram]  VARCHAR (80) NULL,
    [RecordStatus]       INT          NOT NULL,
    [MessageSourceId]    BIGINT       NULL,
    CONSTRAINT [PK_MessageSourceMap] PRIMARY KEY CLUSTERED ([MessageSourceMapId] ASC),
    CONSTRAINT [R_301] FOREIGN KEY ([MessageId]) REFERENCES [FAC].[Message] ([MessageId]),
    CONSTRAINT [R_878] FOREIGN KEY ([MessageSourceId]) REFERENCES [FAC].[MessageSource] ([MessageSourceId])
);

