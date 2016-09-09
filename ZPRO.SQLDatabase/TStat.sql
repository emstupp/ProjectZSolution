CREATE TABLE [dbo].[TStat]
(
	[T_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CriticalT] FLOAT NOT NULL,
	[ObservedT] FLOAT NOT NULL, 
    [Alpha] FLOAT NOT NULL, 
    [TwoTailed] BIT NOT NULL, 
)
