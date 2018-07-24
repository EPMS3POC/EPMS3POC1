CREATE TABLE [ACC].[MasterPayee] (
    [MasterPayeeId]     BIGINT       NOT NULL,
    [PayeeName]         VARCHAR (50) NULL,
    [Address]           VARCHAR (50) NULL,
    [City]              VARCHAR (20) NULL,
    [State]             VARCHAR (20) NULL,
    [PostalCode]        VARCHAR (20) NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKMasterPayee] PRIMARY KEY CLUSTERED ([MasterPayeeId] ASC)
);

