﻿CREATE TABLE [USR].[UserPermission] (
    [UserId]                    BIGINT         NOT NULL,
    [UserPermissionId]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [UserPermissionCode]        VARCHAR (5)    NULL,
    [UserPermissionName]        VARCHAR (32)   NULL,
    [UserPermissionDescription] VARCHAR (1024) NULL,
    [CreatedDateTime]           DATETIME       NOT NULL,
    [ModifiedDateTime]          DATETIME       NOT NULL,
    [CreatedByUser]             VARCHAR (80)   NOT NULL,
    [ModifiedByUser]            VARCHAR (80)   NULL,
    [CreatedByProgram]          VARCHAR (80)   NOT NULL,
    [ModifiedByProgram]         VARCHAR (80)   NULL,
    [RecordStatus]              INT            NOT NULL,
    [ModuleId]                  BIGINT         NULL,
    [PermissionId]              BIGINT         NULL,
    [ViewId]                    BIGINT         NULL,
    [FieldId]                   BIGINT         NULL,
    CONSTRAINT [PK_UserPermission] PRIMARY KEY CLUSTERED ([UserPermissionId] ASC),
    CONSTRAINT [R_634] FOREIGN KEY ([UserId]) REFERENCES [USR].[User] ([UserId]),
    CONSTRAINT [R_863] FOREIGN KEY ([ModuleId]) REFERENCES [USR].[Module] ([ModuleId]),
    CONSTRAINT [R_870] FOREIGN KEY ([PermissionId]) REFERENCES [USR].[Permission] ([PermissionId]),
    CONSTRAINT [R_875] FOREIGN KEY ([ViewId]) REFERENCES [USR].[View] ([ViewId]),
    CONSTRAINT [R_876] FOREIGN KEY ([FieldId]) REFERENCES [USR].[Field] ([FieldId])
);

