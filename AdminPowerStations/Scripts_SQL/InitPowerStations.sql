------------------------------------------------------------------------------------------------------------------
-- Purpose: This DB provides tables for power stations and their readings.			------------------------------
------------------------------------------------------------------------------------------------------------------
USE master;	
GO

--Delete the PowerStations database if it exists.
IF EXISTS(SELECT * from sys.databases WHERE name='PowerStations')
BEGIN
    DROP DATABASE PowerStations;
END

--Create a new database called PowerStations.
CREATE DATABASE PowerStations
ON   
( NAME = PowerStations_dat,  
    FILENAME = 'C:\Users\Phillip\Documents\Visual Studio 2015\Projects\WCF_Services\PowerService\AdminPowerStations\App_Data\PowerStations_dat.mdf',  
    SIZE = 20,  
    MAXSIZE = 30,  
    FILEGROWTH = 1 )  
LOG ON  
( NAME = PowerStations_log,  
    FILENAME = 'C:\Users\Phillip\Documents\Visual Studio 2015\Projects\WCF_Services\PowerService\AdminPowerStations\App_Data\PowerStations_log.ldf',  
    SIZE = 2MB,  
    MAXSIZE = 5MB,  
    FILEGROWTH = 1MB ) ;
GO

USE PowerStations;
GO

------------------------------------------------------------------------------------------------------------------
-- Create the table of power stations. -------------------------------- ------------------------------------------
------------------------------------------------------------------------------------------------------------------
CREATE TABLE dbo.PowerStation
(
	ID smallint IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	Name nvarchar(100) NOT NULL,
	Location nvarchar(200) NOT NULL,
	Phone nvarchar(50) NOT NULL,
	Online bit NOT NULL
);
GO

--DROP TABLE dbo.PowerReading00
--GO

-- Create the power usage table, 1 per hour of a day.
CREATE TABLE dbo.PowerReading00
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading00
  ON dbo.PowerReading00 (ReadingMinute, ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading01
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading01
  ON dbo.PowerReading01 (ReadingMinute, ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading02
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading02
  ON dbo.PowerReading02 (ReadingMinute, ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading03
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading03
  ON dbo.PowerReading03 (ReadingMinute, ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading04
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading04
  ON dbo.PowerReading04 (ReadingMinute, ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading05
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading05
  ON dbo.PowerReading05 (ReadingMinute, ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading06
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading06
  ON dbo.PowerReading06 (ReadingMinute, ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading07
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading07
  ON dbo.PowerReading07 (ReadingMinute, ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading08
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading08
  ON dbo.PowerReading08 (ReadingMinute, ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading09
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading09
  ON dbo.PowerReading09 (ReadingMinute, ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading10
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading10
  ON dbo.PowerReading10 (ReadingMinute,ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading11
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading11
  ON dbo.PowerReading11 (ReadingMinute,ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading12
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading12
  ON dbo.PowerReading12 (ReadingMinute,ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading13
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading13
  ON dbo.PowerReading13 (ReadingMinute,ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading14
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading14
  ON dbo.PowerReading14 (ReadingMinute,ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading15
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading15
  ON dbo.PowerReading15 (ReadingMinute,ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading16
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading16
  ON dbo.PowerReading16 (ReadingMinute,ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading17
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading17
  ON dbo.PowerReading17 (ReadingMinute,ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading18
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading18
  ON dbo.PowerReading18 (ReadingMinute,ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading19
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading19
  ON dbo.PowerReading19 (ReadingMinute,ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading20
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading20
  ON dbo.PowerReading20 (ReadingMinute,ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading21
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading21
  ON dbo.PowerReading21 (ReadingMinute,ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading22
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading22
  ON dbo.PowerReading22 (ReadingMinute,ReadingSecond ASC);
GO

CREATE TABLE dbo.PowerReading23
(
	ID int IDENTITY (1,1) PRIMARY KEY NONCLUSTERED NOT NULL,
	ReadingMinute tinyint NOT NULL,
	ReadingSecond tinyint NOT NULL,
	Station01PowerUsage decimal(7, 3) NOT NULL,
	Station02PowerUsage decimal(7, 3) NOT NULL,
	Station03PowerUsage decimal(7, 3) NOT NULL,
	Station04PowerUsage decimal(7, 3) NOT NULL,
	Station05PowerUsage decimal(7, 3) NOT NULL,
	Station06PowerUsage decimal(7, 3) NOT NULL,
	Station07PowerUsage decimal(7, 3) NOT NULL,
	Station08PowerUsage decimal(7, 3) NOT NULL,
	Station09PowerUsage decimal(7, 3) NOT NULL,
	Station10PowerUsage decimal(7, 3) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_PowerReading23
  ON dbo.PowerReading23 (ReadingMinute,ReadingSecond ASC);
GO
