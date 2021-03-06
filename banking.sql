USE [master]
GO
/****** Object:  Database [Record]    Script Date: 29-07-2018 23:43:06 ******/
CREATE DATABASE [Record]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Record', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Record.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Record_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Record_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Record] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Record].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Record] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Record] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Record] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Record] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Record] SET ARITHABORT OFF 
GO
ALTER DATABASE [Record] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Record] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Record] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Record] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Record] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Record] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Record] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Record] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Record] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Record] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Record] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Record] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Record] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Record] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Record] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Record] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Record] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Record] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Record] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Record] SET  MULTI_USER 
GO
ALTER DATABASE [Record] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Record] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Record] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Record] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Record]
GO
/****** Object:  Table [dbo].[BankRecord]    Script Date: 29-07-2018 23:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankRecord](
	[id] [int] NOT NULL,
	[name] [nchar](30) NULL,
	[balance] [int] NULL,
	[type] [nchar](20) NULL,
 CONSTRAINT [PK_BankRecord] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [Record] SET  READ_WRITE 
GO
