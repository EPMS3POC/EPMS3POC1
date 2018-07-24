CREATE TABLE [PER].[PersonPhone] (
    [PersonId]                BIGINT       NOT NULL,
    [PersonPhoneId]           BIGINT       IDENTITY (1, 1) NOT NULL,
    [PhoneId]                 BIGINT       NOT NULL,
    [IsPersonPhonePreference] SMALLINT     NULL,
    [IsUsedToConfirm]         SMALLINT     NULL,
    [PhoneTypeId]             BIGINT       NOT NULL,
    [CreatedDateTime]         DATETIME     NOT NULL,
    [ModifiedDateTime]        DATETIME     NOT NULL,
    [CreatedByUser]           VARCHAR (80) NOT NULL,
    [ModifiedByUser]          VARCHAR (80) NULL,
    [CreatedByProgram]        VARCHAR (80) NOT NULL,
    [ModifiedByProgram]       VARCHAR (80) NULL,
    [RecordStatus]            INT          NOT NULL,
    CONSTRAINT [XPKPersonPhone] PRIMARY KEY CLUSTERED ([PersonPhoneId] ASC),
    CONSTRAINT [R_239] FOREIGN KEY ([PersonId]) REFERENCES [PER].[Person] ([PersonId]),
    CONSTRAINT [R_240] FOREIGN KEY ([PhoneId]) REFERENCES [PER].[Phone] ([PhoneId]),
    CONSTRAINT [R_329] FOREIGN KEY ([PhoneTypeId]) REFERENCES [PER].[PhoneType] ([PhoneTypeId])
);

