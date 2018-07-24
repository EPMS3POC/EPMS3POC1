CREATE TABLE [INS].[ClearingHouse] (
    [ClearingHouseId]     BIGINT        IDENTITY (1, 1) NOT NULL,
    [UserName]            VARCHAR (100) NULL,
    [Password]            VARCHAR (100) NULL,
    [EligibilityUserName] VARCHAR (100) NULL,
    [EligibilityPassword] VARCHAR (100) NULL,
    [BillingSoftwareId]   BIGINT        NULL,
    [CreatedDateTime]     DATETIME      NOT NULL,
    [ModifiedDateTime]    DATETIME      NOT NULL,
    [CreatedByUser]       VARCHAR (80)  NOT NULL,
    [ModifiedByUser]      VARCHAR (80)  NULL,
    [CreatedByProgram]    VARCHAR (80)  NOT NULL,
    [ModifiedByProgram]   VARCHAR (80)  NULL,
    [RecordStatus]        INT           NOT NULL,
    CONSTRAINT [XPKClearingHouse] PRIMARY KEY CLUSTERED ([ClearingHouseId] ASC),
    CONSTRAINT [R_704] FOREIGN KEY ([BillingSoftwareId]) REFERENCES [INS].[BillingSoftware] ([BillingSoftwareId])
);

