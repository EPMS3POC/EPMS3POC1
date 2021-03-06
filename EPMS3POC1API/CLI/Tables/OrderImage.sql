﻿CREATE TABLE [CLI].[OrderImage] (
    [OrderImageId]                     BIGINT        IDENTITY (1, 1) NOT NULL,
    [OrderImagesGUID]                  VARCHAR (50)  NULL,
    [OrderImagesDate]                  DATETIME      NULL,
    [PatientId]                        BIGINT        NOT NULL,
    [Priority]                         VARCHAR (10)  NULL,
    [OpenWounds]                       VARCHAR (10)  NULL,
    [Jewelry]                          VARCHAR (10)  NULL,
    [PatientComfortableEnclosedSpaces] VARCHAR (10)  NULL,
    [PatientLieOnBack]                 VARCHAR (10)  NULL,
    [RiskOfFall]                       VARCHAR (10)  NULL,
    [Pregnent]                         SMALLINT      NULL,
    [Spine]                            SMALLINT      NULL,
    [Lbs]                              SMALLINT      NULL,
    [Diabetics]                        SMALLINT      NULL,
    [ScheduledTestDate]                DATETIME      NULL,
    [Indications]                      VARCHAR (150) NULL,
    [IsElectronic]                     SMALLINT      NULL,
    [CreatedDateTime]                  DATETIME      NOT NULL,
    [ModifiedDateTime]                 DATETIME      NOT NULL,
    [CreatedByUser]                    VARCHAR (80)  NOT NULL,
    [ModifiedByUser]                   VARCHAR (80)  NULL,
    [CreatedByProgram]                 VARCHAR (80)  NOT NULL,
    [ModifiedByProgram]                VARCHAR (80)  NULL,
    [RecordStatus]                     INT           NOT NULL,
    [DiagnosticCenterId]               BIGINT        NULL,
    CONSTRAINT [PK_ImagingOrders] PRIMARY KEY CLUSTERED ([OrderImageId] ASC),
    CONSTRAINT [R_396] FOREIGN KEY ([PatientId]) REFERENCES [PER].[Patient] ([PatientId]),
    CONSTRAINT [R_907] FOREIGN KEY ([DiagnosticCenterId]) REFERENCES [CLI].[DiagnosticCenter] ([DiagnosticCenterId])
);

