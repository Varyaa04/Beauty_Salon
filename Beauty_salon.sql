USE [master]
GO
ALTER DATABASE [Beauty_Salon] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Beauty_Salon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Beauty_Salon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Beauty_Salon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Beauty_Salon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Beauty_Salon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Beauty_Salon] SET ARITHABORT OFF 
GO
ALTER DATABASE [Beauty_Salon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Beauty_Salon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Beauty_Salon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Beauty_Salon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Beauty_Salon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Beauty_Salon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Beauty_Salon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Beauty_Salon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Beauty_Salon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Beauty_Salon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Beauty_Salon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Beauty_Salon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Beauty_Salon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Beauty_Salon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Beauty_Salon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Beauty_Salon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Beauty_Salon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Beauty_Salon] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Beauty_Salon] SET  MULTI_USER 
GO
ALTER DATABASE [Beauty_Salon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Beauty_Salon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Beauty_Salon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Beauty_Salon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Beauty_Salon] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Beauty_Salon] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Beauty_Salon] SET QUERY_STORE = ON
GO
ALTER DATABASE [Beauty_Salon] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Beauty_Salon]
GO
/****** Object:  Table [dbo].[Master_name]    Script Date: 10.02.2024 0:43:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Master_name](
	[idMaster_name] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Lastname] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Master_name] PRIMARY KEY CLUSTERED 
(
	[idMaster_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provision_of_Service]    Script Date: 10.02.2024 0:43:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provision_of_Service](
	[idProvision_of_Service] [int] IDENTITY(1,1) NOT NULL,
	[Master_name] [int] NOT NULL,
	[Type_of_Service] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Price] [float] NOT NULL,
	[Discount] [float] NOT NULL,
	[MasterShare] [float] NOT NULL,
 CONSTRAINT [PK_Provision_of_Service] PRIMARY KEY CLUSTERED 
(
	[idProvision_of_Service] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type_of_Service]    Script Date: 10.02.2024 0:43:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type_of_Service](
	[idType_of_Service] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Type_of_Service] PRIMARY KEY CLUSTERED 
(
	[idType_of_Service] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Provision_of_Service]  WITH CHECK ADD  CONSTRAINT [FK_Provision_of_Service_Master_name] FOREIGN KEY([Master_name])
REFERENCES [dbo].[Master_name] ([idMaster_name])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Provision_of_Service] CHECK CONSTRAINT [FK_Provision_of_Service_Master_name]
GO
ALTER TABLE [dbo].[Provision_of_Service]  WITH CHECK ADD  CONSTRAINT [FK_Provision_of_Service_Type_of_Service] FOREIGN KEY([Type_of_Service])
REFERENCES [dbo].[Type_of_Service] ([idType_of_Service])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Provision_of_Service] CHECK CONSTRAINT [FK_Provision_of_Service_Type_of_Service]
GO
USE [master]
GO
ALTER DATABASE [Beauty_Salon] SET  READ_WRITE 
GO
