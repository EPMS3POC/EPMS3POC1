﻿CREATE TABLE [USR].[RolePermission] (
    [UserId]                    BIGINT         NOT NULL,
    [RolePermissionId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [RolePermissionCode]        VARCHAR (5)    NULL,
    [RolePermissionName]        VARCHAR (32)   NULL,
    [RolePermissionDescription] VARCHAR (1024) NULL,
    [CreatedDateTime]           DATETIME       NOT NULL,
    [ModifiedDateTime]          DATETIME       NOT NULL,
    [CreatedByUser]             VARCHAR (80)   NOT NULL,
    [ModifiedByUser]            VARCHAR (80)   NULL,
    [CreatedByProgram]          VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]         VARCHAR (80)   NULL,
    [RecordStatus]              INT            NOT NULL,
    [ModuleId]                  BIGINT         NULL,
    [FieldId]                   BIGINT         NULL,
    [ViewId]                    BIGINT         NULL,
    [RoleId]                    BIGINT         NULL,
    [PermissionId]              BIGINT         NULL,
    CONSTRAINT [PK_RolePermission_1] PRIMARY KEY CLUSTERED ([RolePermissionId] ASC),
    CONSTRAINT [R_636] FOREIGN KEY ([UserId]) REFERENCES [USR].[User] ([UserId]),
    CONSTRAINT [R_864] FOREIGN KEY ([ModuleId]) REFERENCES [USR].[Module] ([ModuleId]),
    CONSTRAINT [R_867] FOREIGN KEY ([FieldId]) REFERENCES [USR].[Field] ([FieldId]),
    CONSTRAINT [R_868] FOREIGN KEY ([ViewId]) REFERENCES [USR].[View] ([ViewId]),
    CONSTRAINT [R_869] FOREIGN KEY ([RoleId]) REFERENCES [USR].[Role] ([RoleId]),
    CONSTRAINT [R_871] FOREIGN KEY ([PermissionId]) REFERENCES [USR].[Permission] ([PermissionId])
);

