USE [master]
GO
/****** Object:  Database [Proyecto]    Script Date: 01/05/2019 14:14:04 ******/
CREATE DATABASE [Proyecto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Proyecto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Proyecto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Proyecto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Proyecto_log.ldf' , SIZE = 139264KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Proyecto] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Proyecto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Proyecto] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Proyecto] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Proyecto] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Proyecto] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Proyecto] SET ARITHABORT OFF 
GO
ALTER DATABASE [Proyecto] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Proyecto] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Proyecto] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Proyecto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Proyecto] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Proyecto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Proyecto] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Proyecto] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Proyecto] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Proyecto] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Proyecto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Proyecto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Proyecto] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Proyecto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Proyecto] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Proyecto] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Proyecto] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Proyecto] SET RECOVERY FULL 
GO
ALTER DATABASE [Proyecto] SET  MULTI_USER 
GO
ALTER DATABASE [Proyecto] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Proyecto] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Proyecto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Proyecto] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Proyecto] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Proyecto', N'ON'
GO
ALTER DATABASE [Proyecto] SET QUERY_STORE = OFF
GO
USE [Proyecto]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Proyecto]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 01/05/2019 14:14:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[id_cat] [int] NOT NULL,
	[tipo] [varchar](20) NULL,
	[tiempo] [int] NULL,
	[puntaje_min] [int] NULL,
	[puntaje_max] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[consulta]    Script Date: 01/05/2019 14:14:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[consulta](
	[id_consulta] [int] NOT NULL,
	[id_paciente] [int] NULL,
	[id_doc] [int] NULL,
	[fechalleg] [datetime] NULL,
	[id_categoria] [int] NULL,
	[puntaje_obt] [int] NULL,
	[atencion] [varchar](20) NULL,
	[id_estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_consulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[consulta_sintoma]    Script Date: 01/05/2019 14:14:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[consulta_sintoma](
	[id_consulta] [int] NULL,
	[id_sintoma] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[especialidad]    Script Date: 01/05/2019 14:14:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[especialidad](
	[id] [int] NOT NULL,
	[Nombre_espec] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado]    Script Date: 01/05/2019 14:14:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado](
	[id_estado] [int] NOT NULL,
	[estado] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado_user]    Script Date: 01/05/2019 14:14:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado_user](
	[id_estado_user] [int] NOT NULL,
	[estado] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paciente]    Script Date: 01/05/2019 14:14:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paciente](
	[id_pac] [int] NOT NULL,
	[nombre] [varchar](25) NULL,
	[apellido] [varchar](25) NULL,
	[edad] [int] NULL,
	[telefono] [varchar](9) NULL,
	[direccion] [varchar](100) NULL,
	[tipoSangre] [varchar](10) NULL,
	[Nombre_contacto] [varchar](50) NULL,
	[telefono_contacto] [varchar](9) NULL,
	[id_estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pr]    Script Date: 01/05/2019 14:14:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pr](
	[ide] [int] NOT NULL,
	[dato] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ide] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sintoma]    Script Date: 01/05/2019 14:14:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sintoma](
	[id_sin] [int] NOT NULL,
	[sintoma] [varchar](50) NULL,
	[puntaje] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_sin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 01/05/2019 14:14:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_user] [int] NOT NULL,
	[nombre] [varchar](25) NULL,
	[apellido] [varchar](25) NULL,
	[edad] [int] NULL,
	[telefono] [varchar](9) NULL,
	[usuario] [varchar](20) NULL,
	[pass] [varchar](100) NULL,
	[id_especial] [int] NULL,
	[id_estado_user] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[categoria] ([id_cat], [tipo], [tiempo], [puntaje_min], [puntaje_max]) VALUES (0, N'Critico', 0, 200, 1000)
INSERT [dbo].[categoria] ([id_cat], [tipo], [tiempo], [puntaje_min], [puntaje_max]) VALUES (1, N'Emergencia', 10, 151, 199)
INSERT [dbo].[categoria] ([id_cat], [tipo], [tiempo], [puntaje_min], [puntaje_max]) VALUES (2, N'Urgencia', 60, 100, 150)
INSERT [dbo].[categoria] ([id_cat], [tipo], [tiempo], [puntaje_min], [puntaje_max]) VALUES (3, N'Estandar', 120, 35, 99)
INSERT [dbo].[categoria] ([id_cat], [tipo], [tiempo], [puntaje_min], [puntaje_max]) VALUES (4, N'No urgente', 240, 0, 34)
INSERT [dbo].[consulta] ([id_consulta], [id_paciente], [id_doc], [fechalleg], [id_categoria], [puntaje_obt], [atencion], [id_estado]) VALUES (0, 0, 0, CAST(N'2019-05-01T06:50:30.547' AS DateTime), 0, 180, N'12:51:17.3965751', 0)
INSERT [dbo].[consulta] ([id_consulta], [id_paciente], [id_doc], [fechalleg], [id_categoria], [puntaje_obt], [atencion], [id_estado]) VALUES (1, 1, 1, CAST(N'2019-05-01T06:50:51.083' AS DateTime), 0, 103, N'14:02:13.8364417', 0)
INSERT [dbo].[consulta] ([id_consulta], [id_paciente], [id_doc], [fechalleg], [id_categoria], [puntaje_obt], [atencion], [id_estado]) VALUES (2, 0, 2, CAST(N'2019-05-01T06:52:05.640' AS DateTime), 2, 90, N'14:50:47.4009455', 0)
INSERT [dbo].[consulta] ([id_consulta], [id_paciente], [id_doc], [fechalleg], [id_categoria], [puntaje_obt], [atencion], [id_estado]) VALUES (3, 3, 1, CAST(N'2019-05-01T07:00:49.540' AS DateTime), 3, 10, N'15:50:47.4019429', 0)
INSERT [dbo].[consulta] ([id_consulta], [id_paciente], [id_doc], [fechalleg], [id_categoria], [puntaje_obt], [atencion], [id_estado]) VALUES (4, 2, 2, CAST(N'2019-05-01T07:08:08.097' AS DateTime), 0, 190, N'13:50:47.2766699', 1)
INSERT [dbo].[consulta_sintoma] ([id_consulta], [id_sintoma]) VALUES (0, 0)
INSERT [dbo].[consulta_sintoma] ([id_consulta], [id_sintoma]) VALUES (0, 1)
INSERT [dbo].[consulta_sintoma] ([id_consulta], [id_sintoma]) VALUES (0, 2)
INSERT [dbo].[consulta_sintoma] ([id_consulta], [id_sintoma]) VALUES (1, 6)
INSERT [dbo].[consulta_sintoma] ([id_consulta], [id_sintoma]) VALUES (1, 7)
INSERT [dbo].[consulta_sintoma] ([id_consulta], [id_sintoma]) VALUES (1, 8)
INSERT [dbo].[consulta_sintoma] ([id_consulta], [id_sintoma]) VALUES (2, 0)
INSERT [dbo].[consulta_sintoma] ([id_consulta], [id_sintoma]) VALUES (3, 4)
INSERT [dbo].[consulta_sintoma] ([id_consulta], [id_sintoma]) VALUES (4, 1)
INSERT [dbo].[consulta_sintoma] ([id_consulta], [id_sintoma]) VALUES (4, 2)
INSERT [dbo].[consulta_sintoma] ([id_consulta], [id_sintoma]) VALUES (4, 3)
INSERT [dbo].[consulta_sintoma] ([id_consulta], [id_sintoma]) VALUES (4, 4)
INSERT [dbo].[consulta_sintoma] ([id_consulta], [id_sintoma]) VALUES (4, 5)
INSERT [dbo].[especialidad] ([id], [Nombre_espec]) VALUES (0, N'oftalmologo')
INSERT [dbo].[especialidad] ([id], [Nombre_espec]) VALUES (1, N'General')
INSERT [dbo].[especialidad] ([id], [Nombre_espec]) VALUES (2, N'enfermera')
INSERT [dbo].[especialidad] ([id], [Nombre_espec]) VALUES (3, N'Director')
INSERT [dbo].[estado] ([id_estado], [estado]) VALUES (0, N'Activa')
INSERT [dbo].[estado] ([id_estado], [estado]) VALUES (1, N'Inactiva')
INSERT [dbo].[estado_user] ([id_estado_user], [estado]) VALUES (0, N'Activo')
INSERT [dbo].[estado_user] ([id_estado_user], [estado]) VALUES (1, N'Inactivo')
INSERT [dbo].[paciente] ([id_pac], [nombre], [apellido], [edad], [telefono], [direccion], [tipoSangre], [Nombre_contacto], [telefono_contacto], [id_estado]) VALUES (0, N'lucas', N'prueba', 26, N'1234-4411', N'ciudadela', N'tipo nose', N'juan perez', N'1212-1013', 0)
INSERT [dbo].[paciente] ([id_pac], [nombre], [apellido], [edad], [telefono], [direccion], [tipoSangre], [Nombre_contacto], [telefono_contacto], [id_estado]) VALUES (1, N'alberto', N'rodriguez', 15, N'7788-1210', N'samboya de otro', N'tipo rh+', N'juan perez', N'7410-2010', 0)
INSERT [dbo].[paciente] ([id_pac], [nombre], [apellido], [edad], [telefono], [direccion], [tipoSangre], [Nombre_contacto], [telefono_contacto], [id_estado]) VALUES (2, N'roberto ', N'torres', 35, N'1234-4561', N'colonia', N'tipo a 1', N'pedro', N'4561-5551', 0)
INSERT [dbo].[paciente] ([id_pac], [nombre], [apellido], [edad], [telefono], [direccion], [tipoSangre], [Nombre_contacto], [telefono_contacto], [id_estado]) VALUES (3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[paciente] ([id_pac], [nombre], [apellido], [edad], [telefono], [direccion], [tipoSangre], [Nombre_contacto], [telefono_contacto], [id_estado]) VALUES (4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[pr] ([ide], [dato]) VALUES (0, CAST(N'2019-04-15T19:52:00.450' AS DateTime))
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (0, N'Ninguna respuesta verbal', 90)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (1, N'Sonidos verbales incompresibles ', 55)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (2, N'Palabras inapropiadas ', 35)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (3, N'Desorientado', 15)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (4, N'Orientado y conversando', 10)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (5, N'Ninguna respuesta ocular', 75)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (6, N'Seguir con la vista indicaciones verbales', 35)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (7, N'Ninguna respuesta motora ', 100)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (8, N'Extensión anormal ', 68)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (9, N'Flexión anormal ', 51)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (10, N'Retirada y flexión ', 35)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (11, N'Localiza el dolor ', 18)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (12, N'Obedece órdenes verbales', 11)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (13, N'Tos emetizante ', 55)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (14, N'Apnea', 25)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (15, N'Tos bitonal', 15)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (16, N'hemoptisis', 40)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (17, N'Sincope ', 65)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (18, N'Infarto de miocardio ', 100)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (19, N'Dolor aórtico ', 90)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (20, N'Hemorragia interna', 60)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (21, N'Perdida de un miembro', 75)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (22, N'Introducción de objeto corto punzante', 40)
INSERT [dbo].[sintoma] ([id_sin], [sintoma], [puntaje]) VALUES (23, N'Herida por arma de fuego', 50)
INSERT [dbo].[usuarios] ([id_user], [nombre], [apellido], [edad], [telefono], [usuario], [pass], [id_especial], [id_estado_user]) VALUES (0, N'Leyenda', N'Eterna', 22, N'7777-1111', N'leyenda', N'1234', 3, 0)
INSERT [dbo].[usuarios] ([id_user], [nombre], [apellido], [edad], [telefono], [usuario], [pass], [id_especial], [id_estado_user]) VALUES (1, N'enfer', N'apel enfer', 23, N'1234-1234', N'enfer1', N'123', 2, 0)
INSERT [dbo].[usuarios] ([id_user], [nombre], [apellido], [edad], [telefono], [usuario], [pass], [id_especial], [id_estado_user]) VALUES (2, N'probando nombre', N'probando apellido', 25, N'7512-1256', N'usuario', N'12345', 1, 0)
INSERT [dbo].[usuarios] ([id_user], [nombre], [apellido], [edad], [telefono], [usuario], [pass], [id_especial], [id_estado_user]) VALUES (3, N'Use nombre', N'Use apellido', 35, N'7545-4512', N'usuarioG', N'12345', 1, 0)
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categoria] ([id_cat])
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD FOREIGN KEY([id_doc])
REFERENCES [dbo].[usuarios] ([id_user])
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD FOREIGN KEY([id_estado])
REFERENCES [dbo].[estado] ([id_estado])
GO
ALTER TABLE [dbo].[consulta]  WITH CHECK ADD FOREIGN KEY([id_paciente])
REFERENCES [dbo].[paciente] ([id_pac])
GO
ALTER TABLE [dbo].[consulta_sintoma]  WITH CHECK ADD FOREIGN KEY([id_consulta])
REFERENCES [dbo].[consulta] ([id_consulta])
GO
ALTER TABLE [dbo].[consulta_sintoma]  WITH CHECK ADD FOREIGN KEY([id_sintoma])
REFERENCES [dbo].[sintoma] ([id_sin])
GO
ALTER TABLE [dbo].[paciente]  WITH CHECK ADD FOREIGN KEY([id_estado])
REFERENCES [dbo].[estado_user] ([id_estado_user])
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD FOREIGN KEY([id_especial])
REFERENCES [dbo].[especialidad] ([id])
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD FOREIGN KEY([id_estado_user])
REFERENCES [dbo].[estado_user] ([id_estado_user])
GO
USE [master]
GO
ALTER DATABASE [Proyecto] SET  READ_WRITE 
GO
