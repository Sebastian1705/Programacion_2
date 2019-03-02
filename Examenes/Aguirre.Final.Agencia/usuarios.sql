USE [final-20181206]
GO

/****** Object:  Table [dbo].[Usuarios]    Script Date: 9/12/2018 8:48:02 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[clave] [nvarchar](50) NULL
) ON [PRIMARY]
GO

