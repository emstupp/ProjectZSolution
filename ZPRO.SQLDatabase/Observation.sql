CREATE TABLE [dbo].[Observation]
(
	[ObservationID] INT NOT NULL PRIMARY KEY identity, 
    [SampleID] INT NOT NULL, 
    [Value] FLOAT NOT NULL
)
