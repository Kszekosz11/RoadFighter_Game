-- Stworzenie bazy danych RoadFighterData
USE master
GO

IF EXISTS(SELECT name FROM master.dbo.sysdatabases
			WHERE name = N'RoadFighterData')
BEGIN
	DROP DATABASE RoadFighterData
END
GO

CREATE DATABASE RoadFighterData
GO

SELECT 'Utworzono schemat bazy danych [RoadFighterData].' AS [Komunikat]
---------------------------------------------------------------------------------------------------------------------------------------------------------------

-- Utworzenie tabeli GameRecords
USE [RoadFighterData] 
GO

DROP TABLE IF EXISTS dbo.GameRecords;
GO

CREATE TABLE GameRecords (
[GameID] int IDENTITY(1,1) NOT NULL PRIMARY KEY,
[Name] NVARCHAR(30) NULL,
[Score] SMALLINT NULL, 
[Crash] SMALLINT NULL
);
GO