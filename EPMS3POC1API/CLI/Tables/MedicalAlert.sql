CREATE TABLE [CLI].[MedicalAlert] (
    [MedicalAlertId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [MedicalAlertDescription] VARCHAR (1024) NULL,
    [MedicalAlertCode]        CHAR (5)       NULL,
    [MedicalAlertName]        VARCHAR (40)   NULL,
    [CreatedDateTime]         DATETIME       NOT NULL,
    [ModifiedDateTime]        DATETIME       NOT NULL,
    [CreatedByUser]           VARCHAR (80)   NOT NULL,
    [ModifiedByUser]          VARCHAR (80)   NULL,
    [CreatedByProgram]        VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]       VARCHAR (80)   NULL,
    [RecordStatus]            INT            NOT NULL,
    CONSTRAINT [PK_MedicalAlert] PRIMARY KEY CLUSTERED ([MedicalAlertId] ASC)
);

