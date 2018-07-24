CREATE TABLE [PER].[PhoneType] (
    [PhoneTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [PhoneTypeName]        VARCHAR (32)   NULL,
    [PhoneTypeDescription] VARCHAR (1024) NULL,
    [PhoneTypeCode]        VARCHAR (5)    NULL,
    [CreatedDateTime]      DATETIME       NOT NULL,
    [ModifiedDateTime]     DATETIME       NOT NULL,
    [CreatedByUser]        VARCHAR (80)   NOT NULL,
    [ModifiedByUser]       VARCHAR (80)   NULL,
    [CreatedByProgram]     VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]    VARCHAR (80)   NULL,
    [RecordStatus]         INT            NOT NULL,
    CONSTRAINT [PK_PersonPhoneType] PRIMARY KEY CLUSTERED ([PhoneTypeId] ASC)
);

