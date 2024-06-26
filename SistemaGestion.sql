USE [master]
GO
/****** Object:  Database [SistemaGestion]    Script Date: 15/06/2024 14:20:14 ******/
CREATE DATABASE [SistemaGestion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaGestion', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SistemaGestion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SistemaGestion_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SistemaGestion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SistemaGestion] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaGestion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaGestion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaGestion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaGestion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaGestion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaGestion] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaGestion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SistemaGestion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaGestion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaGestion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaGestion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaGestion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaGestion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaGestion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaGestion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaGestion] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SistemaGestion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaGestion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaGestion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaGestion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaGestion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaGestion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaGestion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaGestion] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SistemaGestion] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaGestion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaGestion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaGestion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaGestion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SistemaGestion] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SistemaGestion] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SistemaGestion] SET QUERY_STORE = OFF
GO
USE [SistemaGestion]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 15/06/2024 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Costo] [decimal](10, 2) NOT NULL,
	[PrecioVenta] [decimal](10, 2) NOT NULL,
	[Stock] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoVendido]    Script Date: 15/06/2024 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoVendido](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Stock] [decimal](10, 2) NOT NULL,
	[IdVenta] [decimal](10, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 15/06/2024 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](40) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[Contrasenia] [varchar](20) NOT NULL,
	[Mail] [varchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 15/06/2024 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Comentarios] [varchar](50) NOT NULL,
	[IdUsuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [SistemaGestion] SET  READ_WRITE 
GO
