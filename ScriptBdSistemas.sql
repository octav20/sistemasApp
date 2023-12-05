USE [master]
GO
/****** Object:  Database [CrudBasico]    Script Date: 04/12/2023 06:47:27 p. m. ******/
CREATE DATABASE [CrudBasico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CrudBasico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CrudBasico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CrudBasico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CrudBasico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CrudBasico] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CrudBasico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CrudBasico] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CrudBasico] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CrudBasico] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CrudBasico] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CrudBasico] SET ARITHABORT OFF 
GO
ALTER DATABASE [CrudBasico] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CrudBasico] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CrudBasico] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CrudBasico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CrudBasico] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CrudBasico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CrudBasico] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CrudBasico] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CrudBasico] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CrudBasico] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CrudBasico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CrudBasico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CrudBasico] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CrudBasico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CrudBasico] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CrudBasico] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CrudBasico] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CrudBasico] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CrudBasico] SET  MULTI_USER 
GO
ALTER DATABASE [CrudBasico] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CrudBasico] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CrudBasico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CrudBasico] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CrudBasico] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CrudBasico] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CrudBasico] SET QUERY_STORE = ON
GO
ALTER DATABASE [CrudBasico] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CrudBasico]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 04/12/2023 06:47:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(100000,1) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
	[Apellido] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Telefono] [nvarchar](15) NOT NULL,
	[Direccion] [nvarchar](255) NOT NULL,
	[Latitud] [nvarchar](20) NOT NULL,
	[Longitud] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 04/12/2023 06:47:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(100000,1) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
	[Apellido] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[FechaNac] [nvarchar](10) NOT NULL,
	[Telefono] [nvarchar](15) NOT NULL,
	[Direccion] [nvarchar](255) NOT NULL,
	[Latitud] [nvarchar](20) NOT NULL,
	[Longitud] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 04/12/2023 06:47:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id] [int] IDENTITY(100000,1) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
	[Apellido] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Telefono] [nvarchar](15) NOT NULL,
	[Direccion] [nvarchar](255) NOT NULL,
	[Latitud] [nvarchar](20) NOT NULL,
	[Longitud] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 04/12/2023 06:47:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[Id] [int] IDENTITY(100000,1) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
	[Apellido] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Telefono] [nvarchar](15) NOT NULL,
	[Direccion] [nvarchar](255) NOT NULL,
	[Latitud] [nvarchar](20) NOT NULL,
	[Longitud] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [CrudBasico] SET  READ_WRITE 
GO
