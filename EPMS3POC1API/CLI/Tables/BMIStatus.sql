CREATE TABLE [CLI].[BMIStatus] (
    [BMIStatusId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [BMIStatusDescription] VARCHAR (1024) NULL,
    [BMIStatusCode]        CHAR (5)       NULL,
    [BMIStatusName]        VARCHAR (50)   NULL,
    [CreatedDateTime]      DATETIME       NOT NULL,
    [ModifiedDateTime]     DATETIME       NOT NULL,
    [CreatedByUser]        VARCHAR (80)   NOT NULL,
    [ModifiedByUser]       VARCHAR (80)   NULL,
    [CreatedByProgram]     VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]    VARCHAR (80)   NULL,
    [RecordStatus]         INT            NOT NULL,
    CONSTRAINT [PK_BMIStatus] PRIMARY KEY CLUSTERED ([BMIStatusId] ASC)
);

