CREATE TABLE [INS].[BillingSoftware] (
    [BillingSoftwareId] BIGINT        IDENTITY (1, 1) NOT NULL,
    [CustomerKey]       VARCHAR (100) NULL,
    [UserName]          VARCHAR (50)  NULL,
    [Password]          VARCHAR (50)  NULL,
    [CompanyName]       VARCHAR (200) NULL,
    [CreatedDateTime]   DATETIME      NOT NULL,
    [ModifiedDateTime]  DATETIME      NOT NULL,
    [CreatedByUser]     VARCHAR (80)  NOT NULL,
    [ModifiedByUser]    VARCHAR (80)  NULL,
    [CreatedByProgram]  VARCHAR (80)  NOT NULL,
    [ModifiedByProgram] VARCHAR (80)  NULL,
    [RecordStatus]      INT           NOT NULL,
    CONSTRAINT [XPKBillingSoftware] PRIMARY KEY CLUSTERED ([BillingSoftwareId] ASC)
);

