-- Create the Tightening table

USE [ShopFloorControlSystem]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].Tightenings(
	[id] [int] IDENTITY(1, 1) NOT NULL,
	[JobId] [int],
	[ParameterId] [int],
	[BatchSize] [int],
	[BatchCount] [int],
	[TighteningStatus] [bit],
	[TorqueStatus] [int],
	[AngleStatus] [int],
	[Torque] [float],
	[Angle] [float],
	[TimeStamp] [smalldatetime],
	[BatchStatus] [int]
CONSTRAINT [PK_Tightenings] PRIMARY KEY CLUSTERED
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
) ON [PRIMARY]

GO