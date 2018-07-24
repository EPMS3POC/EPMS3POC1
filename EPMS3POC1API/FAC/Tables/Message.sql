CREATE TABLE [FAC].[Message] (
    [MessageId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [MessageTypeId]      BIGINT         NOT NULL,
    [SeverityLevel]      INT            NULL,
    [Header]             VARCHAR (50)   NULL,
    [Text]               VARCHAR (1)    NULL,
    [StartDate]          DATETIME       NULL,
    [ExpirationDate]     DATETIME       NULL,
    [MessageDescription] VARCHAR (1024) NULL,
    [MessageCode]        CHAR (5)       NULL,
    [MessageName]        VARCHAR (40)   NULL,
    [CreatedDateTime]    DATETIME       NOT NULL,
    [ModifiedDateTime]   DATETIME       NOT NULL,
    [CreatedByUser]      VARCHAR (80)   NOT NULL,
    [ModifiedByUser]     VARCHAR (80)   NULL,
    [CreatedByProgram]   VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]  VARCHAR (80)   NULL,
    [RecordStatus]       INT            NOT NULL,
    CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED ([MessageId] ASC),
    CONSTRAINT [R_299] FOREIGN KEY ([MessageTypeId]) REFERENCES [FAC].[MessageType] ([MessageTypeId])
);

