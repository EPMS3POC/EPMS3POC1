CREATE TABLE [CLI].[PerioNote] (
    [PerioNotesId]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [PerioExamId]          BIGINT         NULL,
    [PerioNoteDescription] VARCHAR (1024) NULL,
    [CreatedDateTime]      DATETIME       NOT NULL,
    [ModifiedDateTime]     DATETIME       NOT NULL,
    [CreatedByUser]        VARCHAR (80)   NOT NULL,
    [ModifiedByUser]       VARCHAR (80)   NULL,
    [CreatedByProgram]     VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]    VARCHAR (80)   NULL,
    [RecordStatus]         INT            NOT NULL,
    CONSTRAINT [PK_PerioNotes] PRIMARY KEY CLUSTERED ([PerioNotesId] ASC),
    CONSTRAINT [R_833] FOREIGN KEY ([PerioExamId]) REFERENCES [CLI].[PerioExam] ([PerioExamId])
);

