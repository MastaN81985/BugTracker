CREATE TABLE [dbo].[Table]
(
	[BugId] INT NOT NULL PRIMARY KEY, 
    [LineStart] INT NULL, 
    [LineEnd] INT NULL, 
    [ProgrammerName] NVARCHAR(50) NULL, 
    [ClassName] NVARCHAR(50) NULL, 
    [MethodName] NVARCHAR(50) NULL, 
    [TimeSubmitted] DATETIME NULL, 
    [ProjectName] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(MAX) NULL
)
