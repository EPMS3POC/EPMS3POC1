CREATE TABLE [SCH].[TimeBlock] (
    [TimeBlockId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [TimeBlock]            INT            NULL,
    [TimeBlockDescription] VARCHAR (1024) NULL,
    [TimeBlockCode]        CHAR (5)       NULL,
    [TimeBlockName]        VARCHAR (40)   NULL,
    [CreatedDateTime]      DATETIME       NOT NULL,
    [ModifiedDateTime]     DATETIME       NOT NULL,
    [CreatedByUser]        VARCHAR (80)   NOT NULL,
    [ModifiedByUser]       VARCHAR (80)   NULL,
    [CreatedByProgram]     VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]    VARCHAR (80)   NULL,
    [RecordStatus]         INT            NOT NULL,
    CONSTRAINT [PK_AppointmentBlock] PRIMARY KEY CLUSTERED ([TimeBlockId] ASC)
);

