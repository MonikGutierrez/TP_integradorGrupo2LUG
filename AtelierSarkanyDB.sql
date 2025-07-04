USE [master]
GO
/****** Object:  Database [AtelierSarkanyDB]    Script Date: 22/06/2025 10:37:25 ******/
CREATE DATABASE [AtelierSarkanyDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AtelierSarkanyDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AtelierSarkanyDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AtelierSarkanyDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\AtelierSarkanyDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AtelierSarkanyDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AtelierSarkanyDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AtelierSarkanyDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [AtelierSarkanyDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AtelierSarkanyDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AtelierSarkanyDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AtelierSarkanyDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AtelierSarkanyDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AtelierSarkanyDB] SET  MULTI_USER 
GO
ALTER DATABASE [AtelierSarkanyDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AtelierSarkanyDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AtelierSarkanyDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AtelierSarkanyDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AtelierSarkanyDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AtelierSarkanyDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [AtelierSarkanyDB] SET QUERY_STORE = OFF
GO
USE [AtelierSarkanyDB]
GO
/****** Object:  Table [dbo].[Calzado]    Script Date: 22/06/2025 10:37:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calzado](
	[id] [int] NOT NULL,
	[numero] [decimal](4, 1) NULL,
	[categoria] [varchar](50) NULL,
	[stockMinimo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 22/06/2025 10:37:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[reservaId] [int] NULL,
	[fechaHora] [datetime] NULL,
	[tipoEstado] [varchar](50) NULL,
	[observaciones] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 22/06/2025 10:37:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
	[email] [varchar](150) NULL,
	[telefono] [varchar](50) NULL,
	[fechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ControlStock]    Script Date: 22/06/2025 10:37:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ControlStock](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[productoId] [int] NULL,
	[tipoMovimiento] [varchar](50) NULL,
	[cantidadAnterior] [int] NULL,
	[cantidadActual] [int] NULL,
	[motivo] [varchar](255) NULL,
	[fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 22/06/2025 10:37:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ventaId] [int] NULL,
	[productoId] [int] NULL,
	[cantidad] [int] NULL,
	[precioUnitario] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pago]    Script Date: 22/06/2025 10:37:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pago](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[monto] [decimal](10, 2) NULL,
	[medioPago] [varchar](50) NULL,
	[tipoPago] [varchar](50) NULL,
	[reservaId] [int] NULL,
	[ventaId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 22/06/2025 10:37:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipoProducto] [varchar](50) NULL,
	[nombre] [varchar](100) NULL,
	[descripcion] [text] NULL,
	[modelo] [varchar](100) NULL,
	[color] [varchar](50) NULL,
	[temporada] [varchar](50) NULL,
	[precio] [decimal](10, 2) NULL,
	[stock] [int] NULL,
	[fechaCreacion] [datetime] NULL,
	[fechaUltimaModificacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 22/06/2025 10:37:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clienteId] [int] NULL,
	[vestidoId] [int] NULL,
	[fechaReserva] [datetime] NULL,
	[fechaExpiracion] [datetime] NULL,
	[montoReservado] [decimal](10, 2) NULL,
	[estado] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 22/06/2025 10:37:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clienteId] [int] NULL,
	[fecha] [datetime] NULL,
	[total] [decimal](10, 2) NULL,
	[estado] [varchar](50) NULL,
	[metodoPago] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vestido]    Script Date: 22/06/2025 10:37:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vestido](
	[id] [int] NOT NULL,
	[talle] [nvarchar](10) NULL,
	[disenador] [nvarchar](100) NULL,
	[estado] [varchar](50) NULL,
	[tiempoAjusteHoras] [int] NULL,
	[nombre] [nvarchar](200) NOT NULL,
	[es_unico] [bit] NULL,
	[fecha_ultimo_ajuste] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Calzado] ([id], [numero], [categoria], [stockMinimo]) VALUES (3, CAST(38.5 AS Decimal(4, 1)), N'Fiesta', 2)
GO
SET IDENTITY_INSERT [dbo].[Cita] ON 

INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (1, 1, CAST(N'2025-06-19T01:22:10.570' AS DateTime), N'Pendiente', N'trabaja')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (2, 1, CAST(N'2025-06-19T01:22:10.570' AS DateTime), N'Pendiente', N'trabaja')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (3, 1, CAST(N'2025-06-18T01:22:10.570' AS DateTime), N'Confirmada', N'llega')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (4, 1, CAST(N'2025-06-18T01:22:10.570' AS DateTime), N'Confirmada', N'llega')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (5, 1, CAST(N'2025-06-18T01:24:10.737' AS DateTime), N'Pendiente', N'a confirmar')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (6, 1, CAST(N'2025-06-18T01:24:10.737' AS DateTime), N'Pendiente', N'a confirmar')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (7, 1, CAST(N'2025-06-28T01:24:10.737' AS DateTime), N'Cancelada', N'por viaje')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (8, 1, CAST(N'2025-06-28T01:24:10.737' AS DateTime), N'Cancelada', N'por viaje')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (9, 1, CAST(N'2025-06-21T20:50:27.063' AS DateTime), N'Confirmada', N'LLEGA 12 HS')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (10, 1, CAST(N'2025-06-21T20:50:27.063' AS DateTime), N'Confirmada', N'LLEGA 12 HS')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (11, 1, CAST(N'2025-06-21T20:50:27.063' AS DateTime), N'Confirmada', N'LLEGA 12 HS')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (12, 2, CAST(N'2025-06-20T20:54:59.617' AS DateTime), N'Pendiente', N'TRABAJANDO ')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (13, 2, CAST(N'2025-06-20T20:54:59.617' AS DateTime), N'Pendiente', N'TRABAJANDO ')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (14, 2, CAST(N'2025-06-20T20:54:59.617' AS DateTime), N'Pendiente', N'TRABAJANDO ')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (15, 3, CAST(N'2025-06-22T21:01:33.133' AS DateTime), N'Pendiente', N'para prueba')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (16, 3, CAST(N'2025-06-22T21:01:33.133' AS DateTime), N'Pendiente', N'para prueba')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (17, 3, CAST(N'2025-06-22T21:01:33.133' AS DateTime), N'Pendiente', N'para prueba')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (18, 2, CAST(N'2025-06-26T21:04:44.257' AS DateTime), N'Cancelada', N'ninguna')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (19, 2, CAST(N'2025-06-26T21:04:44.257' AS DateTime), N'Cancelada', N'ninguna')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (20, 3, CAST(N'2025-06-26T21:04:44.257' AS DateTime), N'Cancelada', N'ninguna')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (21, 3, CAST(N'2025-06-26T21:04:44.257' AS DateTime), N'Cancelada', N'ninguna')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (22, 1, CAST(N'2025-07-03T21:04:44.257' AS DateTime), N'Cancelada', N'ninguna')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (23, 1, CAST(N'2025-07-03T21:04:44.257' AS DateTime), N'Cancelada', N'ninguna')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (24, 2, CAST(N'2025-07-03T21:10:39.497' AS DateTime), N'Cancelada', N'sin motivos')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (25, 2, CAST(N'2025-07-03T21:10:39.497' AS DateTime), N'Cancelada', N'sin motivos')
INSERT [dbo].[Cita] ([id], [reservaId], [fechaHora], [tipoEstado], [observaciones]) VALUES (26, 2, CAST(N'2025-07-04T21:14:36.267' AS DateTime), N'Confirmada', N'ok')
SET IDENTITY_INSERT [dbo].[Cita] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [email], [telefono], [fechaRegistro]) VALUES (1, N'Mónica', N'Gutiérrez', N'monica@example.com', N'2234567890', CAST(N'2025-06-17T00:44:09.847' AS DateTime))
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [email], [telefono], [fechaRegistro]) VALUES (2, N'Luciano', N'Nieto', N'luciano@example.com', N'112233457', CAST(N'2025-06-17T00:44:09.847' AS DateTime))
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [email], [telefono], [fechaRegistro]) VALUES (3, N'Santiago', N'Palomino', N'santiago@example.com', N'1144556677', CAST(N'2025-06-17T00:44:09.847' AS DateTime))
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [email], [telefono], [fechaRegistro]) VALUES (6, N'Cynt', N'Antonelli', N'Cyn@gmail', N'45785466', CAST(N'2025-06-20T20:33:20.083' AS DateTime))
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[DetalleVenta] ON 

INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1, 1, 2, 3, CAST(45000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[DetalleVenta] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([id], [tipoProducto], [nombre], [descripcion], [modelo], [color], [temporada], [precio], [stock], [fechaCreacion], [fechaUltimaModificacion]) VALUES (1, N'Vestido', N'Vestido Gala', N'Vestido largo elegante', N'VG2024', N'Rojo', N'Verano', CAST(50000.00 AS Decimal(10, 2)), 5, CAST(N'2025-06-17T00:45:37.257' AS DateTime), CAST(N'2025-06-17T00:45:37.257' AS DateTime))
INSERT [dbo].[Producto] ([id], [tipoProducto], [nombre], [descripcion], [modelo], [color], [temporada], [precio], [stock], [fechaCreacion], [fechaUltimaModificacion]) VALUES (2, N'Vestido', N'Vestido Coctel', N'Vestido corto para eventos', N'VC2024', N'Negro', N'Otoño', CAST(45000.00 AS Decimal(10, 2)), 3, CAST(N'2025-06-17T00:45:37.257' AS DateTime), CAST(N'2025-06-17T00:45:37.257' AS DateTime))
INSERT [dbo].[Producto] ([id], [tipoProducto], [nombre], [descripcion], [modelo], [color], [temporada], [precio], [stock], [fechaCreacion], [fechaUltimaModificacion]) VALUES (3, N'Calzado', N'Zapato Fiesta', N'Zapato con taco alto', N'ZF2024', N'Dorado', N'Invierno', CAST(38000.00 AS Decimal(10, 2)), 10, CAST(N'2025-06-17T00:45:37.257' AS DateTime), CAST(N'2025-06-17T00:45:37.257' AS DateTime))
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Reserva] ON 

INSERT [dbo].[Reserva] ([id], [clienteId], [vestidoId], [fechaReserva], [fechaExpiracion], [montoReservado], [estado]) VALUES (1, 1, 1, CAST(N'2025-06-17T00:59:20.207' AS DateTime), CAST(N'2025-06-24T00:59:20.207' AS DateTime), CAST(25000.00 AS Decimal(10, 2)), N'Activa')
INSERT [dbo].[Reserva] ([id], [clienteId], [vestidoId], [fechaReserva], [fechaExpiracion], [montoReservado], [estado]) VALUES (2, 2, 2, CAST(N'2025-06-19T00:00:00.000' AS DateTime), CAST(N'2025-06-20T00:00:00.000' AS DateTime), CAST(10000.00 AS Decimal(10, 2)), N'Activa')
INSERT [dbo].[Reserva] ([id], [clienteId], [vestidoId], [fechaReserva], [fechaExpiracion], [montoReservado], [estado]) VALUES (3, 2, 2, CAST(N'2025-06-19T00:00:00.000' AS DateTime), CAST(N'2025-06-20T00:00:00.000' AS DateTime), CAST(10000.00 AS Decimal(10, 2)), N'Activa')
INSERT [dbo].[Reserva] ([id], [clienteId], [vestidoId], [fechaReserva], [fechaExpiracion], [montoReservado], [estado]) VALUES (4, 1, 2, CAST(N'2025-06-21T00:00:00.000' AS DateTime), CAST(N'2025-06-23T00:00:00.000' AS DateTime), CAST(150000.00 AS Decimal(10, 2)), N'Activa')
INSERT [dbo].[Reserva] ([id], [clienteId], [vestidoId], [fechaReserva], [fechaExpiracion], [montoReservado], [estado]) VALUES (5, 3, 2, CAST(N'2025-06-21T00:00:00.000' AS DateTime), CAST(N'2025-06-23T00:00:00.000' AS DateTime), CAST(45000.00 AS Decimal(10, 2)), N'Activa')
INSERT [dbo].[Reserva] ([id], [clienteId], [vestidoId], [fechaReserva], [fechaExpiracion], [montoReservado], [estado]) VALUES (6, 1, 1, CAST(N'2025-07-05T00:00:00.000' AS DateTime), CAST(N'2025-07-06T00:00:00.000' AS DateTime), CAST(30000.00 AS Decimal(10, 2)), N'Activa')
INSERT [dbo].[Reserva] ([id], [clienteId], [vestidoId], [fechaReserva], [fechaExpiracion], [montoReservado], [estado]) VALUES (7, 6, 1, CAST(N'2025-06-26T00:00:00.000' AS DateTime), CAST(N'2025-08-21T00:00:00.000' AS DateTime), CAST(100.00 AS Decimal(10, 2)), N'Anulada')
INSERT [dbo].[Reserva] ([id], [clienteId], [vestidoId], [fechaReserva], [fechaExpiracion], [montoReservado], [estado]) VALUES (8, 1, 1, CAST(N'2025-07-13T00:00:00.000' AS DateTime), CAST(N'2025-08-15T00:00:00.000' AS DateTime), CAST(2100.00 AS Decimal(10, 2)), N'Activa')
SET IDENTITY_INSERT [dbo].[Reserva] OFF
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total], [estado], [metodoPago]) VALUES (1, 3, CAST(N'2025-06-17T02:32:29.590' AS DateTime), CAST(135000.00 AS Decimal(10, 2)), N'Finalizada', N'Efectivo')
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
INSERT [dbo].[Vestido] ([id], [talle], [disenador], [estado], [tiempoAjusteHoras], [nombre], [es_unico], [fecha_ultimo_ajuste]) VALUES (1, N'M', N'Laura Pardo', N'Disponible', 3, N'SIN NOMBRE', NULL, NULL)
INSERT [dbo].[Vestido] ([id], [talle], [disenador], [estado], [tiempoAjusteHoras], [nombre], [es_unico], [fecha_ultimo_ajuste]) VALUES (2, N'S', N'Carla Ruiz', N'Disponible', 2, N'SIN NOMBRE', NULL, NULL)
GO
ALTER TABLE [dbo].[Vestido] ADD  DEFAULT ('SIN NOMBRE') FOR [nombre]
GO
ALTER TABLE [dbo].[Vestido] ADD  DEFAULT ((1)) FOR [es_unico]
GO
ALTER TABLE [dbo].[Calzado]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[Producto] ([id])
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD FOREIGN KEY([reservaId])
REFERENCES [dbo].[Reserva] ([id])
GO
ALTER TABLE [dbo].[ControlStock]  WITH CHECK ADD FOREIGN KEY([productoId])
REFERENCES [dbo].[Producto] ([id])
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD FOREIGN KEY([productoId])
REFERENCES [dbo].[Producto] ([id])
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD FOREIGN KEY([ventaId])
REFERENCES [dbo].[Venta] ([id])
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD FOREIGN KEY([reservaId])
REFERENCES [dbo].[Reserva] ([id])
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD FOREIGN KEY([ventaId])
REFERENCES [dbo].[Venta] ([id])
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD FOREIGN KEY([clienteId])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD FOREIGN KEY([vestidoId])
REFERENCES [dbo].[Vestido] ([id])
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD FOREIGN KEY([clienteId])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Vestido]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[Producto] ([id])
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD CHECK  (([reservaId] IS NOT NULL OR [ventaId] IS NOT NULL))
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD CHECK  (([tipoProducto]='Calzado' OR [tipoProducto]='Vestido'))
GO
ALTER TABLE [dbo].[Vestido]  WITH CHECK ADD  CONSTRAINT [CHK_EstadoVestido_Valido] CHECK  (([estado]='DADO DE BAJA' OR [estado]='EN REVISIÓN' OR [estado]='DEVUELTO' OR [estado]='EN LAVADO' OR [estado]='VENDIDO' OR [estado]='EN AJUSTE' OR [estado]='RESERVADO' OR [estado]='DISPONIBLE'))
GO
ALTER TABLE [dbo].[Vestido] CHECK CONSTRAINT [CHK_EstadoVestido_Valido]
GO
USE [master]
GO
ALTER DATABASE [AtelierSarkanyDB] SET  READ_WRITE 
GO
