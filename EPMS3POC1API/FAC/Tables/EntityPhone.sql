CREATE TABLE [FAC].[EntityPhone] (
    [PhoneId]           BIGINT       NULL,
    [EntityPhoneId]     BIGINT       IDENTITY (1, 1) NOT NULL,
    [EntityId]          BIGINT       NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKEntityPhone] PRIMARY KEY CLUSTERED ([EntityPhoneId] ASC),
    CONSTRAINT [R_577] FOREIGN KEY ([EntityId]) REFERENCES [FAC].[Entity] ([EntityId]),
    CONSTRAINT [R_578] FOREIGN KEY ([PhoneId]) REFERENCES [PER].[Phone] ([PhoneId])
);

