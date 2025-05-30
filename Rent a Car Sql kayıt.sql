USE [Araç_Kiralama]
GO
/****** Object:  Table [dbo].[araç]    Script Date: 5.05.2024 22:36:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[araç](
	[plaka] [nvarchar](50) NOT NULL,
	[marka] [nvarchar](50) NOT NULL,
	[seri] [nvarchar](50) NOT NULL,
	[yil] [nvarchar](50) NOT NULL,
	[renk] [nvarchar](50) NOT NULL,
	[km] [nvarchar](50) NOT NULL,
	[yakit] [nvarchar](50) NOT NULL,
	[kiraucreti] [int] NOT NULL,
	[resim] [nvarchar](100) NOT NULL,
	[tarih] [nvarchar](50) NOT NULL,
	[durumu] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteri]    Script Date: 5.05.2024 22:36:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteri](
	[tc] [nvarchar](50) NOT NULL,
	[adsoyad] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[adres] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[satis]    Script Date: 5.05.2024 22:36:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[satis](
	[tc] [nvarchar](50) NOT NULL,
	[adsoyad] [nvarchar](50) NOT NULL,
	[plaka] [nvarchar](50) NOT NULL,
	[marka] [nvarchar](50) NOT NULL,
	[seri] [nvarchar](50) NOT NULL,
	[yıl] [nvarchar](50) NOT NULL,
	[renk] [nvarchar](50) NOT NULL,
	[gun] [int] NOT NULL,
	[fiyat] [int] NOT NULL,
	[tutar] [int] NOT NULL,
	[tarih1] [nvarchar](50) NOT NULL,
	[tarih2] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sözleşme]    Script Date: 5.05.2024 22:36:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sözleşme](
	[tc] [int] NOT NULL,
	[adsoyad] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[ehliyetno] [nvarchar](50) NOT NULL,
	[e_tarih] [nvarchar](50) NOT NULL,
	[e_yer] [nvarchar](50) NOT NULL,
	[plaka] [nvarchar](50) NOT NULL,
	[marka] [nvarchar](50) NOT NULL,
	[seri] [nvarchar](50) NOT NULL,
	[yil] [nvarchar](50) NOT NULL,
	[renk] [nvarchar](50) NOT NULL,
	[kirasekli] [nvarchar](50) NOT NULL,
	[kiraucreti] [int] NOT NULL,
	[gun] [int] NOT NULL,
	[tutar] [int] NOT NULL,
	[ctarih] [nvarchar](50) NOT NULL,
	[dtarih] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[araç] ([plaka], [marka], [seri], [yil], [renk], [km], [yakit], [kiraucreti], [resim], [tarih], [durumu]) VALUES (N'34 M 5685', N'Ford', N'Transit', N'2016', N'Beyaz', N'1000', N'Benzin', 5000, N'C:\Users\W10\Downloads\WhatsApp Image 2024-05-04 at 21.10.17.jpeg', N'5.05.2024 15:58:42', N'BOŞ')
INSERT [dbo].[araç] ([plaka], [marka], [seri], [yil], [renk], [km], [yakit], [kiraucreti], [resim], [tarih], [durumu]) VALUES (N'55 ND 8978', N'Nissan', N'GTR', N'2023', N'Kırmızı', N'0', N'Benzin', 10, N'C:\Users\W10\Downloads\WhatsApp Image 2024-02-03 at 23.48.39 - Kopya.jpeg', N'5.05.2024 13:20:52', N'DOLU')
INSERT [dbo].[araç] ([plaka], [marka], [seri], [yil], [renk], [km], [yakit], [kiraucreti], [resim], [tarih], [durumu]) VALUES (N'34 NZ 5685', N'Toyota', N'Supra', N'1998', N'Bordo', N'11000', N'Benzin', 50000, N'C:\Users\W10\Downloads\WhatsApp Image 2024-02-03 at 23.48.40.jpeg', N'5.05.2024 13:19:29', N'DOLU')
GO
INSERT [dbo].[musteri] ([tc], [adsoyad], [telefon], [adres], [email]) VALUES (N'23819755190', N'Atilla Eymen Fison', N'05698745', N'Çınar Mahallesi', N'fsn@gmail.com')
INSERT [dbo].[musteri] ([tc], [adsoyad], [telefon], [adres], [email]) VALUES (N'123456789', N'Kaan Dağkuş', N'05457896514', N'Kocaeli', N'kaandgks@gmail.com')
GO
INSERT [dbo].[sözleşme] ([tc], [adsoyad], [telefon], [ehliyetno], [e_tarih], [e_yer], [plaka], [marka], [seri], [yil], [renk], [kirasekli], [kiraucreti], [gun], [tutar], [ctarih], [dtarih]) VALUES (123456789, N'Kaan Dağkuş', N'05457896514', N'123564', N'2323', N'12315', N'55 ND 8978', N'Nissan', N'GTR', N'2023', N'Kırmızı', N'Haftalık', 8, 12, 96, N'5 Mayıs 2024 Pazar', N'17 Mayıs 2024 Cuma')
INSERT [dbo].[sözleşme] ([tc], [adsoyad], [telefon], [ehliyetno], [e_tarih], [e_yer], [plaka], [marka], [seri], [yil], [renk], [kirasekli], [kiraucreti], [gun], [tutar], [ctarih], [dtarih]) VALUES (123456789, N'Kaan Dağkuş', N'05457896514', N'2563', N'4234', N'324234', N'34 NZ 5685', N'Toyota', N'Supra', N'1998', N'Bordo', N'Haftalık', 40000, 11, 440000, N'5 Mayıs 2024 Pazar', N'16 Mayıs 2024 Perşembe')
GO
