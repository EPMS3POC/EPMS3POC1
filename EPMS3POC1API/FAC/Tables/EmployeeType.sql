CREATE TABLE [FAC].[EmployeeType] (
    [EmployeeTypeDescription] VARCHAR (1024) NULL,
    [EmployeeTypeCode]        CHAR (5)       NULL,
    [EmployeeTypeName]        VARCHAR (40)   NULL,
    [EmployeeTypeId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [CreatedDateTime]         DATETIME       NOT NULL,
    [ModifiedDateTime]        DATETIME       NOT NULL,
    [CreatedByUser]           VARCHAR (80)   NOT NULL,
    [ModifiedByUser]          VARCHAR (80)   NULL,
    [CreatedByProgram]        VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]       VARCHAR (80)   NULL,
    [RecordStatus]            INT            NOT NULL,
    CONSTRAINT [XPKEmployeeType] PRIMARY KEY CLUSTERED ([EmployeeTypeId] ASC)
);

