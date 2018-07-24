CREATE TABLE [PER].[AddressType] (
    [AddressTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [AddressTypeCode]        CHAR (5)       NULL,
    [AddressTypeName]        VARCHAR (40)   NULL,
    [AddressTypeDescription] VARCHAR (1024) NULL,
    [CreatedDateTime]        DATETIME       NOT NULL,
    [ModifiedDateTime]       DATETIME       NOT NULL,
    [CreatedByUser]          VARCHAR (80)   NOT NULL,
    [ModifiedByUser]         VARCHAR (80)   NULL,
    [CreatedByProgram]       VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]      VARCHAR (80)   NULL,
    [RecordStatus]           INT            NOT NULL,
    CONSTRAINT [PK_PersonAddressType] PRIMARY KEY CLUSTERED ([AddressTypeId] ASC)
);

