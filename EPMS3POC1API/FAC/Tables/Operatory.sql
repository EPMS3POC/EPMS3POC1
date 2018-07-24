CREATE TABLE [FAC].[Operatory] (
    [OperatoryId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [IsReadOnly]           SMALLINT       NULL,
    [Priority]             INT            NULL,
    [OperatoryDescription] VARCHAR (1024) NULL,
    [OperatoryCode]        CHAR (5)       NULL,
    [OperatoryName]        VARCHAR (40)   NULL,
    [CreatedDateTime]      DATETIME       NOT NULL,
    [ModifiedDateTime]     DATETIME       NOT NULL,
    [CreatedByUser]        VARCHAR (80)   NOT NULL,
    [ModifiedByUser]       VARCHAR (80)   NULL,
    [CreatedByProgram]     VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]    VARCHAR (80)   NULL,
    [RecordStatus]         INT            NOT NULL,
    [FacilityScheduleId]   BIGINT         NOT NULL,
    CONSTRAINT [XPKOperatory] PRIMARY KEY CLUSTERED ([OperatoryId] ASC)
);

