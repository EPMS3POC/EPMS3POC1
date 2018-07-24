CREATE TABLE [TRE].[BundledServiceMasterProcedure] (
    [BundledServiceMasterProcedureId] BIGINT       IDENTITY (1, 1) NOT NULL,
    [BundledServiceId]                BIGINT       NULL,
    [MasterProcedureId]               BIGINT       NULL,
    [CreatedDateTime]                 DATETIME     NOT NULL,
    [ModifiedDateTime]                DATETIME     NOT NULL,
    [CreatedByUser]                   VARCHAR (80) NOT NULL,
    [ModifiedByUser]                  VARCHAR (80) NULL,
    [CreatedByProgram]                VARCHAR (80) NOT NULL,
    [ModifiedByProgram]               VARCHAR (80) NULL,
    [RecordStatus]                    INT          NOT NULL,
    CONSTRAINT [XPKBundledServiceMasterProcedure] PRIMARY KEY CLUSTERED ([BundledServiceMasterProcedureId] ASC),
    CONSTRAINT [R_749] FOREIGN KEY ([BundledServiceId]) REFERENCES [TRE].[BundledService] ([BundledServiceId]),
    CONSTRAINT [R_750] FOREIGN KEY ([MasterProcedureId]) REFERENCES [TRE].[MasterProcedure] ([MasterProcedureId])
);

