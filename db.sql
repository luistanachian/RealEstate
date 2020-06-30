USE [RealEstate]
GO
ALTER TABLE [dbo].[Usuarios] DROP CONSTRAINT [FK_Usuarios_Direccion_Barrios]
GO
ALTER TABLE [dbo].[Publicaciones] DROP CONSTRAINT [FK_Publicaciones_Usuarios]
GO
ALTER TABLE [dbo].[Publicaciones] DROP CONSTRAINT [FK_Publicaciones_TiposPropiedades]
GO
ALTER TABLE [dbo].[Publicaciones] DROP CONSTRAINT [FK_Publicaciones_Publicaciones_Planes]
GO
ALTER TABLE [dbo].[Publicaciones] DROP CONSTRAINT [FK_Publicaciones_Monedas]
GO
ALTER TABLE [dbo].[Publicaciones] DROP CONSTRAINT [FK_Publicaciones_Direccion_Barrios]
GO
ALTER TABLE [dbo].[Direccion_Localidades] DROP CONSTRAINT [FK_Direccion_Localidades_Direccion_Estados]
GO
ALTER TABLE [dbo].[Direccion_Estados] DROP CONSTRAINT [FK_Direccion_Estados_Direccion_Paises]
GO
ALTER TABLE [dbo].[Direccion_Barrios] DROP CONSTRAINT [FK_Direccion_Barrios_Direccion_Localidades]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 24/6/2020 20:57:03 ******/
DROP TABLE [dbo].[Usuarios]
GO
/****** Object:  Table [dbo].[TiposPropiedades]    Script Date: 24/6/2020 20:57:03 ******/
DROP TABLE [dbo].[TiposPropiedades]
GO
/****** Object:  Table [dbo].[Publicaciones_Planes]    Script Date: 24/6/2020 20:57:03 ******/
DROP TABLE [dbo].[Publicaciones_Planes]
GO
/****** Object:  Table [dbo].[Publicaciones]    Script Date: 24/6/2020 20:57:03 ******/
DROP TABLE [dbo].[Publicaciones]
GO
/****** Object:  Table [dbo].[Monedas]    Script Date: 24/6/2020 20:57:03 ******/
DROP TABLE [dbo].[Monedas]
GO
/****** Object:  Table [dbo].[Direccion_Paises]    Script Date: 24/6/2020 20:57:03 ******/
DROP TABLE [dbo].[Direccion_Paises]
GO
/****** Object:  Table [dbo].[Direccion_Localidades]    Script Date: 24/6/2020 20:57:03 ******/
DROP TABLE [dbo].[Direccion_Localidades]
GO
/****** Object:  Table [dbo].[Direccion_Estados]    Script Date: 24/6/2020 20:57:03 ******/
DROP TABLE [dbo].[Direccion_Estados]
GO
/****** Object:  Table [dbo].[Direccion_Barrios]    Script Date: 24/6/2020 20:57:03 ******/
DROP TABLE [dbo].[Direccion_Barrios]
GO
/****** Object:  Table [dbo].[Direccion_Barrios]    Script Date: 24/6/2020 20:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direccion_Barrios](
	[idBarrio] [nvarchar](7) NOT NULL,
	[idLocalidad] [nvarchar](5) NOT NULL,
	[barrio] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Direccion_Barrios] PRIMARY KEY CLUSTERED 
(
	[idBarrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Direccion_Estados]    Script Date: 24/6/2020 20:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direccion_Estados](
	[idEstado] [nvarchar](3) NOT NULL,
	[idPais] [nvarchar](3) NOT NULL,
	[estado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Direccion_Estados] PRIMARY KEY CLUSTERED 
(
	[idEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Direccion_Localidades]    Script Date: 24/6/2020 20:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direccion_Localidades](
	[idLocalidad] [nvarchar](5) NOT NULL,
	[idEstado] [nvarchar](3) NOT NULL,
	[localidad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Direccion_Localidades] PRIMARY KEY CLUSTERED 
(
	[idLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Direccion_Paises]    Script Date: 24/6/2020 20:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direccion_Paises](
	[idPais] [nvarchar](3) NOT NULL,
	[pais] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Direccion_Paises] PRIMARY KEY CLUSTERED 
(
	[idPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Monedas]    Script Date: 24/6/2020 20:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Monedas](
	[idMoneda] [char](1) NOT NULL,
	[moneda] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Monedas] PRIMARY KEY CLUSTERED 
(
	[idMoneda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publicaciones]    Script Date: 24/6/2020 20:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publicaciones](
	[idPub] [nvarchar](32) NOT NULL,
	[idUsuario] [nvarchar](32) NOT NULL,
	[idTipoPropiedad] [char](1) NOT NULL,
	[idPlan] [char](1) NOT NULL,
	[idBarrio] [nvarchar](7) NOT NULL,
	[idMoneda] [char](1) NOT NULL,
	[cicloDiario] [bit] NULL,
	[cicloSemanal] [bit] NULL,
	[cicloMensual] [bit] NULL,
	[cicloCantidad] [smallint] NULL,
	[monto] [decimal](18, 4) NOT NULL,
	[expensas] [decimal](18, 4) NULL,
	[impuestos] [decimal](18, 4) NULL,
	[fechaInicio] [date] NOT NULL,
	[fechaVencimiento] [date] NOT NULL,
	[countVistas] [int] NOT NULL,
	[countContactados] [int] NOT NULL,
	[cantAmbientes] [smallint] NULL,
	[cantHabitaciones] [smallint] NULL,
	[cantBaños] [smallint] NULL,
	[cantCocheras] [smallint] NULL,
	[cantBalcones] [smallint] NULL,
	[permiteMascotas] [bit] NULL,
	[permiteNiños] [bit] NULL,
	[srvGas] [bit] NULL,
	[srvElectricidad] [bit] NULL,
	[srvAgua] [bit] NULL,
	[srvInternet] [bit] NULL,
	[srvTelefonico] [bit] NULL,
	[dirCalle] [nvarchar](50) NULL,
	[dirPiso] [nvarchar](50) NULL,
	[dirLocal] [nvarchar](50) NULL,
	[dirLatitud] [nvarchar](50) NULL,
	[dirLongitud] [nvarchar](50) NULL,
	[descripcion] [nvarchar](500) NULL,
 CONSTRAINT [PK_Publicaciones] PRIMARY KEY CLUSTERED 
(
	[idPub] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publicaciones_Planes]    Script Date: 24/6/2020 20:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publicaciones_Planes](
	[idPlan] [char](1) NOT NULL,
	[nombre] [nvarchar](20) NOT NULL,
	[descripcion] [nvarchar](500) NOT NULL,
	[visibilidad] [nvarchar](10) NOT NULL,
	[idMoneda] [char](1) NOT NULL,
	[monto] [decimal](18, 4) NOT NULL,
	[dias] [smallint] NOT NULL,
	[destacado] [bit] NOT NULL,
	[superDestacado] [bit] NOT NULL,
 CONSTRAINT [PK_Publicaciones_Planes] PRIMARY KEY CLUSTERED 
(
	[idPlan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposPropiedades]    Script Date: 24/6/2020 20:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposPropiedades](
	[idTipoPropiedad] [char](1) NOT NULL,
	[tipoPropiedad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TiposPropiedades] PRIMARY KEY CLUSTERED 
(
	[idTipoPropiedad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 24/6/2020 20:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [nvarchar](32) NOT NULL,
	[idBarrio] [nvarchar](7) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[clave] [nvarchar](16) NOT NULL,
	[dueño] [bit] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[documento1] [nvarchar](20) NOT NULL,
	[documento2] [nvarchar](20) NULL,
	[documento3] [nvarchar](20) NULL,
	[telefono1] [nvarchar](20) NOT NULL,
	[telefono2] [nvarchar](20) NULL,
	[telefono3] [nvarchar](20) NULL,
	[countMeGusta] [int] NULL,
	[urlFacebook] [nvarchar](500) NULL,
	[urlInstagram] [nvarchar](500) NULL,
	[whatsapp] [nvarchar](20) NULL,
	[emailContacto] [nvarchar](50) NOT NULL,
	[dirCalle] [nvarchar](50) NULL,
	[dirPiso] [nvarchar](50) NULL,
	[dirLocal] [nvarchar](50) NULL,
	[dirLatitud] [nvarchar](50) NULL,
	[dirLongitud] [nvarchar](50) NULL,
	[descripcion] [nvarchar](500) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Direccion_Barrios]  WITH CHECK ADD  CONSTRAINT [FK_Direccion_Barrios_Direccion_Localidades] FOREIGN KEY([idLocalidad])
REFERENCES [dbo].[Direccion_Localidades] ([idLocalidad])
GO
ALTER TABLE [dbo].[Direccion_Barrios] CHECK CONSTRAINT [FK_Direccion_Barrios_Direccion_Localidades]
GO
ALTER TABLE [dbo].[Direccion_Estados]  WITH CHECK ADD  CONSTRAINT [FK_Direccion_Estados_Direccion_Paises] FOREIGN KEY([idPais])
REFERENCES [dbo].[Direccion_Paises] ([idPais])
GO
ALTER TABLE [dbo].[Direccion_Estados] CHECK CONSTRAINT [FK_Direccion_Estados_Direccion_Paises]
GO
ALTER TABLE [dbo].[Direccion_Localidades]  WITH CHECK ADD  CONSTRAINT [FK_Direccion_Localidades_Direccion_Estados] FOREIGN KEY([idEstado])
REFERENCES [dbo].[Direccion_Estados] ([idEstado])
GO
ALTER TABLE [dbo].[Direccion_Localidades] CHECK CONSTRAINT [FK_Direccion_Localidades_Direccion_Estados]
GO
ALTER TABLE [dbo].[Publicaciones]  WITH CHECK ADD  CONSTRAINT [FK_Publicaciones_Direccion_Barrios] FOREIGN KEY([idBarrio])
REFERENCES [dbo].[Direccion_Barrios] ([idBarrio])
GO
ALTER TABLE [dbo].[Publicaciones] CHECK CONSTRAINT [FK_Publicaciones_Direccion_Barrios]
GO
ALTER TABLE [dbo].[Publicaciones]  WITH CHECK ADD  CONSTRAINT [FK_Publicaciones_Monedas] FOREIGN KEY([idMoneda])
REFERENCES [dbo].[Monedas] ([idMoneda])
GO
ALTER TABLE [dbo].[Publicaciones] CHECK CONSTRAINT [FK_Publicaciones_Monedas]
GO
ALTER TABLE [dbo].[Publicaciones]  WITH CHECK ADD  CONSTRAINT [FK_Publicaciones_Publicaciones_Planes] FOREIGN KEY([idPlan])
REFERENCES [dbo].[Publicaciones_Planes] ([idPlan])
GO
ALTER TABLE [dbo].[Publicaciones] CHECK CONSTRAINT [FK_Publicaciones_Publicaciones_Planes]
GO
ALTER TABLE [dbo].[Publicaciones]  WITH CHECK ADD  CONSTRAINT [FK_Publicaciones_TiposPropiedades] FOREIGN KEY([idTipoPropiedad])
REFERENCES [dbo].[TiposPropiedades] ([idTipoPropiedad])
GO
ALTER TABLE [dbo].[Publicaciones] CHECK CONSTRAINT [FK_Publicaciones_TiposPropiedades]
GO
ALTER TABLE [dbo].[Publicaciones]  WITH CHECK ADD  CONSTRAINT [FK_Publicaciones_Usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[Publicaciones] CHECK CONSTRAINT [FK_Publicaciones_Usuarios]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Direccion_Barrios] FOREIGN KEY([idBarrio])
REFERENCES [dbo].[Direccion_Barrios] ([idBarrio])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Direccion_Barrios]
GO
