CREATE TABLE [FAC].[Telecom] (
    [TelecomId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [PhoneNumber]        VARCHAR (20)   NULL,
    [FaxNumber]          VARCHAR (20)   NULL,
    [FacilityId]         BIGINT         NOT NULL,
    [CreatedDateTime]    DATETIME       NOT NULL,
    [ModifiedDateTime]   DATETIME       NOT NULL,
    [CreatedByUser]      VARCHAR (80)   NOT NULL,
    [ModifiedByUser]     VARCHAR (80)   NULL,
    [CreatedByProgram]   VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]  VARCHAR (80)   NULL,
    [RecordStatus]       INT            NOT NULL,
    [TelecomDescription] VARCHAR (1024) NULL,
    [TelecomCode]        CHAR (5)       NULL,
    [TelecomName]        VARCHAR (40)   NULL,
    CONSTRAINT [XPKTelecom] PRIMARY KEY CLUSTERED ([TelecomId] ASC),
    CONSTRAINT [R_334] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId])
);

