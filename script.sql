USE [db_ab8d90_zombiehorde]
GO
/****** Object:  Table [dbo].[Profile]    Script Date: 11/05/2025 8:59:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profile](
	[Id] [uniqueidentifier] NOT NULL,
	[Description] [varchar](100) NOT NULL,
	[RegisterBy] [varchar](100) NOT NULL,
	[RegisterDate] [datetime] NOT NULL,
	[EditionBy] [varchar](100) NULL,
	[EditionDate] [datetime] NULL,
 CONSTRAINT [PK_Profile] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Simulation]    Script Date: 11/05/2025 8:59:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Simulation](
	[Id] [uniqueidentifier] NOT NULL,
	[AvalibleTime] [smallint] NOT NULL,
	[AvalibleBullets] [smallint] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[TotalScore] [smallint] NOT NULL,
	[RegisterDate] [datetime] NOT NULL,
	[RegisterBy] [varchar](100) NOT NULL,
	[EditionBy] [varchar](100) NULL,
	[EditionDate] [datetime] NULL,
 CONSTRAINT [PK_Simulation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SimulationDetail]    Script Date: 11/05/2025 8:59:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SimulationDetail](
	[Id] [uniqueidentifier] NOT NULL,
	[SimulationId] [uniqueidentifier] NOT NULL,
	[ZombieId] [uniqueidentifier] NOT NULL,
	[ZombiesDefeated] [smallint] NOT NULL,
	[RegisterBy] [varchar](100) NOT NULL,
	[RegisterDate] [datetime] NOT NULL,
	[EditionBy] [varchar](100) NULL,
	[EditionDate] [datetime] NULL,
 CONSTRAINT [PK_SimulationDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/05/2025 8:59:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Password] [varchar](256) NOT NULL,
	[ProfileId] [uniqueidentifier] NOT NULL,
	[RegisterDate] [datetime] NOT NULL,
	[RegisterBy] [varchar](100) NOT NULL,
	[EditionBy] [varchar](100) NULL,
	[EditionDate] [datetime] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zombie]    Script Date: 11/05/2025 8:59:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zombie](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[ThreatLevelId] [uniqueidentifier] NOT NULL,
	[NeccesaryBullets] [smallint] NOT NULL,
	[TimeNeeded] [smallint] NOT NULL,
	[Score] [smallint] NOT NULL,
	[RegisterDate] [datetime] NOT NULL,
	[RegisterBy] [varchar](100) NOT NULL,
	[EditionDate] [datetime] NULL,
	[EditionBy] [varchar](100) NULL,
 CONSTRAINT [PK_Zombie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZombieLevel]    Script Date: 11/05/2025 8:59:56 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZombieLevel](
	[Id] [uniqueidentifier] NOT NULL,
	[Description] [varchar](100) NOT NULL,
	[Level] [tinyint] NOT NULL,
	[RegisterDate] [datetime] NOT NULL,
	[RegisterBy] [varchar](100) NOT NULL,
	[EditionBy] [varchar](100) NULL,
	[EditionDate] [datetime] NULL,
 CONSTRAINT [PK_ZombieLevel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Profile] ([Id], [Description], [RegisterBy], [RegisterDate], [EditionBy], [EditionDate]) VALUES (N'af6af78e-1eee-49c4-bf6a-c16b60734ce3', N'Defensor', N'admin', CAST(N'2025-05-11T13:05:01.213' AS DateTime), NULL, NULL)
INSERT [dbo].[Profile] ([Id], [Description], [RegisterBy], [RegisterDate], [EditionBy], [EditionDate]) VALUES (N'8fbee43f-934f-4b36-9974-fd7da58fed3e', N'Administrador', N'admin', CAST(N'2025-05-11T13:04:53.443' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Simulation] ([Id], [AvalibleTime], [AvalibleBullets], [UserId], [TotalScore], [RegisterDate], [RegisterBy], [EditionBy], [EditionDate]) VALUES (N'4bc26721-d2d0-4259-8b98-06eafed2f05a', 951, 763, N'16e6e159-054e-463b-ab2e-734d77e42d9e', 1666, CAST(N'2025-05-12T00:47:47.613' AS DateTime), N'POR HACER', NULL, NULL)
INSERT [dbo].[Simulation] ([Id], [AvalibleTime], [AvalibleBullets], [UserId], [TotalScore], [RegisterDate], [RegisterBy], [EditionBy], [EditionDate]) VALUES (N'f2d1c0c9-a61c-4899-88a8-32cf7c9bb6e5', 15, 63, N'16e6e159-054e-463b-ab2e-734d77e42d9e', 32, CAST(N'2025-05-12T01:15:18.173' AS DateTime), N'jorgecortes815@gmail.com', NULL, NULL)
INSERT [dbo].[Simulation] ([Id], [AvalibleTime], [AvalibleBullets], [UserId], [TotalScore], [RegisterDate], [RegisterBy], [EditionBy], [EditionDate]) VALUES (N'4093e70d-7b5f-421f-b995-33360f3f6d14', 777, 555, N'16e6e159-054e-463b-ab2e-734d77e42d9e', 1184, CAST(N'2025-05-12T01:03:30.007' AS DateTime), N'jorgecortes815@gmail.com', NULL, NULL)
INSERT [dbo].[Simulation] ([Id], [AvalibleTime], [AvalibleBullets], [UserId], [TotalScore], [RegisterDate], [RegisterBy], [EditionBy], [EditionDate]) VALUES (N'3693b0d1-1c97-4b25-b9f6-4e094b9f3f79', 489, 751, N'16e6e159-054e-463b-ab2e-734d77e42d9e', 1025, CAST(N'2025-05-12T00:49:34.097' AS DateTime), N'POR HACER', N'Jorge-PC\jorge', CAST(N'2025-05-11T20:08:53.907' AS DateTime))
INSERT [dbo].[Simulation] ([Id], [AvalibleTime], [AvalibleBullets], [UserId], [TotalScore], [RegisterDate], [RegisterBy], [EditionBy], [EditionDate]) VALUES (N'515e0b7a-7eb8-4c42-8d45-83919e17bc51', 6000, 10000, N'16e6e159-054e-463b-ab2e-734d77e42d9e', 12800, CAST(N'2025-05-12T01:15:40.123' AS DateTime), N'jorgecortes815@gmail.com', NULL, NULL)
INSERT [dbo].[Simulation] ([Id], [AvalibleTime], [AvalibleBullets], [UserId], [TotalScore], [RegisterDate], [RegisterBy], [EditionBy], [EditionDate]) VALUES (N'c8e04d2a-06b7-4dad-9b54-96d440b57b59', 169, 741, N'16e6e159-054e-463b-ab2e-734d77e42d9e', 352, CAST(N'2025-05-12T00:50:07.700' AS DateTime), N'POR HACER', NULL, NULL)
INSERT [dbo].[Simulation] ([Id], [AvalibleTime], [AvalibleBullets], [UserId], [TotalScore], [RegisterDate], [RegisterBy], [EditionBy], [EditionDate]) VALUES (N'ff3e8e7b-8b68-472b-a122-986225a78819', 396, 254, N'16e6e159-054e-463b-ab2e-734d77e42d9e', 580, CAST(N'2025-05-11T20:06:21.973' AS DateTime), N'POR HACER', NULL, NULL)
GO
INSERT [dbo].[SimulationDetail] ([Id], [SimulationId], [ZombieId], [ZombiesDefeated], [RegisterBy], [RegisterDate], [EditionBy], [EditionDate]) VALUES (N'25a809b7-2b2c-497d-8057-092df6b278c6', N'4bc26721-d2d0-4259-8b98-06eafed2f05a', N'4472a59c-2bdb-4a72-8ca2-c72c0eccb56c', 1, N'POR HACER', CAST(N'2025-05-12T00:47:47.700' AS DateTime), NULL, NULL)
INSERT [dbo].[SimulationDetail] ([Id], [SimulationId], [ZombieId], [ZombiesDefeated], [RegisterBy], [RegisterDate], [EditionBy], [EditionDate]) VALUES (N'1dcd4093-5654-4902-8242-0d22a594567c', N'515e0b7a-7eb8-4c42-8d45-83919e17bc51', N'8841871f-1185-417b-a40d-0b91ffa4baa9', 400, N'jorgecortes815@gmail.com', CAST(N'2025-05-12T01:15:40.130' AS DateTime), NULL, NULL)
INSERT [dbo].[SimulationDetail] ([Id], [SimulationId], [ZombieId], [ZombiesDefeated], [RegisterBy], [RegisterDate], [EditionBy], [EditionDate]) VALUES (N'd06ef58c-2ba3-4904-8803-14e2f32d1709', N'4bc26721-d2d0-4259-8b98-06eafed2f05a', N'd35d4921-4295-4600-9c70-dcf1ebf6f149', 2, N'POR HACER', CAST(N'2025-05-12T00:47:47.703' AS DateTime), NULL, NULL)
INSERT [dbo].[SimulationDetail] ([Id], [SimulationId], [ZombieId], [ZombiesDefeated], [RegisterBy], [RegisterDate], [EditionBy], [EditionDate]) VALUES (N'10224a67-f5a1-44e2-ba56-39c7eaea549c', N'ff3e8e7b-8b68-472b-a122-986225a78819', N'4472a59c-2bdb-4a72-8ca2-c72c0eccb56c', 2, N'POR HACER', CAST(N'2025-05-11T20:06:22.733' AS DateTime), NULL, NULL)
INSERT [dbo].[SimulationDetail] ([Id], [SimulationId], [ZombieId], [ZombiesDefeated], [RegisterBy], [RegisterDate], [EditionBy], [EditionDate]) VALUES (N'10e72cde-c461-4cc4-8ab7-7e9e5ea33c10', N'3693b0d1-1c97-4b25-b9f6-4e094b9f3f79', N'8841871f-1185-417b-a40d-0b91ffa4baa9', 32, N'POR HACER', CAST(N'2025-05-12T00:49:34.103' AS DateTime), NULL, NULL)
INSERT [dbo].[SimulationDetail] ([Id], [SimulationId], [ZombieId], [ZombiesDefeated], [RegisterBy], [RegisterDate], [EditionBy], [EditionDate]) VALUES (N'77632b05-e6c6-4566-8949-8033823b9dd3', N'c8e04d2a-06b7-4dad-9b54-96d440b57b59', N'8841871f-1185-417b-a40d-0b91ffa4baa9', 11, N'POR HACER', CAST(N'2025-05-12T00:50:07.710' AS DateTime), NULL, NULL)
INSERT [dbo].[SimulationDetail] ([Id], [SimulationId], [ZombieId], [ZombiesDefeated], [RegisterBy], [RegisterDate], [EditionBy], [EditionDate]) VALUES (N'ecf40b12-e265-480d-bfc4-8642dbf1783d', N'f2d1c0c9-a61c-4899-88a8-32cf7c9bb6e5', N'8841871f-1185-417b-a40d-0b91ffa4baa9', 1, N'jorgecortes815@gmail.com', CAST(N'2025-05-12T01:15:18.180' AS DateTime), NULL, NULL)
INSERT [dbo].[SimulationDetail] ([Id], [SimulationId], [ZombieId], [ZombiesDefeated], [RegisterBy], [RegisterDate], [EditionBy], [EditionDate]) VALUES (N'74ff5d14-3e25-4f78-adc4-9cb44d938c4f', N'ff3e8e7b-8b68-472b-a122-986225a78819', N'8841871f-1185-417b-a40d-0b91ffa4baa9', 16, N'POR HACER', CAST(N'2025-05-11T20:06:22.703' AS DateTime), NULL, NULL)
INSERT [dbo].[SimulationDetail] ([Id], [SimulationId], [ZombieId], [ZombiesDefeated], [RegisterBy], [RegisterDate], [EditionBy], [EditionDate]) VALUES (N'4b7b0c23-5285-4bdb-a5d6-d5ea941a0fa3', N'4bc26721-d2d0-4259-8b98-06eafed2f05a', N'8841871f-1185-417b-a40d-0b91ffa4baa9', 50, N'POR HACER', CAST(N'2025-05-12T00:47:47.690' AS DateTime), NULL, NULL)
INSERT [dbo].[SimulationDetail] ([Id], [SimulationId], [ZombieId], [ZombiesDefeated], [RegisterBy], [RegisterDate], [EditionBy], [EditionDate]) VALUES (N'dfe91097-8d11-4d21-ac90-f6b480d26420', N'4093e70d-7b5f-421f-b995-33360f3f6d14', N'8841871f-1185-417b-a40d-0b91ffa4baa9', 37, N'jorgecortes815@gmail.com', CAST(N'2025-05-12T01:03:30.083' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[User] ([Id], [Name], [Email], [Password], [ProfileId], [RegisterDate], [RegisterBy], [EditionBy], [EditionDate]) VALUES (N'16e6e159-054e-463b-ab2e-734d77e42d9e', N'Jorge Armando Cortés Martínez', N'jorgecortes815@gmail.com', N'AQAAAAIAAYagAAAAECG4Jk4cOIBn+pATA0z/5ef3v7r6q34WYN0N+2SbzogBRUi+9IM8726NkxYqsrN9QQ==', N'af6af78e-1eee-49c4-bf6a-c16b60734ce3', CAST(N'2025-05-11T13:06:49.170' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[Zombie] ([Id], [Name], [ThreatLevelId], [NeccesaryBullets], [TimeNeeded], [Score], [RegisterDate], [RegisterBy], [EditionDate], [EditionBy]) VALUES (N'8841871f-1185-417b-a40d-0b91ffa4baa9', N'Splitter', N'44cf38e6-b4a9-4bbe-8249-52fb0f147970', 15, 15, 32, CAST(N'2025-05-11T14:36:28.283' AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[Zombie] ([Id], [Name], [ThreatLevelId], [NeccesaryBullets], [TimeNeeded], [Score], [RegisterDate], [RegisterBy], [EditionDate], [EditionBy]) VALUES (N'b56973e8-1588-4bf3-8468-805f99fd014f', N'Tank', N'0f392118-4989-4425-ae96-819557ae09b5', 31, 27, 75, CAST(N'2025-05-11T14:36:56.453' AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[Zombie] ([Id], [Name], [ThreatLevelId], [NeccesaryBullets], [TimeNeeded], [Score], [RegisterDate], [RegisterBy], [EditionDate], [EditionBy]) VALUES (N'8e8932c0-76bf-4015-96cf-8a0bf78ac58c', N'Witch', N'0f392118-4989-4425-ae96-819557ae09b5', 23, 47, 80, CAST(N'2025-05-11T14:37:15.260' AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[Zombie] ([Id], [Name], [ThreatLevelId], [NeccesaryBullets], [TimeNeeded], [Score], [RegisterDate], [RegisterBy], [EditionDate], [EditionBy]) VALUES (N'4472a59c-2bdb-4a72-8ca2-c72c0eccb56c', N'Boomer', N'44cf38e6-b4a9-4bbe-8249-52fb0f147970', 7, 25, 34, CAST(N'2025-05-11T14:36:42.200' AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[Zombie] ([Id], [Name], [ThreatLevelId], [NeccesaryBullets], [TimeNeeded], [Score], [RegisterDate], [RegisterBy], [EditionDate], [EditionBy]) VALUES (N'd35d4921-4295-4600-9c70-dcf1ebf6f149', N'Zombie', N'10f647a1-bb5b-42ff-b93f-0e9d0561d5b6', 3, 14, 16, CAST(N'2025-05-11T14:36:12.743' AS DateTime), N'admin', NULL, NULL)
GO
INSERT [dbo].[ZombieLevel] ([Id], [Description], [Level], [RegisterDate], [RegisterBy], [EditionBy], [EditionDate]) VALUES (N'10f647a1-bb5b-42ff-b93f-0e9d0561d5b6', N'Regular', 1, CAST(N'2025-05-11T14:34:28.670' AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[ZombieLevel] ([Id], [Description], [Level], [RegisterDate], [RegisterBy], [EditionBy], [EditionDate]) VALUES (N'44cf38e6-b4a9-4bbe-8249-52fb0f147970', N'Raro', 2, CAST(N'2025-05-11T14:34:18.887' AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[ZombieLevel] ([Id], [Description], [Level], [RegisterDate], [RegisterBy], [EditionBy], [EditionDate]) VALUES (N'0f392118-4989-4425-ae96-819557ae09b5', N'Especial', 3, CAST(N'2025-05-11T14:34:09.757' AS DateTime), N'admin', NULL, NULL)
GO
ALTER TABLE [dbo].[Simulation]  WITH CHECK ADD  CONSTRAINT [FK_Simulation_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Simulation] CHECK CONSTRAINT [FK_Simulation_User]
GO
ALTER TABLE [dbo].[SimulationDetail]  WITH CHECK ADD  CONSTRAINT [FK_SimulationDetail_Simulation] FOREIGN KEY([SimulationId])
REFERENCES [dbo].[Simulation] ([Id])
GO
ALTER TABLE [dbo].[SimulationDetail] CHECK CONSTRAINT [FK_SimulationDetail_Simulation]
GO
ALTER TABLE [dbo].[SimulationDetail]  WITH CHECK ADD  CONSTRAINT [FK_SimulationDetail_Zombie] FOREIGN KEY([ZombieId])
REFERENCES [dbo].[Zombie] ([Id])
GO
ALTER TABLE [dbo].[SimulationDetail] CHECK CONSTRAINT [FK_SimulationDetail_Zombie]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Profile] FOREIGN KEY([ProfileId])
REFERENCES [dbo].[Profile] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Profile]
GO
ALTER TABLE [dbo].[Zombie]  WITH CHECK ADD  CONSTRAINT [FK_Zombie_ZombieLevel] FOREIGN KEY([ThreatLevelId])
REFERENCES [dbo].[ZombieLevel] ([Id])
GO
ALTER TABLE [dbo].[Zombie] CHECK CONSTRAINT [FK_Zombie_ZombieLevel]
GO
