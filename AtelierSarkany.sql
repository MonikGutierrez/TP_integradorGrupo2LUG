USE [AtelierSarkany]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 14/07/2025 1:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clienteId] [int] NOT NULL,
	[fechaHora] [datetime] NOT NULL,
	[tipoEstado] [varchar](50) NOT NULL,
	[observaciones] [varchar](100) NULL,
 CONSTRAINT [PK__Cita__3214EC07F4BCADBC] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 14/07/2025 1:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](8) NULL,
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
	[email] [varchar](150) NULL,
	[telefono] [varchar](50) NULL,
	[fechaRegistro] [datetime] NULL,
 CONSTRAINT [PK__Cliente__3213E83FCEB9DE56] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 14/07/2025 1:40:15 ******/
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
/****** Object:  Table [dbo].[Pago]    Script Date: 14/07/2025 1:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pago](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[monto] [decimal](10, 2) NULL,
	[medioPago] [varchar](50) NULL,
	[ventaId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 14/07/2025 1:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[descripcion] [text] NULL,
	[modelo] [varchar](100) NULL,
	[color] [varchar](50) NULL,
	[temporada] [varchar](50) NULL,
	[precio] [decimal](10, 2) NULL,
	[stock] [int] NULL,
	[fechaCreacion] [datetime] NULL,
	[fechaUltimaModificacion] [datetime] NULL,
	[talle] [nvarchar](10) NULL,
	[disenador] [nvarchar](100) NULL,
	[estado] [varchar](50) NULL,
	[tiempoAjusteHoras] [int] NULL,
	[es_unico] [bit] NULL,
	[numero] [decimal](4, 1) NULL,
	[categoria] [varchar](50) NULL,
	[stockMinimo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 14/07/2025 1:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clienteId] [int] NULL,
	[fecha] [datetime] NULL,
	[total] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cita] ON 

INSERT [dbo].[Cita] ([id], [clienteId], [fechaHora], [tipoEstado], [observaciones]) VALUES (1, 1, CAST(N'2025-07-13T10:00:00.000' AS DateTime), N'Pendiente', N'Primera prueba de vestido')
INSERT [dbo].[Cita] ([id], [clienteId], [fechaHora], [tipoEstado], [observaciones]) VALUES (2, 2, CAST(N'2025-07-16T11:00:00.000' AS DateTime), N'No asistió', N'Cliente no se presentó')
INSERT [dbo].[Cita] ([id], [clienteId], [fechaHora], [tipoEstado], [observaciones]) VALUES (3, 3, CAST(N'2025-07-17T13:00:00.000' AS DateTime), N'Cancelada', N'Cancelada por viaje del cliente')
INSERT [dbo].[Cita] ([id], [clienteId], [fechaHora], [tipoEstado], [observaciones]) VALUES (5, 4, CAST(N'2025-07-13T11:49:35.123' AS DateTime), N'Cancelada', N'Va a reagendar')
INSERT [dbo].[Cita] ([id], [clienteId], [fechaHora], [tipoEstado], [observaciones]) VALUES (9, 7, CAST(N'2025-07-24T23:06:37.487' AS DateTime), N'Pendiente', N'Llamar para confirmar asistencia')
SET IDENTITY_INSERT [dbo].[Cita] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([id], [dni], [nombre], [apellido], [email], [telefono], [fechaRegistro]) VALUES (1, N'11111111', N'Cynthia ', N'Della Maggiora', N'cynthia.antonella@mail.com', N'11111111111111', CAST(N'2025-07-12T14:30:00.000' AS DateTime))
INSERT [dbo].[Cliente] ([id], [dni], [nombre], [apellido], [email], [telefono], [fechaRegistro]) VALUES (2, N'22222222', N'Horacio', N'Arevalo', N'hora.mail@mail.com.ar', N'22222222222222', CAST(N'2025-07-12T14:30:00.000' AS DateTime))
INSERT [dbo].[Cliente] ([id], [dni], [nombre], [apellido], [email], [telefono], [fechaRegistro]) VALUES (3, N'33333333', N'Monica', N'Gutierrez', N'mailmoni@mail.com', N'1111111111122', CAST(N'2025-07-12T14:30:00.000' AS DateTime))
INSERT [dbo].[Cliente] ([id], [dni], [nombre], [apellido], [email], [telefono], [fechaRegistro]) VALUES (4, N'44444444', N'Micaela', N'Barrau', N'micabarrau@mail.com', N'1111122222222', CAST(N'2025-07-12T14:30:00.000' AS DateTime))
INSERT [dbo].[Cliente] ([id], [dni], [nombre], [apellido], [email], [telefono], [fechaRegistro]) VALUES (7, N'12245678', N'Yvaine', N'Arevalo', N'hola@hola', N'1111112111111', CAST(N'2025-07-12T18:08:19.470' AS DateTime))
INSERT [dbo].[Cliente] ([id], [dni], [nombre], [apellido], [email], [telefono], [fechaRegistro]) VALUES (8, N'12345777', N'Laura', N'Bruno', N'hola@hola', N'1111111111111', CAST(N'2025-07-13T11:32:43.050' AS DateTime))
INSERT [dbo].[Cliente] ([id], [dni], [nombre], [apellido], [email], [telefono], [fechaRegistro]) VALUES (9, N'12345444', N'Julieta', N'Gomez', N'hola@hol', N'1111111111111', CAST(N'2025-07-13T11:33:32.153' AS DateTime))
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[DetalleVenta] ON 

INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1, 1, 1, 1, CAST(10000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (2, 1, 2, 1, CAST(100000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (3, 2, 1, 2, CAST(10000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1002, 1002, 1, 2, CAST(10000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1003, 1002, 2, 4, CAST(1000000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1004, 1003, 1, 2, CAST(10000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1005, 1003, 2, 4, CAST(1000000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1006, 1004, 1, 2, CAST(10000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1007, 1004, 2, 4, CAST(1000000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1008, 1005, 1, 2, CAST(10000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1009, 1005, 2, 4, CAST(1000000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1010, 1006, 1, 2, CAST(10000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1011, 1006, 2, 4, CAST(1000000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1012, 1007, 1, 2, CAST(10000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1013, 1007, 2, 4, CAST(1000000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1014, 1008, 3, 1, CAST(30000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1015, 1009, 1009, 2, CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1016, 1010, 1010, 2, CAST(200000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1017, 1011, 1010, 2, CAST(200000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1018, 1012, 1, 2, CAST(10000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1019, 1012, 1009, 1, CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1020, 1013, 1009, 2, CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1023, 1015, 1011, 2, CAST(105000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1028, 1018, 8, 1, CAST(45000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1029, 1019, 1010, 1, CAST(200000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1030, 1019, 1010, 4, CAST(200000.00 AS Decimal(10, 2)))
INSERT [dbo].[DetalleVenta] ([id], [ventaId], [productoId], [cantidad], [precioUnitario]) VALUES (1032, 1021, 1011, 2, CAST(105000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[DetalleVenta] OFF
GO
SET IDENTITY_INSERT [dbo].[Pago] ON 

INSERT [dbo].[Pago] ([id], [fecha], [monto], [medioPago], [ventaId]) VALUES (2, CAST(N'2025-07-12T19:55:11.000' AS DateTime), CAST(10000.00 AS Decimal(10, 2)), N'Transferencia', 1)
INSERT [dbo].[Pago] ([id], [fecha], [monto], [medioPago], [ventaId]) VALUES (3, CAST(N'2025-07-12T19:55:11.000' AS DateTime), CAST(100000.00 AS Decimal(10, 2)), N'Efectivo', 2)
INSERT [dbo].[Pago] ([id], [fecha], [monto], [medioPago], [ventaId]) VALUES (5, CAST(N'2025-07-30T19:41:55.670' AS DateTime), CAST(25000.00 AS Decimal(10, 2)), N'Transferencia', 2)
INSERT [dbo].[Pago] ([id], [fecha], [monto], [medioPago], [ventaId]) VALUES (9, CAST(N'2025-07-13T23:49:28.500' AS DateTime), CAST(45000.00 AS Decimal(10, 2)), N'Transferencia', 1018)
SET IDENTITY_INSERT [dbo].[Pago] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [modelo], [color], [temporada], [precio], [stock], [fechaCreacion], [fechaUltimaModificacion], [talle], [disenador], [estado], [tiempoAjusteHoras], [es_unico], [numero], [categoria], [stockMinimo]) VALUES (1, N'Filomena', N'Vestido de noche', N'Corte A', N'Negro', N'Verano', CAST(10000.00 AS Decimal(10, 2)), 2, CAST(N'2025-07-11T18:30:00.000' AS DateTime), CAST(N'2025-07-11T18:30:00.000' AS DateTime), N'S', N'Piazza', N'Disponible', 3, 0, NULL, NULL, NULL)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [modelo], [color], [temporada], [precio], [stock], [fechaCreacion], [fechaUltimaModificacion], [talle], [disenador], [estado], [tiempoAjusteHoras], [es_unico], [numero], [categoria], [stockMinimo]) VALUES (2, N'Luna', N'Coctel', N'Sirena', N'Rojo', N'Verano', CAST(1000000.00 AS Decimal(10, 2)), 1, CAST(N'2025-07-11T18:30:00.000' AS DateTime), CAST(N'2025-07-11T18:30:00.000' AS DateTime), N'M', N'Victoria', N'Disponible', 2, 0, NULL, NULL, NULL)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [modelo], [color], [temporada], [precio], [stock], [fechaCreacion], [fechaUltimaModificacion], [talle], [disenador], [estado], [tiempoAjusteHoras], [es_unico], [numero], [categoria], [stockMinimo]) VALUES (3, N'Venus', N'Borcego caña alta', N'Bota media caña', N'Bordo', N'Invierno', CAST(30000.00 AS Decimal(10, 2)), 5, CAST(N'2025-07-11T18:30:00.000' AS DateTime), CAST(N'2025-07-11T18:30:00.000' AS DateTime), NULL, NULL, NULL, NULL, NULL, CAST(38.0 AS Decimal(4, 1)), N'Borcegos', 2)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [modelo], [color], [temporada], [precio], [stock], [fechaCreacion], [fechaUltimaModificacion], [talle], [disenador], [estado], [tiempoAjusteHoras], [es_unico], [numero], [categoria], [stockMinimo]) VALUES (7, N'Caña & Go', N'Botas de caña alta de gamuza', N'Bota media caña', N'Suela', N'Primavera', CAST(45000.00 AS Decimal(10, 2)), 5, CAST(N'2025-07-11T22:56:49.097' AS DateTime), CAST(N'2025-07-11T22:56:49.097' AS DateTime), NULL, NULL, NULL, NULL, NULL, CAST(37.0 AS Decimal(4, 1)), N'Bota', 2)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [modelo], [color], [temporada], [precio], [stock], [fechaCreacion], [fechaUltimaModificacion], [talle], [disenador], [estado], [tiempoAjusteHoras], [es_unico], [numero], [categoria], [stockMinimo]) VALUES (8, N'Caña & Go', N'Botas de caña alta de gamuza', N'Bota media caña', N'Suela', N'Primavera', CAST(45000.00 AS Decimal(10, 2)), 5, CAST(N'2025-07-11T22:56:56.177' AS DateTime), CAST(N'2025-07-11T22:56:56.177' AS DateTime), NULL, NULL, NULL, NULL, NULL, CAST(37.0 AS Decimal(4, 1)), N'Bota', 2)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [modelo], [color], [temporada], [precio], [stock], [fechaCreacion], [fechaUltimaModificacion], [talle], [disenador], [estado], [tiempoAjusteHoras], [es_unico], [numero], [categoria], [stockMinimo]) VALUES (1009, N'Sol', N'Vestido corto tipo coctel', N'Imperio', N'Celeste con azul profundo', N'Otoño', CAST(35000.00 AS Decimal(10, 2)), 4, CAST(N'2025-07-13T11:39:07.480' AS DateTime), CAST(N'2025-07-11T18:30:00.000' AS DateTime), N'L', N'Sofia ', N'Disponible', 2, 0, NULL, NULL, NULL)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [modelo], [color], [temporada], [precio], [stock], [fechaCreacion], [fechaUltimaModificacion], [talle], [disenador], [estado], [tiempoAjusteHoras], [es_unico], [numero], [categoria], [stockMinimo]) VALUES (1012, N'Medusa', N'Sandalias con tiras de encaje dorado', N'Sandalias fiesta', N'Dorado', N'Verano', CAST(100000.00 AS Decimal(10, 2)), 4, CAST(N'2025-07-13T11:44:27.567' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, CAST(35.0 AS Decimal(4, 1)), N'Sandalias', 2)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [modelo], [color], [temporada], [precio], [stock], [fechaCreacion], [fechaUltimaModificacion], [talle], [disenador], [estado], [tiempoAjusteHoras], [es_unico], [numero], [categoria], [stockMinimo]) VALUES (1013, N'Atenea', N'Zapatilla con detalle de cintas blancas y marca', N'Zapatilla urbana', N'Blanco con beige', N'Otoño', CAST(150000.00 AS Decimal(10, 2)), 4, CAST(N'2025-07-13T11:46:27.510' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, CAST(39.0 AS Decimal(4, 1)), N'Zapatilla', 2)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [modelo], [color], [temporada], [precio], [stock], [fechaCreacion], [fechaUltimaModificacion], [talle], [disenador], [estado], [tiempoAjusteHoras], [es_unico], [numero], [categoria], [stockMinimo]) VALUES (1014, N'Estrella', N'Vestido de fiesta armado', N'Princesa', N'Azul profundo con transparencia', N'Otoño', CAST(200000.00 AS Decimal(10, 2)), 1, CAST(N'2025-07-13T12:08:09.100' AS DateTime), CAST(N'2025-07-13T11:39:10.267' AS DateTime), N'XL', N'Ricky', N'Reservado', 5, 0, NULL, NULL, NULL)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [modelo], [color], [temporada], [precio], [stock], [fechaCreacion], [fechaUltimaModificacion], [talle], [disenador], [estado], [tiempoAjusteHoras], [es_unico], [numero], [categoria], [stockMinimo]) VALUES (1018, N'Yvaine', N'Vestido corte princesa', N'Princesa', N'Blanca y beige', N'Verano', CAST(300000.00 AS Decimal(10, 2)), 1, CAST(N'2025-07-13T23:02:56.893' AS DateTime), CAST(N'2025-07-13T11:39:10.267' AS DateTime), N'M', N'Horacio', N'Reservado', 3, 1, NULL, NULL, NULL)
INSERT [dbo].[Producto] ([id], [nombre], [descripcion], [modelo], [color], [temporada], [precio], [stock], [fechaCreacion], [fechaUltimaModificacion], [talle], [disenador], [estado], [tiempoAjusteHoras], [es_unico], [numero], [categoria], [stockMinimo]) VALUES (1019, N'Umma', N'Sandalias con taco aguja', N'Sandalias fiesta', N'Rosa', N'Verano', CAST(90000.00 AS Decimal(10, 2)), 4, CAST(N'2025-07-13T23:05:17.970' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, CAST(37.0 AS Decimal(4, 1)), N'Sandalias', 2)
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1, 1, CAST(N'2025-07-12T19:55:11.000' AS DateTime), CAST(25000.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (2, NULL, CAST(N'2025-07-12T19:55:11.000' AS DateTime), CAST(25000.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1002, 1, CAST(N'2025-07-13T13:48:51.023' AS DateTime), CAST(420000.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1003, 1, CAST(N'2025-07-13T14:03:40.263' AS DateTime), CAST(420000.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1004, 1, CAST(N'2025-07-13T14:04:12.153' AS DateTime), CAST(420000.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1005, 1, CAST(N'2025-07-13T14:04:22.787' AS DateTime), CAST(420000.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1006, 1, CAST(N'2025-07-13T14:05:16.883' AS DateTime), CAST(420000.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1007, NULL, CAST(N'2025-07-13T14:07:23.607' AS DateTime), CAST(420000.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1008, 2, CAST(N'2025-07-13T15:42:37.727' AS DateTime), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1009, 3, CAST(N'2025-07-13T15:48:28.607' AS DateTime), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1010, 2, CAST(N'2025-07-13T15:52:16.383' AS DateTime), CAST(400000.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1011, NULL, CAST(N'2025-07-13T16:01:11.423' AS DateTime), CAST(400000.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1012, 3, CAST(N'2025-07-13T16:34:27.777' AS DateTime), CAST(55000.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1013, 3, CAST(N'2025-07-13T16:50:24.257' AS DateTime), CAST(70000.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1015, 2, CAST(N'2025-07-13T16:59:48.163' AS DateTime), CAST(210000.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1018, 4, CAST(N'2025-07-13T17:56:30.503' AS DateTime), CAST(45000.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1019, 4, CAST(N'2025-07-13T20:46:17.180' AS DateTime), CAST(1000000.00 AS Decimal(10, 2)))
INSERT [dbo].[Venta] ([id], [clienteId], [fecha], [total]) VALUES (1021, 3, CAST(N'2025-07-13T22:18:49.963' AS DateTime), CAST(210000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Cliente] FOREIGN KEY([clienteId])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Cliente]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_DetalleVenta] FOREIGN KEY([ventaId])
REFERENCES [dbo].[Venta] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_Venta_DetalleVenta]
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD FOREIGN KEY([ventaId])
REFERENCES [dbo].[Venta] ([id])
ON DELETE CASCADE
GO
