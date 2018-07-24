CREATE TABLE [CLI].[PulseRhythmType] (
    [PulseRhythmTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [PulseRhythmTypeDescription] VARCHAR (1024) NULL,
    [PulseRhythmTypeCode]        CHAR (5)       NULL,
    [PulseRhythmTypeName]        VARCHAR (50)   NULL,
    [CreatedDateTime]            DATETIME       NOT NULL,
    [ModifiedDateTime]           DATETIME       NOT NULL,
    [CreatedByUser]              VARCHAR (80)   NOT NULL,
    [ModifiedByUser]             VARCHAR (80)   NULL,
    [CreatedByProgram]           VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]          VARCHAR (80)   NULL,
    [RecordStatus]               INT            NOT NULL,
    CONSTRAINT [PK_PulseRhythmType] PRIMARY KEY CLUSTERED ([PulseRhythmTypeId] ASC)
);

