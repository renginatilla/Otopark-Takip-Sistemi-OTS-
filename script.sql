USE [Otopark]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 12.09.2019 10:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[LoginID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nchar](50) NULL,
	[KullaniciSifre] [nchar](50) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[LoginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Arac]    Script Date: 12.09.2019 10:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Arac](
	[AracID] [int] IDENTITY(1,1) NOT NULL,
	[AracPlaka] [nvarchar](50) NULL,
	[AracMarka] [nvarchar](50) NULL,
	[AracModel] [nvarchar](50) NULL,
	[AracRenk] [nchar](10) NULL,
	[MusteriID] [int] NOT NULL,
	[AracTipi] [int] NOT NULL,
 CONSTRAINT [PK_Arac] PRIMARY KEY CLUSTERED 
(
	[AracID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AracOtopark]    Script Date: 12.09.2019 10:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AracOtopark](
	[AracOtoparkID] [int] IDENTITY(1,1) NOT NULL,
	[AracID] [int] NOT NULL,
	[OtoparkID] [int] NOT NULL,
	[GirisSaati] [datetime] NULL,
	[CikisSaati] [datetime] NULL,
 CONSTRAINT [PK_AracOtopark] PRIMARY KEY CLUSTERED 
(
	[AracOtoparkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 12.09.2019 10:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[MusteriID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAd] [nvarchar](50) NULL,
	[MusteriSoyad] [nvarchar](50) NULL,
	[MusteriTel] [nchar](50) NULL,
	[MusteriKayitTarihi] [datetime] NULL,
	[MusteriMail] [nvarchar](50) NULL,
 CONSTRAINT [PK_Musteri] PRIMARY KEY CLUSTERED 
(
	[MusteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odeme]    Script Date: 12.09.2019 10:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odeme](
	[OdemeID] [int] IDENTITY(1,1) NOT NULL,
	[OtoparkID] [int] NULL,
	[Odeme] [int] NULL,
	[Tarih] [datetime] NULL,
 CONSTRAINT [PK_Odeme] PRIMARY KEY CLUSTERED 
(
	[OdemeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Otopark]    Script Date: 12.09.2019 10:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Otopark](
	[OtoparkID] [int] IDENTITY(1,1) NOT NULL,
	[Kat] [int] NULL,
	[Kapasite] [int] NULL,
 CONSTRAINT [PK_Otopark] PRIMARY KEY CLUSTERED 
(
	[OtoparkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarife]    Script Date: 12.09.2019 10:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarife](
	[AracTipi] [int] IDENTITY(1,1) NOT NULL,
	[Tip] [nvarchar](50) NULL,
	[Fiyat] [int] NULL,
	[TarifeTipi] [int] NULL,
 CONSTRAINT [PK_Tarife] PRIMARY KEY CLUSTERED 
(
	[AracTipi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([LoginID], [KullaniciAdi], [KullaniciSifre]) VALUES (1, N'rengin                                            ', N'123                                               ')
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[Arac] ON 

INSERT [dbo].[Arac] ([AracID], [AracPlaka], [AracMarka], [AracModel], [AracRenk], [MusteriID], [AracTipi]) VALUES (1, N'26 ES 1223', N'suzuki', N'201fd', N'gri       ', 1, 1)
INSERT [dbo].[Arac] ([AracID], [AracPlaka], [AracMarka], [AracModel], [AracRenk], [MusteriID], [AracTipi]) VALUES (2, N'34 DD 1230', N'Audi', N'A6', N'beyaz     ', 10, 2)
INSERT [dbo].[Arac] ([AracID], [AracPlaka], [AracMarka], [AracModel], [AracRenk], [MusteriID], [AracTipi]) VALUES (7, N'34 KH 1232', N'honda', N'201fda', N'mavi      ', 4, 3)
INSERT [dbo].[Arac] ([AracID], [AracPlaka], [AracMarka], [AracModel], [AracRenk], [MusteriID], [AracTipi]) VALUES (8, N'72 HS 8565', N'opel', N'corsa', N'sarı      ', 4, 2)
INSERT [dbo].[Arac] ([AracID], [AracPlaka], [AracMarka], [AracModel], [AracRenk], [MusteriID], [AracTipi]) VALUES (9, N'45 FDS 9547', N'mercedes', N'a180', N'beyaz     ', 1, 4)
INSERT [dbo].[Arac] ([AracID], [AracPlaka], [AracMarka], [AracModel], [AracRenk], [MusteriID], [AracTipi]) VALUES (10, N'52 DFD 2501', N'honda', N'crv', N'kırmızı   ', 4, 2)
INSERT [dbo].[Arac] ([AracID], [AracPlaka], [AracMarka], [AracModel], [AracRenk], [MusteriID], [AracTipi]) VALUES (11, N'26 ES 4566', N'ford', N'focus', N'beyaz     ', 6, 2)
INSERT [dbo].[Arac] ([AracID], [AracPlaka], [AracMarka], [AracModel], [AracRenk], [MusteriID], [AracTipi]) VALUES (12, N'34 GH 123', N'Yamaha', N'scooter', N'kırmızı   ', 9, 1)
INSERT [dbo].[Arac] ([AracID], [AracPlaka], [AracMarka], [AracModel], [AracRenk], [MusteriID], [AracTipi]) VALUES (13, N'34 GG 1474', N'TEMSA', N'safir', N'beyaz     ', 8, 4)
SET IDENTITY_INSERT [dbo].[Arac] OFF
SET IDENTITY_INSERT [dbo].[AracOtopark] ON 

INSERT [dbo].[AracOtopark] ([AracOtoparkID], [AracID], [OtoparkID], [GirisSaati], [CikisSaati]) VALUES (1, 1, 1, NULL, CAST(N'2019-09-08T22:54:12.703' AS DateTime))
INSERT [dbo].[AracOtopark] ([AracOtoparkID], [AracID], [OtoparkID], [GirisSaati], [CikisSaati]) VALUES (2, 2, 1, NULL, CAST(N'2019-09-08T22:55:16.230' AS DateTime))
INSERT [dbo].[AracOtopark] ([AracOtoparkID], [AracID], [OtoparkID], [GirisSaati], [CikisSaati]) VALUES (3, 7, 2, NULL, CAST(N'2019-09-08T22:54:56.860' AS DateTime))
INSERT [dbo].[AracOtopark] ([AracOtoparkID], [AracID], [OtoparkID], [GirisSaati], [CikisSaati]) VALUES (4, 7, 1, CAST(N'2019-09-08T20:27:33.523' AS DateTime), CAST(N'2019-09-09T14:17:25.290' AS DateTime))
INSERT [dbo].[AracOtopark] ([AracOtoparkID], [AracID], [OtoparkID], [GirisSaati], [CikisSaati]) VALUES (5, 2, 1, CAST(N'2019-09-09T09:11:12.723' AS DateTime), CAST(N'2019-09-09T14:14:07.697' AS DateTime))
INSERT [dbo].[AracOtopark] ([AracOtoparkID], [AracID], [OtoparkID], [GirisSaati], [CikisSaati]) VALUES (6, 8, 1, CAST(N'2019-09-09T11:47:24.493' AS DateTime), CAST(N'2019-09-09T13:39:55.347' AS DateTime))
INSERT [dbo].[AracOtopark] ([AracOtoparkID], [AracID], [OtoparkID], [GirisSaati], [CikisSaati]) VALUES (7, 8, 1, CAST(N'2019-09-09T12:38:37.173' AS DateTime), CAST(N'2019-09-12T10:23:09.570' AS DateTime))
INSERT [dbo].[AracOtopark] ([AracOtoparkID], [AracID], [OtoparkID], [GirisSaati], [CikisSaati]) VALUES (8, 8, 1, CAST(N'2019-09-09T12:38:40.483' AS DateTime), CAST(N'2019-09-12T10:23:16.710' AS DateTime))
INSERT [dbo].[AracOtopark] ([AracOtoparkID], [AracID], [OtoparkID], [GirisSaati], [CikisSaati]) VALUES (10, 9, 1, CAST(N'2019-09-09T13:41:15.247' AS DateTime), NULL)
INSERT [dbo].[AracOtopark] ([AracOtoparkID], [AracID], [OtoparkID], [GirisSaati], [CikisSaati]) VALUES (11, 9, 1, CAST(N'2019-09-09T13:41:24.663' AS DateTime), CAST(N'2019-09-09T14:14:04.783' AS DateTime))
INSERT [dbo].[AracOtopark] ([AracOtoparkID], [AracID], [OtoparkID], [GirisSaati], [CikisSaati]) VALUES (12, 9, 1, CAST(N'2019-09-09T13:44:07.937' AS DateTime), CAST(N'2019-09-09T13:47:09.627' AS DateTime))
INSERT [dbo].[AracOtopark] ([AracOtoparkID], [AracID], [OtoparkID], [GirisSaati], [CikisSaati]) VALUES (13, 10, 3, CAST(N'2019-09-09T14:07:59.360' AS DateTime), CAST(N'2019-09-10T09:53:15.703' AS DateTime))
INSERT [dbo].[AracOtopark] ([AracOtoparkID], [AracID], [OtoparkID], [GirisSaati], [CikisSaati]) VALUES (14, 2, 2, CAST(N'2019-09-10T11:44:03.133' AS DateTime), CAST(N'2019-09-12T10:29:23.247' AS DateTime))
INSERT [dbo].[AracOtopark] ([AracOtoparkID], [AracID], [OtoparkID], [GirisSaati], [CikisSaati]) VALUES (16, 7, 3, CAST(N'2019-09-10T11:52:04.823' AS DateTime), CAST(N'2019-09-12T10:25:50.697' AS DateTime))
INSERT [dbo].[AracOtopark] ([AracOtoparkID], [AracID], [OtoparkID], [GirisSaati], [CikisSaati]) VALUES (17, 13, 3, CAST(N'2019-09-10T20:58:59.783' AS DateTime), CAST(N'2019-09-12T10:26:14.693' AS DateTime))
SET IDENTITY_INSERT [dbo].[AracOtopark] OFF
SET IDENTITY_INSERT [dbo].[Musteri] ON 

INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriTel], [MusteriKayitTarihi], [MusteriMail]) VALUES (1, N'rengin', N'Atilla', N'(539) 947-0000                                    ', CAST(N'2019-09-05T00:00:00.000' AS DateTime), N'rengin@gmail.com')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriTel], [MusteriKayitTarihi], [MusteriMail]) VALUES (4, N'fadime', N'açıkgöz', N'(555) 555-0000                                    ', CAST(N'2019-09-07T00:00:00.000' AS DateTime), N'fadime@gmail.com')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriTel], [MusteriKayitTarihi], [MusteriMail]) VALUES (6, N'gökçe', N'tenekeci', N'(535) 456-6541                                    ', CAST(N'2019-09-10T00:00:00.000' AS DateTime), N'gokce@gmail.com')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriTel], [MusteriKayitTarihi], [MusteriMail]) VALUES (7, N'zeynep', N'pektaş', N'(535) 858-5855                                    ', CAST(N'2019-09-10T00:00:00.000' AS DateTime), N'zeynep@gmail.com')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriTel], [MusteriKayitTarihi], [MusteriMail]) VALUES (8, N'hakan', N'yıldırım', N'(535) 987-8987                                    ', CAST(N'2019-09-10T00:00:00.000' AS DateTime), N'hakan@gmail.com')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriTel], [MusteriKayitTarihi], [MusteriMail]) VALUES (9, N'songul', N'gamsız', N'(534) 545-4555                                    ', CAST(N'2019-09-10T00:00:00.000' AS DateTime), N'songul@gmail.com')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [MusteriTel], [MusteriKayitTarihi], [MusteriMail]) VALUES (10, N'murat can', N'doğan', N'(533) 232-3232                                    ', CAST(N'2019-09-10T00:00:00.000' AS DateTime), N'muratcan@gmail.com')
SET IDENTITY_INSERT [dbo].[Musteri] OFF
SET IDENTITY_INSERT [dbo].[Odeme] ON 

INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (1, 13, 190, CAST(N'2019-09-10T09:53:15.743' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (2, 16, 0, CAST(N'2019-09-10T11:52:36.417' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (3, 16, 220, CAST(N'2019-09-10T23:09:15.193' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (4, 17, 390, CAST(N'2019-09-12T10:19:38.073' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (5, 16, 440, CAST(N'2019-09-12T10:19:44.317' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (6, 16, 400, CAST(N'2019-09-12T10:19:52.007' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (7, 16, 440, CAST(N'2019-09-12T10:21:15.730' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (8, 17, 390, CAST(N'2019-09-12T10:21:18.860' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (9, 17, 500, CAST(N'2019-09-12T10:21:23.510' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (10, 7, 315, CAST(N'2019-09-12T10:23:09.610' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (11, 8, 315, CAST(N'2019-09-12T10:23:14.990' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (12, 8, 300, CAST(N'2019-09-12T10:23:16.730' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (13, 16, 440, CAST(N'2019-09-12T10:25:50.737' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (14, 17, 390, CAST(N'2019-09-12T10:25:54.777' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (15, 17, 500, CAST(N'2019-09-12T10:26:14.710' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (16, 14, 330, CAST(N'2019-09-12T10:27:50.623' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (17, 14, 330, CAST(N'2019-09-12T10:27:52.180' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (18, 14, 300, CAST(N'2019-09-12T10:27:56.497' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (19, 14, 330, CAST(N'2019-09-12T10:29:20.543' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (20, 14, 330, CAST(N'2019-09-12T10:29:21.730' AS DateTime))
INSERT [dbo].[Odeme] ([OdemeID], [OtoparkID], [Odeme], [Tarih]) VALUES (21, 14, 300, CAST(N'2019-09-12T10:29:23.257' AS DateTime))
SET IDENTITY_INSERT [dbo].[Odeme] OFF
SET IDENTITY_INSERT [dbo].[Otopark] ON 

INSERT [dbo].[Otopark] ([OtoparkID], [Kat], [Kapasite]) VALUES (1, 1, 20)
INSERT [dbo].[Otopark] ([OtoparkID], [Kat], [Kapasite]) VALUES (2, 2, 15)
INSERT [dbo].[Otopark] ([OtoparkID], [Kat], [Kapasite]) VALUES (3, 3, 15)
SET IDENTITY_INSERT [dbo].[Otopark] OFF
SET IDENTITY_INSERT [dbo].[Tarife] ON 

INSERT [dbo].[Tarife] ([AracTipi], [Tip], [Fiyat], [TarifeTipi]) VALUES (1, N'motor', 10, NULL)
INSERT [dbo].[Tarife] ([AracTipi], [Tip], [Fiyat], [TarifeTipi]) VALUES (2, N'otomobil', 15, NULL)
INSERT [dbo].[Tarife] ([AracTipi], [Tip], [Fiyat], [TarifeTipi]) VALUES (3, N'minibüs', 20, NULL)
INSERT [dbo].[Tarife] ([AracTipi], [Tip], [Fiyat], [TarifeTipi]) VALUES (4, N'otobüs', 30, NULL)
SET IDENTITY_INSERT [dbo].[Tarife] OFF
ALTER TABLE [dbo].[Arac]  WITH CHECK ADD  CONSTRAINT [FK_Arac_Musteri] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[Musteri] ([MusteriID])
GO
ALTER TABLE [dbo].[Arac] CHECK CONSTRAINT [FK_Arac_Musteri]
GO
ALTER TABLE [dbo].[Arac]  WITH CHECK ADD  CONSTRAINT [FK_Arac_Tarife] FOREIGN KEY([AracTipi])
REFERENCES [dbo].[Tarife] ([AracTipi])
GO
ALTER TABLE [dbo].[Arac] CHECK CONSTRAINT [FK_Arac_Tarife]
GO
ALTER TABLE [dbo].[AracOtopark]  WITH CHECK ADD  CONSTRAINT [FK_AracOtopark_Arac] FOREIGN KEY([AracID])
REFERENCES [dbo].[Arac] ([AracID])
GO
ALTER TABLE [dbo].[AracOtopark] CHECK CONSTRAINT [FK_AracOtopark_Arac]
GO
ALTER TABLE [dbo].[AracOtopark]  WITH CHECK ADD  CONSTRAINT [FK_AracOtopark_Otopark] FOREIGN KEY([OtoparkID])
REFERENCES [dbo].[Otopark] ([OtoparkID])
GO
ALTER TABLE [dbo].[AracOtopark] CHECK CONSTRAINT [FK_AracOtopark_Otopark]
GO
ALTER TABLE [dbo].[Odeme]  WITH CHECK ADD  CONSTRAINT [FK_Odeme_AracOtopark] FOREIGN KEY([OtoparkID])
REFERENCES [dbo].[AracOtopark] ([AracOtoparkID])
GO
ALTER TABLE [dbo].[Odeme] CHECK CONSTRAINT [FK_Odeme_AracOtopark]
GO
