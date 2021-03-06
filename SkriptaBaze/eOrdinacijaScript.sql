USE [master]
GO
/****** Object:  Database [eOrdinacija]    Script Date: 7/11/2021 21:25:25 ******/
CREATE DATABASE [eOrdinacija]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'eOrdinacija', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\eOrdinacija.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'eOrdinacija_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\eOrdinacija_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [eOrdinacija] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [eOrdinacija].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [eOrdinacija] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [eOrdinacija] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [eOrdinacija] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [eOrdinacija] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [eOrdinacija] SET ARITHABORT OFF 
GO
ALTER DATABASE [eOrdinacija] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [eOrdinacija] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [eOrdinacija] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [eOrdinacija] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [eOrdinacija] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [eOrdinacija] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [eOrdinacija] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [eOrdinacija] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [eOrdinacija] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [eOrdinacija] SET  DISABLE_BROKER 
GO
ALTER DATABASE [eOrdinacija] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [eOrdinacija] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [eOrdinacija] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [eOrdinacija] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [eOrdinacija] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [eOrdinacija] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [eOrdinacija] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [eOrdinacija] SET RECOVERY FULL 
GO
ALTER DATABASE [eOrdinacija] SET  MULTI_USER 
GO
ALTER DATABASE [eOrdinacija] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [eOrdinacija] SET DB_CHAINING OFF 
GO
ALTER DATABASE [eOrdinacija] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [eOrdinacija] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [eOrdinacija] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'eOrdinacija', N'ON'
GO
ALTER DATABASE [eOrdinacija] SET QUERY_STORE = OFF
GO
USE [eOrdinacija]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/11/2021 21:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Klijent]    Script Date: 7/11/2021 21:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klijent](
	[Ime] [nvarchar](max) NOT NULL,
	[Prezime] [nvarchar](max) NOT NULL,
	[DatumRodjenja] [datetime] NOT NULL,
	[BrojTelefona] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Username] [nvarchar](max) NOT NULL,
	[PasswordHash] [nvarchar](max) NOT NULL,
	[PasswordSalt] [nvarchar](max) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Klijent] SET (LOCK_ESCALATION = AUTO)
GO
/****** Object:  Table [dbo].[Lijek]    Script Date: 7/11/2021 21:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lijek](
	[Naziv] [nvarchar](max) NOT NULL,
	[Cijena] [decimal](18, 2) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nabavka]    Script Date: 7/11/2021 21:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nabavka](
	[UkupanIznos] [decimal](18, 2) NOT NULL,
	[DatumNabavke] [datetime] NOT NULL,
	[ZaposlenikId] [int] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NabavkaMaterijal]    Script Date: 7/11/2021 21:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NabavkaMaterijal](
	[NabavkaId] [int] NOT NULL,
	[MaterijalId] [int] NOT NULL,
	[Kolicina] [decimal](18, 2) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ocjena]    Script Date: 7/11/2021 21:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ocjena](
	[KlijentId] [int] NOT NULL,
	[UslugaId] [int] NOT NULL,
	[Ocjena] [int] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pregled]    Script Date: 7/11/2021 21:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pregled](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ZaposlenikId] [int] NOT NULL,
	[KlijentId] [int] NOT NULL,
	[UslugaId] [int] NOT NULL,
	[ReceptId] [int] NULL,
	[DatumPregleda] [datetime] NOT NULL,
	[VrijemePregleda] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Pregled] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recept]    Script Date: 7/11/2021 21:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recept](
	[KlijentId] [int] NOT NULL,
	[ZaposlenikId] [int] NOT NULL,
	[LijekId] [int] NOT NULL,
	[KolicinaLijeka] [decimal](18, 2) NOT NULL,
	[Napomena] [nvarchar](max) NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervacija]    Script Date: 7/11/2021 21:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervacija](
	[KlijentId] [int] NOT NULL,
	[UslugaId] [int] NOT NULL,
	[Datum] [datetime] NOT NULL,
	[Vrijeme] [nvarchar](max) NOT NULL,
	[Prihvaceno] [bit] NULL,
	[NaCekanju] [bit] NULL,
	[Izvrseno] [bit] NULL,
	[Otkazano] [bit] NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StomatoloskiMaterijal]    Script Date: 7/11/2021 21:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StomatoloskiMaterijal](
	[Naziv] [nvarchar](max) NOT NULL,
	[CijenaPoKomadu] [decimal](18, 2) NOT NULL,
	[StanjeUSkladistu] [int] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uloga]    Script Date: 7/11/2021 21:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uloga](
	[Naziv] [nvarchar](max) NOT NULL,
	[Opis] [nvarchar](max) NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usluga]    Script Date: 7/11/2021 21:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usluga](
	[Naziv] [nvarchar](max) NOT NULL,
	[Cijena] [decimal](18, 2) NOT NULL,
	[Opis] [nvarchar](max) NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UslugaMaterijal]    Script Date: 7/11/2021 21:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UslugaMaterijal](
	[UslugaId] [int] NOT NULL,
	[MaterijalId] [int] NOT NULL,
	[Kolicina] [decimal](18, 2) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zaposlenik]    Script Date: 7/11/2021 21:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zaposlenik](
	[UlogaId] [int] NOT NULL,
	[Ime] [nvarchar](max) NOT NULL,
	[Prezime] [nvarchar](max) NOT NULL,
	[BrojTelefona] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[DatumRodjenja] [datetime] NOT NULL,
	[DatumZaposlenja] [datetime] NOT NULL,
	[Username] [nvarchar](max) NOT NULL,
	[PasswordHash] [nvarchar](max) NOT NULL,
	[PasswordSalt] [nvarchar](max) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[isAdministrator] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Klijent] ON 

INSERT [dbo].[Klijent] ([Ime], [Prezime], [DatumRodjenja], [BrojTelefona], [Email], [Username], [PasswordHash], [PasswordSalt], [Id]) VALUES (N'Klijent', N'Klijent', CAST(N'1983-04-11T00:00:00.000' AS DateTime), N'062333444', N'klijent@gmail.com', N'klijent', N'ntN18grVm2Vko+pDXJfHBHn6zQo=', N'1HcXF0/SFOn/tLP0DwVIQg==', 1007)
SET IDENTITY_INSERT [dbo].[Klijent] OFF
SET IDENTITY_INSERT [dbo].[Lijek] ON 

INSERT [dbo].[Lijek] ([Naziv], [Cijena], [Id]) VALUES (N'Neofen', CAST(25.00 AS Decimal(18, 2)), 2003)
INSERT [dbo].[Lijek] ([Naziv], [Cijena], [Id]) VALUES (N'Neofen FORTE', CAST(32.00 AS Decimal(18, 2)), 2004)
INSERT [dbo].[Lijek] ([Naziv], [Cijena], [Id]) VALUES (N'Brufen', CAST(22.00 AS Decimal(18, 2)), 2005)
INSERT [dbo].[Lijek] ([Naziv], [Cijena], [Id]) VALUES (N'Dontodent', CAST(24.00 AS Decimal(18, 2)), 2006)
INSERT [dbo].[Lijek] ([Naziv], [Cijena], [Id]) VALUES (N'Corega', CAST(18.00 AS Decimal(18, 2)), 2007)
INSERT [dbo].[Lijek] ([Naziv], [Cijena], [Id]) VALUES (N'Flamidez', CAST(26.00 AS Decimal(18, 2)), 2008)
INSERT [dbo].[Lijek] ([Naziv], [Cijena], [Id]) VALUES (N'Ketanov', CAST(24.00 AS Decimal(18, 2)), 2009)
INSERT [dbo].[Lijek] ([Naziv], [Cijena], [Id]) VALUES (N'Ketorol', CAST(16.00 AS Decimal(18, 2)), 2010)
INSERT [dbo].[Lijek] ([Naziv], [Cijena], [Id]) VALUES (N'Nimesulid', CAST(21.00 AS Decimal(18, 2)), 2011)
INSERT [dbo].[Lijek] ([Naziv], [Cijena], [Id]) VALUES (N'Paracetamol', CAST(28.00 AS Decimal(18, 2)), 2012)
INSERT [dbo].[Lijek] ([Naziv], [Cijena], [Id]) VALUES (N'Dexalgin', CAST(19.00 AS Decimal(18, 2)), 2013)
SET IDENTITY_INSERT [dbo].[Lijek] OFF
SET IDENTITY_INSERT [dbo].[Nabavka] ON 

INSERT [dbo].[Nabavka] ([UkupanIznos], [DatumNabavke], [ZaposlenikId], [Id]) VALUES (CAST(900.00 AS Decimal(18, 2)), CAST(N'2021-07-11T00:00:00.000' AS DateTime), 1012, 1033)
SET IDENTITY_INSERT [dbo].[Nabavka] OFF
SET IDENTITY_INSERT [dbo].[NabavkaMaterijal] ON 

INSERT [dbo].[NabavkaMaterijal] ([NabavkaId], [MaterijalId], [Kolicina], [Id]) VALUES (1033, 13, CAST(5.00 AS Decimal(18, 2)), 1052)
INSERT [dbo].[NabavkaMaterijal] ([NabavkaId], [MaterijalId], [Kolicina], [Id]) VALUES (1033, 15, CAST(5.00 AS Decimal(18, 2)), 1053)
SET IDENTITY_INSERT [dbo].[NabavkaMaterijal] OFF
SET IDENTITY_INSERT [dbo].[Ocjena] ON 

INSERT [dbo].[Ocjena] ([KlijentId], [UslugaId], [Ocjena], [Id]) VALUES (1007, 1020, 5, 2008)
INSERT [dbo].[Ocjena] ([KlijentId], [UslugaId], [Ocjena], [Id]) VALUES (1007, 1018, 4, 2009)
SET IDENTITY_INSERT [dbo].[Ocjena] OFF
SET IDENTITY_INSERT [dbo].[Pregled] ON 

INSERT [dbo].[Pregled] ([Id], [ZaposlenikId], [KlijentId], [UslugaId], [ReceptId], [DatumPregleda], [VrijemePregleda]) VALUES (2008, 1012, 1007, 1020, 2009, CAST(N'2021-07-11T00:00:00.000' AS DateTime), N'01:13')
INSERT [dbo].[Pregled] ([Id], [ZaposlenikId], [KlijentId], [UslugaId], [ReceptId], [DatumPregleda], [VrijemePregleda]) VALUES (2009, 1012, 1007, 1018, NULL, CAST(N'2021-07-11T00:00:00.000' AS DateTime), N'01:18')
SET IDENTITY_INSERT [dbo].[Pregled] OFF
SET IDENTITY_INSERT [dbo].[Recept] ON 

INSERT [dbo].[Recept] ([KlijentId], [ZaposlenikId], [LijekId], [KolicinaLijeka], [Napomena], [Id]) VALUES (1007, 1012, 2004, CAST(1.00 AS Decimal(18, 2)), N'2 x dnevno', 2009)
SET IDENTITY_INSERT [dbo].[Recept] OFF
SET IDENTITY_INSERT [dbo].[Rezervacija] ON 

INSERT [dbo].[Rezervacija] ([KlijentId], [UslugaId], [Datum], [Vrijeme], [Prihvaceno], [NaCekanju], [Izvrseno], [Otkazano], [Id]) VALUES (1007, 1020, CAST(N'2021-07-11T00:00:00.000' AS DateTime), N'12:00:00', 1, 1, NULL, NULL, 2015)
INSERT [dbo].[Rezervacija] ([KlijentId], [UslugaId], [Datum], [Vrijeme], [Prihvaceno], [NaCekanju], [Izvrseno], [Otkazano], [Id]) VALUES (1007, 1018, CAST(N'2021-08-12T00:00:00.000' AS DateTime), N'14:00:00', NULL, 1, NULL, NULL, 2016)
INSERT [dbo].[Rezervacija] ([KlijentId], [UslugaId], [Datum], [Vrijeme], [Prihvaceno], [NaCekanju], [Izvrseno], [Otkazano], [Id]) VALUES (1007, 1024, CAST(N'2021-07-13T00:00:00.000' AS DateTime), N'12:00:00', 0, 1, NULL, 1, 2017)
SET IDENTITY_INSERT [dbo].[Rezervacija] OFF
SET IDENTITY_INSERT [dbo].[StomatoloskiMaterijal] ON 

INSERT [dbo].[StomatoloskiMaterijal] ([Naziv], [CijenaPoKomadu], [StanjeUSkladistu], [Id]) VALUES (N'Amalgam', CAST(70.00 AS Decimal(18, 2)), 5, 11)
INSERT [dbo].[StomatoloskiMaterijal] ([Naziv], [CijenaPoKomadu], [StanjeUSkladistu], [Id]) VALUES (N'Adhesor cement', CAST(25.00 AS Decimal(18, 2)), 15, 12)
INSERT [dbo].[StomatoloskiMaterijal] ([Naziv], [CijenaPoKomadu], [StanjeUSkladistu], [Id]) VALUES (N'Cervikalne matrice', CAST(150.00 AS Decimal(18, 2)), 15, 13)
INSERT [dbo].[StomatoloskiMaterijal] ([Naziv], [CijenaPoKomadu], [StanjeUSkladistu], [Id]) VALUES (N'Titanium matrice', CAST(20.00 AS Decimal(18, 2)), 20, 14)
INSERT [dbo].[StomatoloskiMaterijal] ([Naziv], [CijenaPoKomadu], [StanjeUSkladistu], [Id]) VALUES (N'Pasta za poliranje', CAST(30.00 AS Decimal(18, 2)), 10, 15)
INSERT [dbo].[StomatoloskiMaterijal] ([Naziv], [CijenaPoKomadu], [StanjeUSkladistu], [Id]) VALUES (N'Alginati', CAST(35.00 AS Decimal(18, 2)), 10, 16)
INSERT [dbo].[StomatoloskiMaterijal] ([Naziv], [CijenaPoKomadu], [StanjeUSkladistu], [Id]) VALUES (N'Artikulacijski papir', CAST(10.00 AS Decimal(18, 2)), 40, 17)
INSERT [dbo].[StomatoloskiMaterijal] ([Naziv], [CijenaPoKomadu], [StanjeUSkladistu], [Id]) VALUES (N'Gumice za poliranje', CAST(20.00 AS Decimal(18, 2)), 15, 18)
INSERT [dbo].[StomatoloskiMaterijal] ([Naziv], [CijenaPoKomadu], [StanjeUSkladistu], [Id]) VALUES (N'Otisne mase', CAST(25.00 AS Decimal(18, 2)), 30, 21)
INSERT [dbo].[StomatoloskiMaterijal] ([Naziv], [CijenaPoKomadu], [StanjeUSkladistu], [Id]) VALUES (N'Logan kočići', CAST(45.00 AS Decimal(18, 2)), 10, 22)
INSERT [dbo].[StomatoloskiMaterijal] ([Naziv], [CijenaPoKomadu], [StanjeUSkladistu], [Id]) VALUES (N'Akrilati', CAST(55.00 AS Decimal(18, 2)), 20, 23)
INSERT [dbo].[StomatoloskiMaterijal] ([Naziv], [CijenaPoKomadu], [StanjeUSkladistu], [Id]) VALUES (N'Dezinficijensi', CAST(15.00 AS Decimal(18, 2)), 30, 24)
SET IDENTITY_INSERT [dbo].[StomatoloskiMaterijal] OFF
SET IDENTITY_INSERT [dbo].[Uloga] ON 

INSERT [dbo].[Uloga] ([Naziv], [Opis], [Id]) VALUES (N'Stomatolog', N'Osnovni zadatak doktora stomatologije – stomatologa je da liječi sva oboljenja zuba, desni i vilica i ostalih tkiva usne duplje, a i njene okoline.

Uz to, on se bavi i odstranjivanjem anomalija zuba, a i anomalijama njihovog položaja. Razumije se da se bavi i nadoknadom izgubljenih zuba i poboljšanjem estetike ove regije i čitavog lica.

', 1)
INSERT [dbo].[Uloga] ([Naziv], [Opis], [Id]) VALUES (N'Sestra', N'Stomatološke sestre asistiraju stomatolozima u svakodnevnom radu. To se odnosi kako na administrativni dio posla, tako i na stručni: asistiraju pri izradi zamjena i pomoćnih pomagala. To se prije svega odnosi na izradu nadogradnja za zube ili dijelove zuba koji nedostaju i na izradu pomagala za ispravljanje anomalija u rastu zuba i vilice.', 2)
SET IDENTITY_INSERT [dbo].[Uloga] OFF
SET IDENTITY_INSERT [dbo].[Usluga] ON 

INSERT [dbo].[Usluga] ([Naziv], [Cijena], [Opis], [Id]) VALUES (N'Uklanjanje zubnog kamenca ', CAST(50.00 AS Decimal(18, 2)), N'Uklanjanje zubnog kamenca ', 1018)
INSERT [dbo].[Usluga] ([Naziv], [Cijena], [Opis], [Id]) VALUES (N'Pjeskarenje zuba – airflow', CAST(50.00 AS Decimal(18, 2)), N'Pjeskarenje zuba – airflow', 1019)
INSERT [dbo].[Usluga] ([Naziv], [Cijena], [Opis], [Id]) VALUES (N'Vađenje zuba sa anestezijom', CAST(40.00 AS Decimal(18, 2)), N'Vađenje zuba sa anestezijom', 1020)
INSERT [dbo].[Usluga] ([Naziv], [Cijena], [Opis], [Id]) VALUES (N'Komplikovano vađenje zuba', CAST(50.00 AS Decimal(18, 2)), N'Komplikovano vađenje zuba', 1021)
INSERT [dbo].[Usluga] ([Naziv], [Cijena], [Opis], [Id]) VALUES (N'Zubni implantati', CAST(1200.00 AS Decimal(18, 2)), N'Zubni implantati', 1022)
INSERT [dbo].[Usluga] ([Naziv], [Cijena], [Opis], [Id]) VALUES (N'Mini zubni implantat', CAST(800.00 AS Decimal(18, 2)), N'Mini zubni implantat', 1023)
INSERT [dbo].[Usluga] ([Naziv], [Cijena], [Opis], [Id]) VALUES (N'Popravak zuba /amalgam/', CAST(40.00 AS Decimal(18, 2)), N'Popravak zuba /amalgam/', 1024)
INSERT [dbo].[Usluga] ([Naziv], [Cijena], [Opis], [Id]) VALUES (N'Popravak zuba /kompozit/', CAST(40.00 AS Decimal(18, 2)), N'Popravak zuba /kompozit/', 1025)
INSERT [dbo].[Usluga] ([Naziv], [Cijena], [Opis], [Id]) VALUES (N'CAD CAM keramičke plombe ', CAST(120.00 AS Decimal(18, 2)), N'CAD CAM keramičke plombe ', 1026)
INSERT [dbo].[Usluga] ([Naziv], [Cijena], [Opis], [Id]) VALUES (N'Nadogradnja prednjeg zuba', CAST(50.00 AS Decimal(18, 2)), N'Nadogradnja prednjeg zuba', 1027)
INSERT [dbo].[Usluga] ([Naziv], [Cijena], [Opis], [Id]) VALUES (N'Mašinsko liječenje zuba', CAST(150.00 AS Decimal(18, 2)), N'Mašinsko liječenje zuba', 1028)
INSERT [dbo].[Usluga] ([Naziv], [Cijena], [Opis], [Id]) VALUES (N'Revizija liječenja korijena', CAST(140.00 AS Decimal(18, 2)), N'Revizija liječenja korijena', 1029)
INSERT [dbo].[Usluga] ([Naziv], [Cijena], [Opis], [Id]) VALUES (N'Izbjeljivanje samo jednog zuba', CAST(100.00 AS Decimal(18, 2)), N'Izbjeljivanje samo jednog zuba', 1030)
SET IDENTITY_INSERT [dbo].[Usluga] OFF
SET IDENTITY_INSERT [dbo].[UslugaMaterijal] ON 

INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1018, 15, CAST(1.00 AS Decimal(18, 2)), 1039)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1018, 24, CAST(1.00 AS Decimal(18, 2)), 1040)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1019, 15, CAST(2.00 AS Decimal(18, 2)), 1041)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1019, 18, CAST(1.00 AS Decimal(18, 2)), 1042)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1020, 21, CAST(1.00 AS Decimal(18, 2)), 1043)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1020, 11, CAST(1.00 AS Decimal(18, 2)), 1044)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1021, 13, CAST(1.00 AS Decimal(18, 2)), 1045)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1021, 23, CAST(1.00 AS Decimal(18, 2)), 1046)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1022, 22, CAST(1.00 AS Decimal(18, 2)), 1047)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1022, 17, CAST(1.00 AS Decimal(18, 2)), 1048)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1023, 22, CAST(1.00 AS Decimal(18, 2)), 1049)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1024, 11, CAST(1.00 AS Decimal(18, 2)), 1050)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1025, 17, CAST(1.00 AS Decimal(18, 2)), 1051)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1025, 12, CAST(1.00 AS Decimal(18, 2)), 1052)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1026, 13, CAST(1.00 AS Decimal(18, 2)), 1053)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1026, 12, CAST(1.00 AS Decimal(18, 2)), 1054)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1027, 12, CAST(1.00 AS Decimal(18, 2)), 1055)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1029, 24, CAST(1.00 AS Decimal(18, 2)), 1056)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1029, 16, CAST(1.00 AS Decimal(18, 2)), 1057)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1028, 24, CAST(1.00 AS Decimal(18, 2)), 1058)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1028, 14, CAST(1.00 AS Decimal(18, 2)), 1059)
INSERT [dbo].[UslugaMaterijal] ([UslugaId], [MaterijalId], [Kolicina], [Id]) VALUES (1030, 18, CAST(1.00 AS Decimal(18, 2)), 1060)
SET IDENTITY_INSERT [dbo].[UslugaMaterijal] OFF
SET IDENTITY_INSERT [dbo].[Zaposlenik] ON 

INSERT [dbo].[Zaposlenik] ([UlogaId], [Ime], [Prezime], [BrojTelefona], [Email], [DatumRodjenja], [DatumZaposlenja], [Username], [PasswordHash], [PasswordSalt], [Id], [isAdministrator]) VALUES (1, N'Zaposlenik', N'Zaposlenik', N'061111222', N'admin@gmail.com', CAST(N'1993-06-23T00:37:51.000' AS DateTime), CAST(N'2015-02-14T00:37:51.000' AS DateTime), N'zaposlenik', N'b4qeh01XGNZs0eQqk9NLvfHk92Y=', N'afz+frPhFZQtSJ6HrGcslA==', 1012, 1)
SET IDENTITY_INSERT [dbo].[Zaposlenik] OFF
ALTER TABLE [dbo].[Nabavka]  WITH CHECK ADD  CONSTRAINT [FK_Nabavka_Zaposlenik] FOREIGN KEY([ZaposlenikId])
REFERENCES [dbo].[Zaposlenik] ([Id])
GO
ALTER TABLE [dbo].[Nabavka] CHECK CONSTRAINT [FK_Nabavka_Zaposlenik]
GO
ALTER TABLE [dbo].[NabavkaMaterijal]  WITH CHECK ADD  CONSTRAINT [FK_NabavkaMaterijal_Nabavka] FOREIGN KEY([NabavkaId])
REFERENCES [dbo].[Nabavka] ([Id])
GO
ALTER TABLE [dbo].[NabavkaMaterijal] CHECK CONSTRAINT [FK_NabavkaMaterijal_Nabavka]
GO
ALTER TABLE [dbo].[NabavkaMaterijal]  WITH CHECK ADD  CONSTRAINT [FK_NabavkaMaterijal_StomatoloskiMaterijal] FOREIGN KEY([MaterijalId])
REFERENCES [dbo].[StomatoloskiMaterijal] ([Id])
GO
ALTER TABLE [dbo].[NabavkaMaterijal] CHECK CONSTRAINT [FK_NabavkaMaterijal_StomatoloskiMaterijal]
GO
ALTER TABLE [dbo].[Ocjena]  WITH CHECK ADD  CONSTRAINT [FK_Ocjena_Klijent] FOREIGN KEY([KlijentId])
REFERENCES [dbo].[Klijent] ([Id])
GO
ALTER TABLE [dbo].[Ocjena] CHECK CONSTRAINT [FK_Ocjena_Klijent]
GO
ALTER TABLE [dbo].[Ocjena]  WITH CHECK ADD  CONSTRAINT [FK_Ocjena_Usluga] FOREIGN KEY([UslugaId])
REFERENCES [dbo].[Usluga] ([Id])
GO
ALTER TABLE [dbo].[Ocjena] CHECK CONSTRAINT [FK_Ocjena_Usluga]
GO
ALTER TABLE [dbo].[Pregled]  WITH CHECK ADD  CONSTRAINT [FK_Pregled_Klijent] FOREIGN KEY([KlijentId])
REFERENCES [dbo].[Klijent] ([Id])
GO
ALTER TABLE [dbo].[Pregled] CHECK CONSTRAINT [FK_Pregled_Klijent]
GO
ALTER TABLE [dbo].[Pregled]  WITH CHECK ADD  CONSTRAINT [FK_Pregled_Recept] FOREIGN KEY([ReceptId])
REFERENCES [dbo].[Recept] ([Id])
GO
ALTER TABLE [dbo].[Pregled] CHECK CONSTRAINT [FK_Pregled_Recept]
GO
ALTER TABLE [dbo].[Pregled]  WITH CHECK ADD  CONSTRAINT [FK_Pregled_Usluga] FOREIGN KEY([UslugaId])
REFERENCES [dbo].[Usluga] ([Id])
GO
ALTER TABLE [dbo].[Pregled] CHECK CONSTRAINT [FK_Pregled_Usluga]
GO
ALTER TABLE [dbo].[Pregled]  WITH CHECK ADD  CONSTRAINT [FK_Pregled_Zaposlenik] FOREIGN KEY([ZaposlenikId])
REFERENCES [dbo].[Zaposlenik] ([Id])
GO
ALTER TABLE [dbo].[Pregled] CHECK CONSTRAINT [FK_Pregled_Zaposlenik]
GO
ALTER TABLE [dbo].[Recept]  WITH CHECK ADD  CONSTRAINT [FK_Recept_Klijent] FOREIGN KEY([KlijentId])
REFERENCES [dbo].[Klijent] ([Id])
GO
ALTER TABLE [dbo].[Recept] CHECK CONSTRAINT [FK_Recept_Klijent]
GO
ALTER TABLE [dbo].[Recept]  WITH CHECK ADD  CONSTRAINT [FK_Recept_Lijek] FOREIGN KEY([LijekId])
REFERENCES [dbo].[Lijek] ([Id])
GO
ALTER TABLE [dbo].[Recept] CHECK CONSTRAINT [FK_Recept_Lijek]
GO
ALTER TABLE [dbo].[Recept]  WITH CHECK ADD  CONSTRAINT [FK_Recept_Zaposlenik] FOREIGN KEY([ZaposlenikId])
REFERENCES [dbo].[Zaposlenik] ([Id])
GO
ALTER TABLE [dbo].[Recept] CHECK CONSTRAINT [FK_Recept_Zaposlenik]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Klijent] FOREIGN KEY([KlijentId])
REFERENCES [dbo].[Klijent] ([Id])
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Klijent]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Usluga] FOREIGN KEY([UslugaId])
REFERENCES [dbo].[Usluga] ([Id])
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Usluga]
GO
ALTER TABLE [dbo].[UslugaMaterijal]  WITH CHECK ADD  CONSTRAINT [FK_UslugaMaterijal_StomatoloskiMaterijal] FOREIGN KEY([MaterijalId])
REFERENCES [dbo].[StomatoloskiMaterijal] ([Id])
GO
ALTER TABLE [dbo].[UslugaMaterijal] CHECK CONSTRAINT [FK_UslugaMaterijal_StomatoloskiMaterijal]
GO
ALTER TABLE [dbo].[UslugaMaterijal]  WITH CHECK ADD  CONSTRAINT [FK_UslugaMaterijal_Usluga] FOREIGN KEY([UslugaId])
REFERENCES [dbo].[Usluga] ([Id])
GO
ALTER TABLE [dbo].[UslugaMaterijal] CHECK CONSTRAINT [FK_UslugaMaterijal_Usluga]
GO
ALTER TABLE [dbo].[Zaposlenik]  WITH CHECK ADD  CONSTRAINT [FK_Zaposlenik_Uloga] FOREIGN KEY([UlogaId])
REFERENCES [dbo].[Uloga] ([Id])
GO
ALTER TABLE [dbo].[Zaposlenik] CHECK CONSTRAINT [FK_Zaposlenik_Uloga]
GO
USE [master]
GO
ALTER DATABASE [eOrdinacija] SET  READ_WRITE 
GO
