CREATE TABLE [FAC].[TimeSlot] (
    [TimeSlotId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [StartTime]           DATETIME       NULL,
    [EndTime]             DATETIME       NULL,
    [BlockedDate]         DATETIME       NULL,
    [TimeBlockId]         BIGINT         NULL,
    [OperatoryId]         BIGINT         NOT NULL,
    [TimeSlotDescription] VARCHAR (1024) NULL,
    [TimeSlotCode]        CHAR (5)       NULL,
    [TimeSlotName]        VARCHAR (40)   NULL,
    [CreatedDateTime]     DATETIME       NOT NULL,
    [ModifiedDateTime]    DATETIME       NOT NULL,
    [CreatedByUser]       VARCHAR (80)   NOT NULL,
    [ModifiedByUser]      VARCHAR (80)   NULL,
    [CreatedByProgram]    VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]   VARCHAR (80)   NULL,
    [RecordStatus]        INT            NOT NULL,
    [TimeSlotDate]        DATETIME       NULL,
    CONSTRAINT [PK_TimeSlots] PRIMARY KEY CLUSTERED ([TimeSlotId] ASC),
    CONSTRAINT [R_173] FOREIGN KEY ([TimeBlockId]) REFERENCES [SCH].[TimeBlock] ([TimeBlockId]),
    CONSTRAINT [R_322] FOREIGN KEY ([OperatoryId]) REFERENCES [FAC].[Operatory] ([OperatoryId])
);

