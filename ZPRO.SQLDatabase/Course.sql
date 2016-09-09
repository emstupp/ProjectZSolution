CREATE TABLE [dbo].[Course]
(
	[CourseID] INT NOT NULL PRIMARY KEY identity,
	[Professor] VARCHAR(50) NULL, 
    [Department] NCHAR(4) NOT NULL, 
    [SectionNum] INT NOT NULL, 
    [Title] VARCHAR(50) NOT NULL, 
	[Days] VARCHAR(50) not null, 
    [StartTime] TIME NOT NULL, 
    [EndTime] TIME NOT NULL,
	[Credits] int not null,
    [UserID] int not null
)
