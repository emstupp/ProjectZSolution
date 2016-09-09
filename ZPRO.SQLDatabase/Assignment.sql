CREATE TABLE [dbo].[Assignment]
(
	[AssignmentID] INT NOT NULL PRIMARY KEY identity,
	[CourseID] NCHAR(10) NOT NULL,
    [Type] NCHAR(30) NOT NULL, 
    [Name] NCHAR(30) NOT NULL, 
    [DueDate] DATETIME NOT NULL, 
    [Description] VARCHAR(100) NULL
    
)
