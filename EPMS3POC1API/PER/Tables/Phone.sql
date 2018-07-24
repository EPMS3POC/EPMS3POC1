CREATE TABLE [PER].[Phone] (
    [PhoneId]           BIGINT       IDENTITY (1, 1) NOT NULL,
    [Extension]         VARCHAR (12) NULL,
    [IsTextCapable]     CHAR (1)     NULL,
    [AreaCode]          CHAR (3)     NULL,
    [NXX]               CHAR (3)     NULL,
    [Line]              CHAR (4)     NULL,
    [CountryCode]       CHAR (3)     NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [PK_PersonPhone] PRIMARY KEY CLUSTERED ([PhoneId] ASC)
);

