CREATE TABLE [CLI].[PatientTooth] (
    [PatientToothId]    BIGINT       IDENTITY (1, 1) NOT NULL,
    [PatientToothCode]  CHAR (5)     NULL,
    [CreatedDateTime]   DATETIME     NOT NULL,
    [ModifiedDateTime]  DATETIME     NOT NULL,
    [CreatedByUser]     VARCHAR (80) NOT NULL,
    [ModifiedByUser]    VARCHAR (80) NULL,
    [CreatedByProgram]  VARCHAR (80) NOT NULL,
    [ModifiedByProgram] VARCHAR (80) NULL,
    [RecordStatus]      INT          NOT NULL,
    CONSTRAINT [XPKPatientTooth] PRIMARY KEY CLUSTERED ([PatientToothId] ASC)
);

