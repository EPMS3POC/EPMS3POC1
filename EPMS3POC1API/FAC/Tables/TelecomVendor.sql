CREATE TABLE [FAC].[TelecomVendor] (
    [TelecomVendorId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [PhoneNumber]              VARCHAR (20)   NULL,
    [FaxNumber]                VARCHAR (20)   NULL,
    [IPAddress]                VARCHAR (20)   NULL,
    [ISPIPGateway]             VARCHAR (20)   NULL,
    [ISPPhoneNumber]           VARCHAR (20)   NULL,
    [ISPServiceType]           VARCHAR (20)   NULL,
    [ISPVendor]                VARCHAR (20)   NULL,
    [TelecomId]                BIGINT         NOT NULL,
    [CreatedDateTime]          DATETIME       NOT NULL,
    [ModifiedDateTime]         DATETIME       NOT NULL,
    [CreatedByUser]            VARCHAR (80)   NOT NULL,
    [ModifiedByUser]           VARCHAR (80)   NULL,
    [CreatedByProgram]         VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]        VARCHAR (80)   NULL,
    [RecordStatus]             INT            NOT NULL,
    [TelecomVendorDescription] VARCHAR (1024) NULL,
    [TelecomVendorCode]        VARCHAR (5)    NULL,
    [TelecomVendorName]        VARCHAR (32)   NULL,
    CONSTRAINT [XPKTelecomVendor] PRIMARY KEY CLUSTERED ([TelecomVendorId] ASC),
    CONSTRAINT [R_583] FOREIGN KEY ([TelecomId]) REFERENCES [FAC].[Telecom] ([TelecomId])
);

