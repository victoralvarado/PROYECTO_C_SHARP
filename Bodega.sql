USE [master]
GO
/****** Object:  Database [Bodega]    Script Date: 14/11/2019 04:40:56 ******/
CREATE DATABASE [Bodega]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bodega', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Bodega.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bodega_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Bodega_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Bodega] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bodega].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bodega] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bodega] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bodega] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bodega] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bodega] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bodega] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bodega] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bodega] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bodega] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bodega] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bodega] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bodega] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bodega] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bodega] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bodega] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Bodega] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bodega] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bodega] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bodega] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bodega] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bodega] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bodega] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bodega] SET RECOVERY FULL 
GO
ALTER DATABASE [Bodega] SET  MULTI_USER 
GO
ALTER DATABASE [Bodega] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bodega] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bodega] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bodega] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bodega] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Bodega', N'ON'
GO
ALTER DATABASE [Bodega] SET QUERY_STORE = OFF
GO
USE [Bodega]
GO
/****** Object:  Schema [bodega]    Script Date: 14/11/2019 04:40:57 ******/
CREATE SCHEMA [bodega]
GO
/****** Object:  Schema [m2ss]    Script Date: 14/11/2019 04:40:57 ******/
CREATE SCHEMA [m2ss]
GO
/****** Object:  Table [bodega].[categoria]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bodega].[categoria](
	[idCategoria] [int] IDENTITY(31,1) NOT NULL,
	[nombreCategoria] [varchar](100) NULL,
 CONSTRAINT [PK_categoria] PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [bodega].[detalleprestamo]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bodega].[detalleprestamo](
	[idPrestamo] [int] IDENTITY(64,1) NOT NULL,
	[idPersonal] [int] NULL,
	[idHerramienta] [int] NULL,
	[fechaHora] [varchar](50) NULL,
	[prespor] [varchar](50) NULL,
 CONSTRAINT [PK_detalleprestamo_idPrestamo] PRIMARY KEY CLUSTERED 
(
	[idPrestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [bodega].[devolucion]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bodega].[devolucion](
	[idDevolucion] [int] IDENTITY(19,1) NOT NULL,
	[idHerramienta] [int] NULL,
	[idPersonal] [int] NULL,
	[estadoEntre] [varchar](20) NULL,
	[fechaHora] [varchar](50) NULL,
	[prespor] [varchar](50) NULL,
	[recibidaPor] [varchar](50) NULL,
 CONSTRAINT [PK_devolucion_idDevolucion] PRIMARY KEY CLUSTERED 
(
	[idDevolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [bodega].[herramienta]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bodega].[herramienta](
	[idHerramienta] [int] IDENTITY(41,1) NOT NULL,
	[nombreHerramienta] [varchar](100) NULL,
	[idCategoria] [int] NULL,
	[uso] [varchar](15) NULL,
	[estado] [varchar](15) NULL,
 CONSTRAINT [PK_herramienta_idHerramienta] PRIMARY KEY CLUSTERED 
(
	[idHerramienta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [bodega].[historial]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bodega].[historial](
	[idPrestamoH] [int] IDENTITY(23,1) NOT NULL,
	[idPersonal] [int] NULL,
	[idHerramienta] [int] NULL,
	[fechaHora] [varchar](50) NULL,
	[prespor] [varchar](50) NULL,
 CONSTRAINT [PK_historial_idPrestamoH] PRIMARY KEY CLUSTERED 
(
	[idPrestamoH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [bodega].[personal]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bodega].[personal](
	[id] [int] IDENTITY(16,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[edad] [int] NULL,
 CONSTRAINT [PK_personal_id] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [bodega].[usuario]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [bodega].[usuario](
	[idUsuario] [int] IDENTITY(6,1) NOT NULL,
	[userName] [varchar](50) NULL,
	[password] [varchar](100) NULL,
	[tipoUsuario] [varchar](50) NULL,
 CONSTRAINT [PK_usuario_idUsuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [bodega].[categoria] ON 

INSERT [bodega].[categoria] ([idCategoria], [nombreCategoria]) VALUES (44, N'Herramientas manuales')
INSERT [bodega].[categoria] ([idCategoria], [nombreCategoria]) VALUES (45, N'Herramientas para medir')
INSERT [bodega].[categoria] ([idCategoria], [nombreCategoria]) VALUES (46, N'Herramientas eléctricas')
SET IDENTITY_INSERT [bodega].[categoria] OFF
SET IDENTITY_INSERT [bodega].[detalleprestamo] ON 

INSERT [bodega].[detalleprestamo] ([idPrestamo], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (90, 19, 77, N'8/11/2019 12:34:44', N'admin')
INSERT [bodega].[detalleprestamo] ([idPrestamo], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (91, 31, 84, N'8/11/2019 12:38:32', N'admin')
SET IDENTITY_INSERT [bodega].[detalleprestamo] OFF
SET IDENTITY_INSERT [bodega].[devolucion] ON 

INSERT [bodega].[devolucion] ([idDevolucion], [idHerramienta], [idPersonal], [estadoEntre], [fechaHora], [prespor], [recibidaPor]) VALUES (22, 99, 19, N'NORMAL', N'6/11/2019 09:54:04', N'Administrador', N'admin')
INSERT [bodega].[devolucion] ([idDevolucion], [idHerramienta], [idPersonal], [estadoEntre], [fechaHora], [prespor], [recibidaPor]) VALUES (23, 106, 25, N'NORMAL', N'6/11/2019 09:54:16', N'Administrador', N'admin')
INSERT [bodega].[devolucion] ([idDevolucion], [idHerramienta], [idPersonal], [estadoEntre], [fechaHora], [prespor], [recibidaPor]) VALUES (24, 77, 25, N'NORMAL', N'6/11/2019 09:54:22', N'Administrador', N'admin')
INSERT [bodega].[devolucion] ([idDevolucion], [idHerramienta], [idPersonal], [estadoEntre], [fechaHora], [prespor], [recibidaPor]) VALUES (25, 91, 25, N'NORMAL', N'6/11/2019 09:54:31', N'Administrador', N'admin')
INSERT [bodega].[devolucion] ([idDevolucion], [idHerramienta], [idPersonal], [estadoEntre], [fechaHora], [prespor], [recibidaPor]) VALUES (26, 94, 22, N'DEFECTUOSA', N'6/11/2019 09:54:45', N'Administrador', N'admin')
INSERT [bodega].[devolucion] ([idDevolucion], [idHerramienta], [idPersonal], [estadoEntre], [fechaHora], [prespor], [recibidaPor]) VALUES (27, 103, 22, N'DEFECTUOSA', N'6/11/2019 09:55:05', N'Administrador', N'admin')
INSERT [bodega].[devolucion] ([idDevolucion], [idHerramienta], [idPersonal], [estadoEntre], [fechaHora], [prespor], [recibidaPor]) VALUES (28, 95, 18, N'NORMAL', N'8/11/2019 12:05:24', N'admin', N'Bodeguero')
INSERT [bodega].[devolucion] ([idDevolucion], [idHerramienta], [idPersonal], [estadoEntre], [fechaHora], [prespor], [recibidaPor]) VALUES (29, 77, 18, N'NORMAL', N'8/11/2019 12:05:31', N'admin', N'Bodeguero')
INSERT [bodega].[devolucion] ([idDevolucion], [idHerramienta], [idPersonal], [estadoEntre], [fechaHora], [prespor], [recibidaPor]) VALUES (30, 112, 29, N'NORMAL', N'8/11/2019 12:05:37', N'admin', N'Bodeguero')
INSERT [bodega].[devolucion] ([idDevolucion], [idHerramienta], [idPersonal], [estadoEntre], [fechaHora], [prespor], [recibidaPor]) VALUES (31, 115, 29, N'NORMAL', N'8/11/2019 12:05:42', N'admin', N'Bodeguero')
INSERT [bodega].[devolucion] ([idDevolucion], [idHerramienta], [idPersonal], [estadoEntre], [fechaHora], [prespor], [recibidaPor]) VALUES (32, 99, 36, N'NORMAL', N'8/11/2019 12:05:48', N'bodeguero001', N'Bodeguero')
INSERT [bodega].[devolucion] ([idDevolucion], [idHerramienta], [idPersonal], [estadoEntre], [fechaHora], [prespor], [recibidaPor]) VALUES (33, 93, 36, N'NORMAL', N'8/11/2019 12:05:55', N'bodeguero001', N'Bodeguero')
INSERT [bodega].[devolucion] ([idDevolucion], [idHerramienta], [idPersonal], [estadoEntre], [fechaHora], [prespor], [recibidaPor]) VALUES (34, 111, 36, N'NORMAL', N'8/11/2019 12:06:02', N'bodeguero001', N'Bodeguero')
SET IDENTITY_INSERT [bodega].[devolucion] OFF
SET IDENTITY_INSERT [bodega].[herramienta] ON 

INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (74, N'Mazo', 44, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (75, N'Martillo', 44, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (76, N'Lima', 44, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (77, N'Alicate', 44, N'SI', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (78, N'Pala', 44, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (79, N'Cinta métrica', 45, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (80, N'Regla graduada', 45, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (81, N'Escuadra', 45, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (82, N'Nivel', 45, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (83, N'Taladro Inalámbrico', 46, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (84, N'Caladora', 44, N'SI', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (85, N'Sierra Circular', 46, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (86, N'Lijadora', 46, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (87, N'Grapadora eléctrica', 46, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (88, N'Detector de metales', 46, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (89, N'Medidor láser', 46, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (90, N'Alicate', 44, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (91, N'Caladora', 44, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (92, N'Pala', 44, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (93, N'Cinta métrica', 45, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (94, N'Cinta métrica', 45, N'NO', N'DEFECTUOSA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (95, N'Cinta métrica', 45, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (96, N'Cinta métrica', 45, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (97, N'Caladora', 44, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (98, N'Caladora', 44, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (99, N'Alicate', 44, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (100, N'Alicate', 44, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (101, N'Alicate', 44, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (102, N'Lima', 44, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (103, N'Lima', 44, N'NO', N'DEFECTUOSA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (104, N'Carretilla', 44, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (105, N'Carretilla', 44, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (106, N'Carretilla', 44, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (107, N'Grapadora eléctrica', 46, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (108, N'Grapadora eléctrica', 46, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (109, N'Grapadora eléctrica', 46, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (110, N'Escuadra', 45, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (111, N'Escuadra', 45, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (112, N'Detector de metales', 46, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (113, N'Sierra Circular', 46, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (114, N'Taladro Inalámbrico', 46, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (115, N'Pico', 44, N'NO', N'NORMAL')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (116, N'Pico', 44, N'NO', N'NUEVA')
INSERT [bodega].[herramienta] ([idHerramienta], [nombreHerramienta], [idCategoria], [uso], [estado]) VALUES (117, N'Pico', 44, N'NO', N'NORMAL')
SET IDENTITY_INSERT [bodega].[herramienta] OFF
SET IDENTITY_INSERT [bodega].[historial] ON 

INSERT [bodega].[historial] ([idPrestamoH], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (26, 25, 77, N'1/11/2019 08:11:36', N'Administrador')
INSERT [bodega].[historial] ([idPrestamoH], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (27, 25, 106, N'1/11/2019 08:11:51', N'Administrador')
INSERT [bodega].[historial] ([idPrestamoH], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (28, 19, 99, N'1/11/2019 08:12:56', N'Administrador')
INSERT [bodega].[historial] ([idPrestamoH], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (29, 22, 94, N'1/11/2019 08:13:05', N'Administrador')
INSERT [bodega].[historial] ([idPrestamoH], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (30, 22, 103, N'1/11/2019 08:13:15', N'Administrador')
INSERT [bodega].[historial] ([idPrestamoH], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (31, 25, 91, N'3/11/2019 06:00:09', N'Administrador')
INSERT [bodega].[historial] ([idPrestamoH], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (32, 36, 99, N'6/11/2019 10:03:49', N'bodeguero001')
INSERT [bodega].[historial] ([idPrestamoH], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (33, 36, 93, N'6/11/2019 10:03:58', N'bodeguero001')
INSERT [bodega].[historial] ([idPrestamoH], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (34, 36, 111, N'6/11/2019 10:04:08', N'bodeguero001')
INSERT [bodega].[historial] ([idPrestamoH], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (35, 18, 77, N'6/11/2019 12:05:10', N'admin')
INSERT [bodega].[historial] ([idPrestamoH], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (36, 18, 95, N'6/11/2019 12:05:21', N'admin')
INSERT [bodega].[historial] ([idPrestamoH], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (37, 29, 112, N'6/11/2019 12:05:31', N'admin')
INSERT [bodega].[historial] ([idPrestamoH], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (38, 29, 115, N'6/11/2019 12:05:43', N'admin')
INSERT [bodega].[historial] ([idPrestamoH], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (39, 19, 77, N'8/11/2019 12:34:44', N'admin')
INSERT [bodega].[historial] ([idPrestamoH], [idPersonal], [idHerramienta], [fechaHora], [prespor]) VALUES (40, 31, 84, N'8/11/2019 12:38:32', N'admin')
SET IDENTITY_INSERT [bodega].[historial] OFF
SET IDENTITY_INSERT [bodega].[personal] ON 

INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (18, N'Carlos Jose', N'Alvarez Juarez', 35)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (19, N'Javier Efraín', N'Arevalo Lopez', 28)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (20, N'Marco Tulio', N'Alocen Barrera', 38)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (21, N'Jorge', N'Velazco Vera', 42)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (22, N'Raul Eduardo', N'Almora Hernandez', 19)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (23, N'Christian Nelson', N'Alcalá Negrón', 27)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (24, N'Fredy Francisco', N'Alarcón Licona', 34)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (25, N'Miguel de Jesús', N'Vázquez', 26)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (26, N'Julio César', N'Díaz Núñez', 24)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (27, N'David Armando', N'Del Toro Arreola', 38)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (29, N'Morales Gese', N'Julio Ramon', 27)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (30, N'Víctor Hugo', N'Alejo Guerrero', 24)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (31, N'José Israel', N'Alcántar O''Donnell', 27)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (32, N'Enrique Alí', N'Altamirano García', 35)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (33, N'Jesús David', N'Alvarado Barbosa', 29)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (34, N'Salvador', N'Álvarez Villanueva', 34)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (35, N'Óscar Guillermo', N'Armenta Romero', 35)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (36, N'Jorge Armando', N'Elizalde Herrera', 27)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (37, N'Ángel de Jesús', N'Fernández del Río', 26)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (38, N'Mario Fernando', N'Gallegos León', 43)
INSERT [bodega].[personal] ([id], [nombre], [apellido], [edad]) VALUES (39, N'Ricardo', N'García Chávez', 27)
SET IDENTITY_INSERT [bodega].[personal] OFF
SET IDENTITY_INSERT [bodega].[usuario] ON 

INSERT [bodega].[usuario] ([idUsuario], [userName], [password], [tipoUsuario]) VALUES (1, N'Administrador', N'123456789', N'Administrador')
INSERT [bodega].[usuario] ([idUsuario], [userName], [password], [tipoUsuario]) VALUES (2, N'bodeguero001', N'123456', N'Bodeguero')
INSERT [bodega].[usuario] ([idUsuario], [userName], [password], [tipoUsuario]) VALUES (6, N'admin001', N'789456', N'Administrador')
SET IDENTITY_INSERT [bodega].[usuario] OFF
ALTER TABLE [bodega].[categoria] ADD  DEFAULT (NULL) FOR [nombreCategoria]
GO
ALTER TABLE [bodega].[detalleprestamo] ADD  DEFAULT (NULL) FOR [idPersonal]
GO
ALTER TABLE [bodega].[detalleprestamo] ADD  DEFAULT (NULL) FOR [idHerramienta]
GO
ALTER TABLE [bodega].[detalleprestamo] ADD  DEFAULT (NULL) FOR [fechaHora]
GO
ALTER TABLE [bodega].[detalleprestamo] ADD  DEFAULT (NULL) FOR [prespor]
GO
ALTER TABLE [bodega].[devolucion] ADD  DEFAULT (NULL) FOR [idHerramienta]
GO
ALTER TABLE [bodega].[devolucion] ADD  DEFAULT (NULL) FOR [idPersonal]
GO
ALTER TABLE [bodega].[devolucion] ADD  DEFAULT (NULL) FOR [estadoEntre]
GO
ALTER TABLE [bodega].[devolucion] ADD  DEFAULT (NULL) FOR [fechaHora]
GO
ALTER TABLE [bodega].[devolucion] ADD  DEFAULT (NULL) FOR [prespor]
GO
ALTER TABLE [bodega].[devolucion] ADD  DEFAULT (NULL) FOR [recibidaPor]
GO
ALTER TABLE [bodega].[herramienta] ADD  DEFAULT (NULL) FOR [nombreHerramienta]
GO
ALTER TABLE [bodega].[herramienta] ADD  DEFAULT (NULL) FOR [idCategoria]
GO
ALTER TABLE [bodega].[herramienta] ADD  DEFAULT (NULL) FOR [uso]
GO
ALTER TABLE [bodega].[herramienta] ADD  DEFAULT (NULL) FOR [estado]
GO
ALTER TABLE [bodega].[historial] ADD  DEFAULT (NULL) FOR [idPersonal]
GO
ALTER TABLE [bodega].[historial] ADD  DEFAULT (NULL) FOR [idHerramienta]
GO
ALTER TABLE [bodega].[historial] ADD  DEFAULT (NULL) FOR [fechaHora]
GO
ALTER TABLE [bodega].[historial] ADD  DEFAULT (NULL) FOR [prespor]
GO
ALTER TABLE [bodega].[personal] ADD  DEFAULT (NULL) FOR [nombre]
GO
ALTER TABLE [bodega].[personal] ADD  DEFAULT (NULL) FOR [apellido]
GO
ALTER TABLE [bodega].[personal] ADD  DEFAULT (NULL) FOR [edad]
GO
ALTER TABLE [bodega].[usuario] ADD  DEFAULT (NULL) FOR [userName]
GO
ALTER TABLE [bodega].[usuario] ADD  DEFAULT (NULL) FOR [password]
GO
ALTER TABLE [bodega].[detalleprestamo]  WITH CHECK ADD  CONSTRAINT [FK_HERRAMI_idHerramienta] FOREIGN KEY([idHerramienta])
REFERENCES [bodega].[herramienta] ([idHerramienta])
ON DELETE CASCADE
GO
ALTER TABLE [bodega].[detalleprestamo] CHECK CONSTRAINT [FK_HERRAMI_idHerramienta]
GO
ALTER TABLE [bodega].[detalleprestamo]  WITH CHECK ADD  CONSTRAINT [FK_PER_idPersonal] FOREIGN KEY([idPersonal])
REFERENCES [bodega].[personal] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [bodega].[detalleprestamo] CHECK CONSTRAINT [FK_PER_idPersonal]
GO
ALTER TABLE [bodega].[devolucion]  WITH CHECK ADD  CONSTRAINT [FK_HERRAM_idHerramienta] FOREIGN KEY([idHerramienta])
REFERENCES [bodega].[herramienta] ([idHerramienta])
ON DELETE CASCADE
GO
ALTER TABLE [bodega].[devolucion] CHECK CONSTRAINT [FK_HERRAM_idHerramienta]
GO
ALTER TABLE [bodega].[devolucion]  WITH CHECK ADD  CONSTRAINT [FK_PERSON_idPersonal] FOREIGN KEY([idPersonal])
REFERENCES [bodega].[personal] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [bodega].[devolucion] CHECK CONSTRAINT [FK_PERSON_idPersonal]
GO
ALTER TABLE [bodega].[herramienta]  WITH CHECK ADD  CONSTRAINT [FK_CATEGORIA_idCategoria] FOREIGN KEY([idCategoria])
REFERENCES [bodega].[categoria] ([idCategoria])
ON DELETE CASCADE
GO
ALTER TABLE [bodega].[herramienta] CHECK CONSTRAINT [FK_CATEGORIA_idCategoria]
GO
ALTER TABLE [bodega].[historial]  WITH CHECK ADD  CONSTRAINT [FK_PERSONAL_idHerramienta] FOREIGN KEY([idHerramienta])
REFERENCES [bodega].[herramienta] ([idHerramienta])
ON DELETE CASCADE
GO
ALTER TABLE [bodega].[historial] CHECK CONSTRAINT [FK_PERSONAL_idHerramienta]
GO
ALTER TABLE [bodega].[historial]  WITH CHECK ADD  CONSTRAINT [FK_PERSONAL_idPersonal] FOREIGN KEY([idPersonal])
REFERENCES [bodega].[personal] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [bodega].[historial] CHECK CONSTRAINT [FK_PERSONAL_idPersonal]
GO
/****** Object:  StoredProcedure [dbo].[EliminarCategoria]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarCategoria]
  @idCategoria int
  OUT AS BEGIN
  delete from Bodega.categoria where idCategoria=@idCategoria;
  END 

GO
/****** Object:  StoredProcedure [dbo].[EliminarDetallePrestamo]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE PROCEDURE [dbo].[EliminarDetallePrestamo]
  @idPrrestamo INT
  OUT AS BEGIN
  DELETE FROM Bodega.detalleprestamo WHERE idPrestamo=@idPrrestamo;
  END

GO
/****** Object:  StoredProcedure [dbo].[EliminarHerramienta]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[EliminarHerramienta]
@idHerramienta int
out
as begin
delete from bodega.herramienta where idHerramienta=@idHerramienta;
end 
GO
/****** Object:  StoredProcedure [dbo].[EliminarPersonal]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarPersonal]
@id int
as begin
delete from Bodega.Personal where id=@id;
end
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarUsuario]
@idUsuario INT OUT 
AS BEGIN
DELETE FROM Bodega.usuario WHERE idUsuario=@idUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[ListarCategoria]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ListarCategoria]
  As Begin
  SELECT idCategoria AS 'CÓDIGO CATEGORÍA', nombreCategoria AS 'CATEGORÍA' FROM Bodega.categoria
  end
GO
/****** Object:  StoredProcedure [dbo].[ListarCategoriaCMB]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ListarCategoriaCMB]
  As Begin
  SELECT idCategoria AS 'CÓDIGO CATEGORÍA', nombreCategoria AS 'CATEGORÍA' FROM Bodega.categoria
  UNION
  SELECT 0 idCategoria , 'SELECCIONAR' nombreCategoria
  End
GO
/****** Object:  StoredProcedure [dbo].[ListarDetallePrestamo]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ListarDetallePrestamo]
  As Begin
	select p.id AS 'CÓDIGO EMPLEADO',p.nombre AS 'NOMBRES',p.apellido AS 'APELLIDOS',d.idPrestamo AS 'CÓDIGO PRÉSTAMO',d.idherramienta AS 'CÓDIGO HERRAMIENTA',h.nombreHerramienta AS 'HERRAMIENTA',d.fechaHora AS 'FECHA-HORA',d.prespor AS 'ASIGNADA POR'
	from Bodega.personal p inner join Bodega.detallePrestamo d 
	on p.id = d.idPersonal inner join Bodega.herramienta h 
	on d.idHerramienta=h.idHerramienta order by p.id asc;
  End
GO
/****** Object:  StoredProcedure [dbo].[ListarDevolucion]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarDevolucion]
  AS BEGIN
  select de.idDevolucion AS 'CÓDIGO DEVOLUCIÓN',p.id AS 'CÓDIGO EMPLEADO',p.nombre AS 'NOMBRES',p.apellido AS 'APELLIDOS',h.idHerramienta AS 'CÓDIGO HERRAMIENTA',
  h.nombreHerramienta AS 'HERRAMIENTA', de.estadoEntre AS 'ESTADO DE ENTREGA',de.prespor AS 'ASIGNADA POR', de.recibidaPor AS 'RECIBIDA POR',de.fechaHora AS 'FECHA-HORA' 
  from bodega.devolucion de inner join bodega.personal p on de.idPersonal=p.id inner join bodega.herramienta h on de.idHerramienta=h.idHerramienta order by de.fechaHora desc;
  end
GO
/****** Object:  StoredProcedure [dbo].[ListarHerramienta]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarHerramienta]
AS BEGIN
select h.idHerramienta AS 'CÓDIGO HERRAMIENTA', h.nombreHerramienta AS 'NOMBRE HERRAMIENTA',
h.idCategoria AS 'CÓDIGO CATEGORÍA', h.uso AS 'USO', h.estado AS 'ESTADO', c.nombreCategoria AS 'CATEGORÍA' 
from Bodega.herramienta h
inner join Bodega.categoria c on h.idCategoria = c.idCategoria
order by nombreHerramienta;
END 
GO
/****** Object:  StoredProcedure [dbo].[ListarHerramientasDefectuosas]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarHerramientasDefectuosas]
as begin
select h.idHerramienta AS 'CÓDIGO HERRAMIENTA', h.nombreHerramienta AS 'NOMBRE HERRAMIENTA', h.estado AS 'ESTADO', c.nombreCategoria AS 'CATEGORÍA' 
from Bodega.herramienta h
inner join Bodega.categoria c on h.idCategoria = c.idCategoria
where h.estado='DEFECTUOSA' order by nombreHerramienta
end
GO
/****** Object:  StoredProcedure [dbo].[ListarHerramientasDisponibles]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarHerramientasDisponibles]
as begin
select h.idHerramienta AS 'CÓDIGO HERRAMIENTA', h.nombreHerramienta AS 'NOMBRE HERRAMIENTA',h.uso AS 'USO', h.estado AS 'ESTADO', c.nombreCategoria AS 'CATEGORÍA' 
from Bodega.herramienta h
inner join Bodega.categoria c on h.idCategoria = c.idCategoria
where h.uso='NO' order by nombreHerramienta
end
GO
/****** Object:  StoredProcedure [dbo].[ListarHerramientasEnUso]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarHerramientasEnUso]
as begin
select h.idHerramienta AS 'CÓDIGO HERRAMIENTA', h.nombreHerramienta AS 'NOMBRE HERRAMIENTA',h.uso AS 'USO', h.estado AS 'ESTADO', c.nombreCategoria AS 'CATEGORÍA' 
from Bodega.herramienta h
inner join Bodega.categoria c on h.idCategoria = c.idCategoria
where h.uso='SI' order by nombreHerramienta
end
GO
/****** Object:  StoredProcedure [dbo].[ListarHerramientasNuevas]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarHerramientasNuevas]
as begin
select h.idHerramienta AS 'CÓDIGO HERRAMIENTA', h.nombreHerramienta AS 'NOMBRE HERRAMIENTA', h.estado AS 'ESTADO', c.nombreCategoria AS 'CATEGORÍA' 
from Bodega.herramienta h
inner join Bodega.categoria c on h.idCategoria = c.idCategoria
where h.estado='NUEVA' order by nombreHerramienta
end
GO
/****** Object:  StoredProcedure [dbo].[ListarHerramientasPPrestamo]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarHerramientasPPrestamo]
as begin
select h.idHerramienta AS 'CÓDIGO HERRAMIENTA', h.nombreHerramienta AS 'NOMBRE HERRAMIENTA', h.estado AS 'ESTADO'
from Bodega.herramienta h where h.uso='NO' and (h.estado='NUEVA' or h.estado='NORMAL')
order by h.nombreHerramienta;
end
GO
/****** Object:  StoredProcedure [dbo].[ListarHistorialPrestamo]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE PROCEDURE [dbo].[ListarHistorialPrestamo]
  As begin
  select p.id AS 'CÓDIGO EMPLEADO',p.nombre AS 'NOMBRES',p.apellido AS 'APELLIDOS',hi.idPrestamoH AS 'CÓDIGO HISTORIAL',hi.idherramienta 'CÓDIGO HERRAMIENTA',
  h.nombreHerramienta AS 'HERRAMIENTA',hi.fechaHora AS 'FECHA-HORA',hi.prespor AS 'ASIGNADA POR' from bodega.personal p 
  inner join bodega.historial hi on p.id = hi.idPersonal inner join bodega.herramienta h 
  on hi.idHerramienta=h.idHerramienta order by hi.fechaHora desc;
  End
GO
/****** Object:  StoredProcedure [dbo].[ListarPersonal]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarPersonal]
as begin
select id as 'CÓDIGO EMPLEADO', nombre as 'NOMBRES', apellido as 'APELLIDOS', edad as 'EDAD'  from Bodega.personal;
end
GO
/****** Object:  StoredProcedure [dbo].[ListarPrestamoPersonal]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[ListarPrestamoPersonal]
  AS BEGIN
  SELECT distinct p.id AS 'CÓDIGO EMPLEADO', p.nombre+ ' ' +p.apellido AS 'NOMBRE COMPLETO' FROM Bodega.personal p inner join bodega.detallePrestamo d on p.id = d.idPersonal ORDER BY p.id
  END
GO
/****** Object:  StoredProcedure [dbo].[ListarTipoUsuario]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarTipoUsuario]
  AS BEGIN
  SELECT 'SELECCIONAR' tipoUsuario UNION Select Distinct tipoUsuario from bodega.usuario order by tipoUsuario desc
  END 
GO
/****** Object:  StoredProcedure [dbo].[ListarUsuario]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE PROCEDURE [dbo].[ListarUsuario]
  AS BEGIN
  SELECT idUsuario AS 'CÓDIGO USUARIO', UserName AS 'NOMBRE DE USUARIO',password, tipoUsuario AS 'TIPO DE USUARIO' FROM Bodega.usuario
  END
GO
/****** Object:  StoredProcedure [dbo].[ModificarCategoria]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[ModificarCategoria]
  @idCategoria int,
  @nombreCategoria Varchar(100) out
  AS BEGIN
  Update Bodega.categoria set nombreCategoria=@nombreCategoria where idCategoria=@idCategoria;
  END

GO
/****** Object:  StoredProcedure [dbo].[ModificarHerramienta]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ModificarHerramienta]
@nombreHerramienta varchar(100),
@idCategoria int,
@uso varchar(50),
@estado varchar(50),
@idHerramienta int out
AS BEGIN
update Bodega.herramienta set nombreHerramienta=@nombreHerramienta, idCategoria=@idCategoria, uso=@uso, estado=@estado where idHerramienta=@idHerramienta;
END 
GO
/****** Object:  StoredProcedure [dbo].[ModificarPersonal]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarPersonal]
@nombre varchar(50),
@apellido varchar(50),
@edad int,
@id int
as begin
update Bodega.personal set nombre=@nombre, apellido=@apellido, edad=@edad where id=@id;
end
GO
/****** Object:  StoredProcedure [dbo].[ModificarUso]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarUso]
@uso varchar(50),
@estado varchar(50),
@idHerramienta int out
AS BEGIN
update Bodega.herramienta set uso=@uso, estado=@estado where idHerramienta=@idHerramienta;
end 
GO
/****** Object:  StoredProcedure [dbo].[ModificarUsuario]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarUsuario]
@idUsuario int,
@userName VARCHAR(50),
@password VARCHAR(100),
@tipoUsuario VARCHAR(50) OUT
AS BEGIN
UPDATE Bodega.usuario SET userName=@userName,password=@password,tipoUsuario=@tipoUsuario WHERE idUsuario=@idUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[RegistrarCategoria]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[RegistrarCategoria]
  @nombreCategoria Varchar(100) out 
  AS BEGIN
  insert Bodega.categoria values (@nombreCategoria);
  END

GO
/****** Object:  StoredProcedure [dbo].[RegistrarDetallePrestamo]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[RegistrarDetallePrestamo]
  @idPersonal INT,
  @idHerramienta INT,
  @fechaHora VARCHAR(50),
  @prespor VARCHAR(50)
  OUT AS BEGIN
  insert Bodega.detalleprestamo values(@idPersonal,@idHerramienta,@fechaHora,@prespor);
  END

GO
/****** Object:  StoredProcedure [dbo].[RegistrarDevolucion]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarDevolucion]
@idHerramienta int,
@idPersonal int,
@estadoEntre varchar(20),
@fechaHora varchar(20),
@prespor varchar(20),
@recibidaPor varchar(20)
as begin
insert into Bodega.devolucion (idHerramienta, idPersonal, estadoEntre, fechaHora, prespor, recibidaPor) 
values(@idHerramienta,@idPersonal,@estadoEntre,@fechaHora,@prespor,@recibidaPor);
end 
GO
/****** Object:  StoredProcedure [dbo].[RegistrarHerramienta]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarHerramienta]
@nombreHerramienta Varchar(100),
@idCategoria int,
@uso Varchar(15),
@estado varchar(15)
OUT AS BEGIN
insert into bodega.herramienta(nombreHerramienta, idCategoria, uso, estado) values (@nombreHerramienta,@idCategoria,@uso,@estado);
END 
GO
/****** Object:  StoredProcedure [dbo].[RegistrarHistorialPrestamo]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarHistorialPrestamo]
  @idPersonal INT,
  @idHerramienta INT,
  @fechaHora VARCHAR(50),
  @prespor VARCHAR(50)
   OUT AS BEGIN
  insert bodega.historial values(@idPersonal,@idHerramienta,@fechaHora,@prespor);
  END
GO
/****** Object:  StoredProcedure [dbo].[RegistrarPersonal]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarPersonal]
@nombre varchar(50),
@apellido varchar(50),
@edad int
as begin
insert into Bodega.personal(nombre, apellido, edad) values(@nombre,@apellido,@edad);
end
GO
/****** Object:  StoredProcedure [dbo].[RegistrarUsuario]    Script Date: 14/11/2019 04:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarUsuario]
@userName VARCHAR(50),
@password VARCHAR(100),
@tipoUsuario VARCHAR(50) OUT
AS BEGIN
INSERT Bodega.usuario VALUES(@userName,@password,@tipoUsuario)
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'bodega.categoria' , @level0type=N'SCHEMA',@level0name=N'bodega', @level1type=N'TABLE',@level1name=N'categoria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'bodega.detalleprestamo' , @level0type=N'SCHEMA',@level0name=N'bodega', @level1type=N'TABLE',@level1name=N'detalleprestamo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'bodega.devolucion' , @level0type=N'SCHEMA',@level0name=N'bodega', @level1type=N'TABLE',@level1name=N'devolucion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'bodega.herramienta' , @level0type=N'SCHEMA',@level0name=N'bodega', @level1type=N'TABLE',@level1name=N'herramienta'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'bodega.historial' , @level0type=N'SCHEMA',@level0name=N'bodega', @level1type=N'TABLE',@level1name=N'historial'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'bodega.personal' , @level0type=N'SCHEMA',@level0name=N'bodega', @level1type=N'TABLE',@level1name=N'personal'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'bodega.usuario' , @level0type=N'SCHEMA',@level0name=N'bodega', @level1type=N'TABLE',@level1name=N'usuario'
GO
USE [master]
GO
ALTER DATABASE [Bodega] SET  READ_WRITE 
GO
