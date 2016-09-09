CREATE TABLE [dbo].[Sample]
(
	[SampleID] int not null primary key identity,
	[StatisticID] int null,
    [SampleMean] FLOAT NOT NULL DEFAULT 0, 
    [SampleStDev] FLOAT NOT NULL DEFAULT 0, 
    [SampleSize] INT NOT NULL DEFAULT 0, 
    [PopulationMean] FLOAT NOT NULL DEFAULT 0,

)
