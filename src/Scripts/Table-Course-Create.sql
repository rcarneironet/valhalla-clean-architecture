USE [ValhallaDatabase]
GO

/****** Object:  Table [dbo].[Course]    Script Date: 07/02/2020 17:06:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Course](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Created] [datetime] NOT NULL,
	[Updated] [datetime] NULL
) ON [PRIMARY]
GO


