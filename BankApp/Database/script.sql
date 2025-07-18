USE [BankaUygulamasi]
GO
/****** Object:  Table [dbo].[Havale]    Script Date: 15.07.2025 09:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Havale](
	[havaleID] [int] IDENTITY(1,1) NOT NULL,
	[gonderen_hesapID] [int] NOT NULL,
	[alici_hesapID] [int] NOT NULL,
	[tutar] [decimal](18, 2) NOT NULL,
	[tarih] [datetime] NOT NULL,
	[aciklama] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[havaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hesaplar]    Script Date: 15.07.2025 09:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hesaplar](
	[hesapID] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciID] [int] NOT NULL,
	[hesap_no] [varchar](20) NOT NULL,
	[bakiye] [decimal](18, 2) NOT NULL,
	[acilis_tarihi] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[hesapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[hesap_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Islemler]    Script Date: 15.07.2025 09:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Islemler](
	[islemID] [int] IDENTITY(1,1) NOT NULL,
	[hesapID] [int] NOT NULL,
	[islem_turu] [varchar](20) NOT NULL,
	[tutar] [decimal](18, 2) NOT NULL,
	[tarih] [datetime] NOT NULL,
	[aciklama] [nvarchar](255) NULL,
	[hedef_hesapID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[islemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 15.07.2025 09:59:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[kullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[ad_soyad] [nvarchar](50) NOT NULL,
	[tcno] [char](11) NOT NULL,
	[sifre] [nvarchar](128) NOT NULL,
	[rol] [nvarchar](20) NOT NULL,
	[telefon] [varchar](11) NULL,
	[email] [varchar](100) NULL,
	[adres] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[kullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[tcno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Havale] ADD  DEFAULT (getdate()) FOR [tarih]
GO
ALTER TABLE [dbo].[Hesaplar] ADD  DEFAULT ((0)) FOR [bakiye]
GO
ALTER TABLE [dbo].[Hesaplar] ADD  DEFAULT (getdate()) FOR [acilis_tarihi]
GO
ALTER TABLE [dbo].[Islemler] ADD  DEFAULT (getdate()) FOR [tarih]
GO
ALTER TABLE [dbo].[Havale]  WITH CHECK ADD FOREIGN KEY([alici_hesapID])
REFERENCES [dbo].[Hesaplar] ([hesapID])
GO
ALTER TABLE [dbo].[Havale]  WITH CHECK ADD FOREIGN KEY([gonderen_hesapID])
REFERENCES [dbo].[Hesaplar] ([hesapID])
GO
ALTER TABLE [dbo].[Hesaplar]  WITH CHECK ADD FOREIGN KEY([kullaniciID])
REFERENCES [dbo].[Kullanicilar] ([kullaniciID])
GO
ALTER TABLE [dbo].[Islemler]  WITH CHECK ADD FOREIGN KEY([hedef_hesapID])
REFERENCES [dbo].[Hesaplar] ([hesapID])
GO
ALTER TABLE [dbo].[Islemler]  WITH CHECK ADD FOREIGN KEY([hesapID])
REFERENCES [dbo].[Hesaplar] ([hesapID])
GO
ALTER TABLE [dbo].[Islemler]  WITH CHECK ADD CHECK  (([islem_turu]='Havale' OR [islem_turu]='Çekme' OR [islem_turu]='Yatırma'))
GO
ALTER TABLE [dbo].[Islemler]  WITH CHECK ADD CHECK  (([tutar]>(0)))
GO
ALTER TABLE [dbo].[Kullanicilar]  WITH CHECK ADD CHECK  (([rol]='Musteri' OR [rol]='Personel' OR [rol]='Admin'))
GO
