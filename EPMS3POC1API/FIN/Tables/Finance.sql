CREATE TABLE [FIN].[Finance] (
    [FinanceId]                  BIGINT         IDENTITY (1, 1) NOT NULL,
    [FacilityId]                 BIGINT         NOT NULL,
    [FinanceRegion]              VARCHAR (20)   NULL,
    [FinancialClassAccountGroup] VARCHAR (20)   NULL,
    [FinanceName]                VARCHAR (40)   NULL,
    [FinanceDescription]         VARCHAR (1024) NULL,
    [FinanceCode]                CHAR (5)       NULL,
    [CreatedDateTime]            DATETIME       NOT NULL,
    [ModifiedDateTime]           DATETIME       NOT NULL,
    [CreatedByUser]              VARCHAR (80)   NOT NULL,
    [ModifiedByUser]             VARCHAR (80)   NULL,
    [CreatedByProgram]           VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]          VARCHAR (80)   NULL,
    [RecordStatus]               INT            NOT NULL,
    CONSTRAINT [XPKFinance] PRIMARY KEY CLUSTERED ([FinanceId] ASC),
    CONSTRAINT [R_336] FOREIGN KEY ([FacilityId]) REFERENCES [FAC].[Facility] ([FacilityId])
);

