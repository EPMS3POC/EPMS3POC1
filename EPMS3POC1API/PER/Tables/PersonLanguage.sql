CREATE TABLE [PER].[PersonLanguage] (
    [PersonId]                   BIGINT       NOT NULL,
    [PersonLanguageId]           BIGINT       IDENTITY (1, 1) NOT NULL,
    [LanguageId]                 BIGINT       NOT NULL,
    [IsPersonLanguagePreference] INT          NULL,
    [CreatedDateTime]            DATETIME     NOT NULL,
    [ModifiedDateTime]           DATETIME     NOT NULL,
    [CreatedByUser]              VARCHAR (80) NOT NULL,
    [ModifiedByUser]             VARCHAR (80) NULL,
    [CreatedByProgram]           VARCHAR (80) NOT NULL,
    [ModifiedByProgram]          VARCHAR (80) NULL,
    [RecordStatus]               INT          NOT NULL,
    CONSTRAINT [XPKPersonLanguage] PRIMARY KEY CLUSTERED ([PersonLanguageId] ASC),
    CONSTRAINT [R_551] FOREIGN KEY ([LanguageId]) REFERENCES [PER].[Language] ([LanguageId]),
    CONSTRAINT [R_552] FOREIGN KEY ([PersonId]) REFERENCES [PER].[Person] ([PersonId])
);

