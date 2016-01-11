CREATE TABLE [dbo].[Table] (
    [BugId]          INT            NULL,
    [Line Start]     INT            NULL,
    [Line End]       INT            NULL,
    [ProgrammerName] NVARCHAR (50)  NULL,
    [ClassName]      NVARCHAR (50)  NULL,
    [MethodName]     NVARCHAR (50)  NULL,
    [TimeSubmitted]  DATETIME       NULL,
    [ProjectName]    NVARCHAR (50)  NULL,
    [Description]    NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([BugId] ASC)
);

