CREATE TABLE [dbo].[Table]
(
	[BugId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Line Start] INT NOT NULL, 
    [Line End] INT NULL, 
    [ProgrammerName] NVARCHAR(50) NOT NULL, 
    [ClassName] NVARCHAR(50) NOT NULL, 
    [MethodName] NVARCHAR(50) NOT NULL, 
    [TimeSubmitted] DATETIME NOT NULL, 
    [ProjectName] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL
)
