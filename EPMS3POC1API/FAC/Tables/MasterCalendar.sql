CREATE TABLE [FAC].[MasterCalendar] (
    [MasterCalendarId]  BIGINT       NOT NULL,
    [MasterScheduleId]  BIGINT       NOT NULL,
    [MasterDate]        DATETIME     NULL,
    [TimeBlockId]       BIGINT       NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKMasterCalendar] PRIMARY KEY CLUSTERED ([MasterCalendarId] ASC),
    CONSTRAINT [R_856] FOREIGN KEY ([TimeBlockId]) REFERENCES [SCH].[TimeBlock] ([TimeBlockId])
);

