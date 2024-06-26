USE [master]
GO
/****** Object:  Database [NGANHANG]    Script Date: 25/06/2024 4:50:14 CH ******/
CREATE DATABASE [NGANHANG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NGANHANG', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SERVER\MSSQL\DATA\NGANHANG.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NGANHANG_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SERVER\MSSQL\DATA\NGANHANG_log.ldf' , SIZE = 204800KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [NGANHANG] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NGANHANG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NGANHANG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NGANHANG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NGANHANG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NGANHANG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NGANHANG] SET ARITHABORT OFF 
GO
ALTER DATABASE [NGANHANG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NGANHANG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NGANHANG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NGANHANG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NGANHANG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NGANHANG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NGANHANG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NGANHANG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NGANHANG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NGANHANG] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NGANHANG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NGANHANG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NGANHANG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NGANHANG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NGANHANG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NGANHANG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NGANHANG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NGANHANG] SET RECOVERY FULL 
GO
ALTER DATABASE [NGANHANG] SET  MULTI_USER 
GO
ALTER DATABASE [NGANHANG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NGANHANG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NGANHANG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NGANHANG] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NGANHANG] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NGANHANG] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'NGANHANG', N'ON'
GO
ALTER DATABASE [NGANHANG] SET QUERY_STORE = ON
GO
ALTER DATABASE [NGANHANG] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [NGANHANG]
GO
/****** Object:  User [HTKN]    Script Date: 25/06/2024 4:50:14 CH ******/
CREATE USER [HTKN] FOR LOGIN [HTKN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [MSmerge_PAL_role]    Script Date: 25/06/2024 4:50:14 CH ******/
CREATE ROLE [MSmerge_PAL_role]
GO
/****** Object:  DatabaseRole [MSmerge_CD12F788134A40669F062A85F1F37392]    Script Date: 25/06/2024 4:50:14 CH ******/
CREATE ROLE [MSmerge_CD12F788134A40669F062A85F1F37392]
GO
/****** Object:  DatabaseRole [MSmerge_B925972442064633B34AF1663078E6FE]    Script Date: 25/06/2024 4:50:14 CH ******/
CREATE ROLE [MSmerge_B925972442064633B34AF1663078E6FE]
GO
/****** Object:  DatabaseRole [MSmerge_80E40A7DF98246889843BA2AC47FC723]    Script Date: 25/06/2024 4:50:14 CH ******/
CREATE ROLE [MSmerge_80E40A7DF98246889843BA2AC47FC723]
GO
ALTER ROLE [db_datareader] ADD MEMBER [HTKN]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_CD12F788134A40669F062A85F1F37392]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_B925972442064633B34AF1663078E6FE]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_80E40A7DF98246889843BA2AC47FC723]
GO
/****** Object:  Schema [MSmerge_PAL_role]    Script Date: 25/06/2024 4:50:14 CH ******/
CREATE SCHEMA [MSmerge_PAL_role]
GO
/****** Object:  View [dbo].[V_DS_PHANMANH]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_DS_PHANMANH]
AS
SELECT TOP (2) PUBS.description AS TENCN, SUBS.subscriber_server AS TENSERVER
FROM     dbo.sysmergepublications AS PUBS INNER JOIN
                  dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[MACN] [nchar](10) NOT NULL,
	[TENCN] [nvarchar](100) NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[SoDT] [nvarchar](15) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[MACN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_ChiNhanh] UNIQUE NONCLUSTERED 
(
	[TENCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GD_CHUYENTIEN]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GD_CHUYENTIEN](
	[MAGD] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SOTK_CHUYEN] [nchar](9) NOT NULL,
	[NGAYGD] [datetime] NOT NULL,
	[SOTIEN] [money] NOT NULL,
	[SOTK_NHAN] [nchar](9) NOT NULL,
	[MANV] [nchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_GD_CHUYENTIEN] PRIMARY KEY CLUSTERED 
(
	[MAGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GD_GOIRUT]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GD_GOIRUT](
	[MAGD] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SOTK] [nchar](9) NOT NULL,
	[LOAIGD] [nchar](2) NOT NULL,
	[NGAYGD] [datetime] NOT NULL,
	[SOTIEN] [money] NOT NULL,
	[MANV] [nchar](10) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_GD_GOIRUT] PRIMARY KEY CLUSTERED 
(
	[MAGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[CMND] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[PHAI] [nvarchar](3) NULL,
	[NGAYCAP] [date] NOT NULL,
	[SODT] [nvarchar](15) NOT NULL,
	[MACN] [nchar](10) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MANV] [nchar](10) NOT NULL,
	[HO] [nvarchar](40) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[CMND] [nchar](10) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[PHAI] [nvarchar](3) NOT NULL,
	[SODT] [nvarchar](15) NOT NULL,
	[MACN] [nchar](10) NULL,
	[TrangThaiXoa] [int] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UC_CMND] UNIQUE NONCLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[SOTK] [nchar](9) NOT NULL,
	[CMND] [nchar](10) NOT NULL,
	[SODU] [money] NOT NULL,
	[MACN] [nchar](10) NOT NULL,
	[NGAYMOTK] [datetime] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[SOTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_901578250]    Script Date: 25/06/2024 4:50:14 CH ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_901578250] ON [dbo].[ChiNhanh]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_933578364]    Script Date: 25/06/2024 4:50:14 CH ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_933578364] ON [dbo].[GD_CHUYENTIEN]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_965578478]    Script Date: 25/06/2024 4:50:14 CH ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_965578478] ON [dbo].[GD_GOIRUT]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_997578592]    Script Date: 25/06/2024 4:50:14 CH ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_997578592] ON [dbo].[KhachHang]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1029578706]    Script Date: 25/06/2024 4:50:14 CH ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1029578706] ON [dbo].[NhanVien]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1445580188]    Script Date: 25/06/2024 4:50:14 CH ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1445580188] ON [dbo].[TaiKhoan]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiNhanh] ADD  CONSTRAINT [MSmerge_df_rowguid_DF049987AC634A52AC97FBDC4453AFBF]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] ADD  CONSTRAINT [DF_GD_CHUYENTIEN_NGAYGD]  DEFAULT (getdate()) FOR [NGAYGD]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] ADD  CONSTRAINT [MSmerge_df_rowguid_9D4C7CF18C934FABB8E24E843F39964A]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[GD_GOIRUT] ADD  CONSTRAINT [DF_GD_GOIRUT_NGAYGD]  DEFAULT (getdate()) FOR [NGAYGD]
GO
ALTER TABLE [dbo].[GD_GOIRUT] ADD  CONSTRAINT [DF_GD_GOIRUT_SOTIEN]  DEFAULT ((100000)) FOR [SOTIEN]
GO
ALTER TABLE [dbo].[GD_GOIRUT] ADD  CONSTRAINT [MSmerge_df_rowguid_9E10DCE2EEF948EBA988DFB3BDE84909]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [MSmerge_df_rowguid_F8855F5A2983477AA25180B9775597C6]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_NhanVien_PHAI]  DEFAULT (N'Nam') FOR [PHAI]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_TTX_NV]  DEFAULT ((0)) FOR [TrangThaiXoa]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [MSmerge_df_rowguid_5C5CEC2DED6A4DE289CD66EE35CB362B]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  CONSTRAINT [DF__TaiKhoan__SODU__45F365D3]  DEFAULT ((0)) FOR [SODU]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  CONSTRAINT [MSmerge_df_rowguid_88599FAA60B240088B290783E981335D]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH CHECK ADD  CONSTRAINT [FK_GD_CHUYENTIEN_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [FK_GD_CHUYENTIEN_NhanVien]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH CHECK ADD  CONSTRAINT [FK_GD_CHUYENTIEN_TaiKhoan] FOREIGN KEY([SOTK_CHUYEN])
REFERENCES [dbo].[TaiKhoan] ([SOTK])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [FK_GD_CHUYENTIEN_TaiKhoan]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH CHECK ADD  CONSTRAINT [FK_GD_CHUYENTIEN_TaiKhoan1] FOREIGN KEY([SOTK_NHAN])
REFERENCES [dbo].[TaiKhoan] ([SOTK])
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [FK_GD_CHUYENTIEN_TaiKhoan1]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [FK_GD_GOIRUT_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [FK_GD_GOIRUT_NhanVien]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [FK_GD_GOIRUT_TaiKhoan] FOREIGN KEY([SOTK])
REFERENCES [dbo].[TaiKhoan] ([SOTK])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [FK_GD_GOIRUT_TaiKhoan]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_ChiNhanh]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChiNhanh]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_ChiNhanh]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_KhachHang] FOREIGN KEY([CMND])
REFERENCES [dbo].[KhachHang] ([CMND])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_KhachHang]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH CHECK ADD  CONSTRAINT [CK_GD_CHUYENTIEN] CHECK  (([SOTIEN]>(0)))
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [CK_GD_CHUYENTIEN]
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_DE9A0042_EC09_42FA_8E5F_0500E106755D] CHECK NOT FOR REPLICATION (([MAGD]>(2) AND [MAGD]<=(1002) OR [MAGD]>(1002) AND [MAGD]<=(2002)))
GO
ALTER TABLE [dbo].[GD_CHUYENTIEN] CHECK CONSTRAINT [repl_identity_range_DE9A0042_EC09_42FA_8E5F_0500E106755D]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [CK_LOAIGD] CHECK  (([LOAIGD]='RT' OR [LOAIGD]='GT'))
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [CK_LOAIGD]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH CHECK ADD  CONSTRAINT [CK_SOTIEN] CHECK  (([SOTIEN]>=(100000)))
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [CK_SOTIEN]
GO
ALTER TABLE [dbo].[GD_GOIRUT]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_E81E21FD_DB5D_44B9_A558_FD8B3B8D84DD] CHECK NOT FOR REPLICATION (([MAGD]>(9) AND [MAGD]<=(1009) OR [MAGD]>(1009) AND [MAGD]<=(2009)))
GO
ALTER TABLE [dbo].[GD_GOIRUT] CHECK CONSTRAINT [repl_identity_range_E81E21FD_DB5D_44B9_A558_FD8B3B8D84DD]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [CHK_SODU] CHECK  (([SODU]>=(0)))
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [CHK_SODU]
GO
/****** Object:  StoredProcedure [dbo].[frmChuyenTien_thuchienGD]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[frmChuyenTien_thuchienGD] @SOTK_CHUYEN NCHAR(9),@SOTK_NHAN NCHAR(9),@SOTIEN MONEY,@NGAYGD DATETIME, @MANV NCHAR(10)
AS
BEGIN
	SET XACT_ABORT ON;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	BEGIN TRY
		BEGIN TRANSACTION;
			IF NOT EXISTS(SELECT SOTK FROM TaiKhoan where SOTK=@SOTK_NHAN)
			BEGIN
				UPDATE LINK1.NGANHANG.dbo.TaiKhoan 
				SET SODU = SODU + @SOTIEN
				WHERE SOTK = @SOTK_NHAN
			END
			ELSE
			BEGIN
				UPDATE dbo.TaiKhoan 
				SET SODU = SODU + @SOTIEN
				WHERE SOTK = @SOTK_NHAN
			END
			UPDATE dbo.TaiKhoan
			SET SODU = SODU - @SOTIEN
			WHERE SOTK = @SOTK_CHUYEN
			
			INSERT INTO dbo.GD_CHUYENTIEN(SOTK_CHUYEN,NGAYGD,SOTIEN, SOTK_NHAN,MANV)
			VALUES(@SOTK_CHUYEN,@NGAYGD, @SOTIEN,@SOTK_NHAN,@MANV)
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF (@@TRANCOUNT > 0)
		BEGIN
			ROLLBACK TRANSACTION;
			DECLARE @ErrorMessage NVARCHAR(2000)
			SELECT @ErrorMessage = 'LOI: ' + ERROR_MESSAGE()
			RAISERROR (@ErrorMessage,16,1)
			--THROW;
		END
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[frmGoiRut_thuchienGD]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[frmGoiRut_thuchienGD] @SOTK NCHAR(9), @LOAIGD NCHAR(2), @NGAYGD DATETIME, @SOTIEN MONEY, @MANV NCHAR(10)
AS
BEGIN
	SET XACT_ABORT ON;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	BEGIN TRY
		BEGIN TRANSACTION;
			DECLARE @SODUTRC MONEY;
			SELECT @SODUTRC = SODU FROM dbo.TaiKhoan WHERE SOTK = @SOTK;
			DECLARE @SODUSAU MONEY;
				IF @LOAIGD = 'RT'
				BEGIN
					SET @SODUSAU = @SODUTRC - @SOTIEN;				
				END

				ELSE IF @LOAIGD = 'GT'
					SET @SODUSAU = @SODUTRC + @SOTIEN;

				INSERT INTO dbo.GD_GOIRUT (SOTK,LOAIGD,NGAYGD,SOTIEN,MANV) 
					VALUES (@SOTK,@LOAIGD,@NGAYGD,@SOTIEN,@MANV)
				UPDATE dbo.TaiKhoan
					SET SODU = @SODUSAU
						WHERE SOTK = @SOTK
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF (@@TRANCOUNT > 0)
		BEGIN
			ROLLBACK TRANSACTION;
			DECLARE @ErrorMessage NVARCHAR(2000)
			SELECT @ErrorMessage = 'LOI: ' + ERROR_MESSAGE()
			RAISERROR (@ErrorMessage,16,1)
			--THROW;
		END
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[frmKhachHang_trungCMND]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[frmKhachHang_trungCMND] @CMND NVARCHAR (20)
AS
IF  EXISTS(SELECT CMND FROM LINK2.NGANHANG.DBO.KhachHang WHERE CMND =@CMND)
BEGIN
	SELECT CMND FROM LINK2.NGANHANG.DBO.KhachHang WHERE CMND = @CMND
END
GO
/****** Object:  StoredProcedure [dbo].[frmNhanVien_ChuyenNV]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[frmNhanVien_ChuyenNV] /*khong duoc thay cmnd thanh manv va thieu rollback*/
@MANVCU NCHAR(10), @MANV NCHAR(10), @MACN NCHAR(10)
AS
BEGIN
	SET XACT_ABORT ON;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

	DECLARE @LGNAME VARCHAR(50);
	DECLARE @USERNAME VARCHAR(50);
	DECLARE @CMNDCU nchar(10);
	SET @LGNAME = (SELECT SUSER_SNAME(sid) FROM sys.sysusers WHERE name = @MANVCU);
	SET @USERNAME = @MANVCU;
	SET @CMNDCU=(SELECT CMND FROM NhanVien WHERE MANV=@MANVCU);
		BEGIN DISTRIBUTED TRAN
			IF EXISTS(SELECT MANV FROM LINK1.NGANHANG.dbo.NhanVien WHERE MANV = @MANV AND TrangThaiXoa=1)
			BEGIN
				UPDATE LINK1.NGANHANG.dbo.NhanVien
				SET TrangThaiXoa = 0,CMND=@CMNDCU
				WHERE MANV = @MANV;

				UPDATE NhanVien
				SET TrangThaiXoa = 1,CMND=@MANV
				WHERE MANV = @MANVCU;
			END
			ELSE IF EXISTS(SELECT MANV FROM LINK1.NGANHANG.dbo.NhanVien WHERE MANV = @MANV AND TrangThaiXoa=0)
				THROW 50000, N'Mã nhân viên đã tồn tại!', 16;	
			ELSE
			BEGIN
				INSERT INTO LINK1.NGANHANG.dbo.NhanVien (MANV, HO, TEN, DIACHI,CMND, PHAI, SODT, MACN, TRANGTHAIXOA)
				(
					SELECT MANV = @MANV, HO, TEN, DIACHI,CMND, PHAI, SODT, MACN = @MACN, TRANGTHAIXOA
					FROM dbo.NhanVien
					WHERE MANV = @MANVCU
				)
				UPDATE dbo.NhanVien
				SET TrangThaiXoa = 1,CMND=@MANV
				WHERE MANV = @MANVCU;
			END		
		COMMIT TRAN;
		IF EXISTS(SELECT SUSER_SNAME(sid) FROM sys.sysusers WHERE name = @MANVCU)
		BEGIN
			SET @LGNAME = CAST((SELECT SUSER_SNAME(sid) FROM sys.sysusers WHERE name = CAST(@MANVCU AS NVARCHAR)) AS VARCHAR(50))
			SET @USERNAME = CAST(@MANVCU AS VARCHAR(50))
			EXEC SP_DROPUSER @USERNAME;
			EXEC SP_DROPLOGIN @LGNAME;
		END
END
GO
/****** Object:  StoredProcedure [dbo].[frmNhanVien_trungCMND]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[frmNhanVien_trungCMND]
@CMND nchar(10)
as
if exists(select CMND from NhanVien where CMND=@CMND)
begin
	select CMND from NhanVien where CMND=@CMND
end
else
if exists(select CMND from LINK1.NGANHANG.DBO.NhanVien where CMND=@CMND)
begin
select CMND from LINK1.NGANHANG.DBO.NhanVien where CMND=@CMND
end
GO
/****** Object:  StoredProcedure [dbo].[frmNhanVien_trunglapMANV]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[frmNhanVien_trunglapMANV] @MANV NVARCHAR (50)
AS
IF  EXISTS(SELECT MANV FROM NhanVien WHERE MANV =@MANV)
BEGIN
	SELECT MANV FROM NhanVien WHERE MANV = @MANV
END
IF  EXISTS(SELECT MANV FROM LINK1.NGANHANG.DBO.NhanVien WHERE MANV =@MANV)
BEGIN
SELECT MANV FROM LINK1.NGANHANG.DBO.NhanVien WHERE MANV = @MANV
END
GO
/****** Object:  StoredProcedure [dbo].[frmTaoLogin_LayTKLG]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[frmTaoLogin_LayTKLG]
as
SELECT sysS_P.name as 'Tai khoan', sysusers.name as 'Ma nhan vien',HO+' '+TEN as HOTEN,Nhom
FROM sys.server_principals AS sysS_P
LEFT JOIN sys.sysusers AS sysusers on sysS_P.sid=sysusers.sid
left join NhanVien on MANV=sysusers.name
left join (SELECT 
			r.name AS 'Nhom',
			u.name AS 'Ma nhan vien'
			FROM sys.database_role_members rm
			JOIN sys.database_principals r ON rm.role_principal_id = r.principal_id
			JOIN sys.database_principals u ON rm.member_principal_id = u.principal_id
			WHERE r.type_desc = 'DATABASE_ROLE' AND r.is_fixed_role = 0) as sysRoles on sysRoles.[Ma nhan vien]=NhanVien.MANV
WHERE type_desc = 'SQL_LOGIN' and sysS_P.name<>'sa' and sysS_P.name<>'HTKN' AND sysS_P.name NOT LIKE '##%'AND sysusers.name LIKE '%NV%'; 
GO
/****** Object:  StoredProcedure [dbo].[frmTaoLogin_LayTKLGKH]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[frmTaoLogin_LayTKLGKH]
as
SELECT sysS_P.name as 'Tai khoan', sysusers.name as 'CMND',HO+' '+TEN as HOTEN,Nhom
FROM sys.server_principals AS sysS_P
LEFT JOIN sys.sysusers AS sysusers on sysS_P.sid=sysusers.sid
left join KhachHang on CMND=sysusers.name
left join (SELECT 
			r.name AS 'Nhom',
			u.name AS 'CMND'
			FROM sys.database_role_members rm
			JOIN sys.database_principals r ON rm.role_principal_id = r.principal_id
			JOIN sys.database_principals u ON rm.member_principal_id = u.principal_id
			WHERE r.type_desc = 'DATABASE_ROLE' AND r.is_fixed_role = 0) as sysRoles on sysRoles.[CMND]=KhachHang.CMND
WHERE type_desc = 'SQL_LOGIN' and sysS_P.name<>'sa' and sysS_P.name<>'HTKN' AND sysS_P.name NOT LIKE '##%'AND sysusers.name NOT LIKE '%NV%' ;
GO
/****** Object:  StoredProcedure [dbo].[frmTaoTKKH_layTTKH]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[frmTaoTKKH_layTTKH]
@CMND nchar(10)
as
if EXISTS (select CMND, HO,TEN from DBO.KHACHHANG where CMND=@CMND)
	begin
	select CMND, HO +' '+TEN AS HOTEN, MACN from DBO.KHACHHANG where CMND=@CMND
	end
else if EXISTS (select CMND, HO,TEN from LINK2.NGANHANG.DBO.KHACHHANG where CMND=@CMND)
	begin
	select CMND, HO +' '+TEN AS HOTEN, MACN from LINK2.NGANHANG.DBO.KHACHHANG where CMND=@CMND
	end
else RAISERROR(N'KHÔNG TỒN TẠI KHÁCH HÀNG VỚI SỐ CMND NÀY', 16, 1);
GO
/****** Object:  StoredProcedure [dbo].[frmTaoTKKH_TaoTK]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[frmTaoTKKH_TaoTK]
@SOTK nchar(9),@CMND nchar(10),@SODU money,@MACN nchar(10),@NGAYMOTK datetime
AS
BEGIN
		IF NOT EXISTS(SELECT CMND FROM KhachHang WHERE CMND=@CMND)
				BEGIN 
					
					INSERT INTO LINK0.NGANHANG.dbo.TaiKhoan (SOTK , CMND , SODU , MACN , NGAYMOTK)
					VALUES (@SOTK , @CMND , @SODU , @MACN ,@NGAYMOTK)
				END
			ELSE
				BEGIN
					INSERT INTO TaiKhoan (SOTK , CMND , SODU , MACN , NGAYMOTK)
					VALUES (@SOTK , @CMND , @SODU , @MACN ,@NGAYMOTK)
				END
		
END
GO
/****** Object:  StoredProcedure [dbo].[frmThongKe_LietKeKH]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[frmThongKe_LietKeKH]

as
begin
	SELECT * from KhachHang ORDER BY Ten, Ho
end
GO
/****** Object:  StoredProcedure [dbo].[frmThongKe_LietKeTK]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[frmThongKe_LietKeTK] 
    @MACN nchar(10),
    @tungay date,
    @denngay date
AS
BEGIN
    DECLARE @adjusted_denngay DATETIME;
    SET @adjusted_denngay = DATEADD(day, 1, @denngay);
    SET @adjusted_denngay = DATEADD(second, -1, @adjusted_denngay);

    DECLARE @KetQua TABLE (
        [SOTK] NCHAR(9),
        [CMND] NCHAR(10),
        [SODU] MONEY,
        [MACN] NCHAR(10),
        [NGAYMOTK] DATETIME
    );

    INSERT INTO @KetQua
    SELECT [SOTK], [CMND], [SODU], [MACN], [NGAYMOTK] 
    FROM TaiKhoan 
    WHERE NGAYMOTK >= @tungay 
    AND NGAYMOTK <= @adjusted_denngay
    UNION
    SELECT [SOTK], [CMND], [SODU], [MACN], [NGAYMOTK] 
    FROM LINK1.NGANHANG.DBO.TAIKHOAN 
    WHERE NGAYMOTK >= @tungay 
    AND NGAYMOTK <= @adjusted_denngay;

    IF(@MACN = 'TANDINH')
    BEGIN
        SELECT [SOTK], [CMND], [SODU], [MACN], [NGAYMOTK] 
        FROM @KetQua
        WHERE MACN = @MACN
		ORDER BY NGAYMOTK;
    END
    ELSE IF(@MACN = 'BENTHANH')
    BEGIN
        SELECT [SOTK], [CMND], [SODU], [MACN], [NGAYMOTK] 
        FROM @KetQua
        WHERE MACN = @MACN
		ORDER BY NGAYMOTK;
    END
    ELSE
    BEGIN
        SELECT [SOTK], [CMND], [SODU], [MACN], [NGAYMOTK] 
        FROM @KetQua
		ORDER BY NGAYMOTK;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[frmThongKe_SaoKeGD]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[frmThongKe_SaoKeGD]
@SoTK nchar(9),@tungay date,@denngay date
as
begin
DECLARE @tmp MONEY, @loaigd NCHAR(2), @ngaygd DATETIME;

DECLARE @Sodusau MONEY = (SELECT SODU FROM TaiKhoan WHERE SOTK = @SoTK);

DECLARE @Sodudau MONEY = @Sodusau;

DECLARE @SaoKe TABLE (
    [So du dau] MONEY,
    [Ngay] DATE,
    [Loai giao dich] NCHAR(2),
    [So tien] MONEY,
    [So du sau] MONEY
);

DECLARE @bang TABLE (
    [ngay gd] DATETIME,
    [so tien] MONEY,
    [loai gd] NCHAR(2)
);

INSERT INTO @bang
SELECT NGAYGD, SOTIEN, LOAIGD 
FROM GD_GOIRUT 
WHERE NGAYGD >= CAST(@tungay AS DATETIME) AND SOTK = @SoTK;

INSERT INTO @bang
SELECT NGAYGD, SOTIEN, 'CT' AS loaigd 
FROM GD_CHUYENTIEN 
WHERE NGAYGD >= CAST(@tungay AS DATETIME) AND SOTK_CHUYEN = @SoTK;

INSERT INTO @bang
SELECT NGAYGD, SOTIEN, 'NT' AS loaigd 
FROM GD_CHUYENTIEN 
WHERE NGAYGD >= CAST(@tungay AS DATETIME) AND SOTK_NHAN = @SoTK;

WHILE EXISTS (SELECT TOP 1 1 FROM @bang)
BEGIN
    SELECT TOP 1 @tmp = [so tien], @loaigd = [loai gd], @ngaygd = [ngay gd] 
    FROM @bang 
    ORDER BY [ngay gd] DESC;

    IF @loaigd = 'GT'
    BEGIN
        SET @Sodusau = @Sodudau;
        SET @Sodudau = @Sodusau - @tmp;

        INSERT INTO @SaoKe
        SELECT @Sodudau, CAST(@ngaygd AS DATE), @loaigd, ABS(@Sodudau - @Sodusau), @Sodusau;
    END
	ELSE IF @loaigd = 'RT'
    BEGIN
        SET @Sodusau = @Sodudau;
        SET @Sodudau = @Sodusau + @tmp;

        INSERT INTO @SaoKe
        SELECT @Sodudau, CAST(@ngaygd AS DATE), @loaigd, ABS(@Sodudau - @Sodusau), @Sodusau;
    END
	ELSE IF @loaigd = 'CT'
    BEGIN
        SET @Sodusau = @Sodudau;
        SET @Sodudau = @Sodusau + @tmp;

        INSERT INTO @SaoKe
        SELECT @Sodudau, CAST(@ngaygd AS DATE), @loaigd, ABS(@Sodudau - @Sodusau), @Sodusau;
    END
	ELSE IF @loaigd = 'NT'
    BEGIN
        SET @Sodusau = @Sodudau;
        SET @Sodudau = @Sodusau - @tmp;

        INSERT INTO @SaoKe
        SELECT @Sodudau, CAST(@ngaygd AS DATE), @loaigd, ABS(@Sodudau - @Sodusau), @Sodusau;
    END

    DELETE TOP (1) FROM @bang
    WHERE [ngay gd] = @ngaygd AND [so tien] = @tmp AND [loai gd] = @loaigd;
END

SELECT *
FROM (
    SELECT *, ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS rn
    FROM @SaoKe where [Ngay]<=@denngay
) AS sub
ORDER BY rn DESC;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_LayThongTinNhanVien]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_LayThongTinNhanVien]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50), @UID INT
SELECT @UID= UID, @TENUSER=NAME FROM sys.sysusers 
     WHERE sid = SUSER_SID(@TENLOGIN)
 IF exists(SELECT HO+ ' '+ TEN FROM NHANVIEN  WHERE MANV = @TENUSER)
	BEGIN
	 SELECT MANV = @TENUSER, 
	  HOTEN = (SELECT HO+ ' '+ TEN FROM NHANVIEN  WHERE MANV = @TENUSER ),
	   TENNHOM= NAME
	   FROM sys.sysusers 
	   WHERE UID = (SELECT GROUPUID 
					 FROM SYS.SYSMEMBERS 
					   WHERE MEMBERUID= @UID)
	END
	ELSE
	BEGIN
		SELECT CMND = @TENUSER, 
		HOTEN = (SELECT HO+ ' '+ TEN FROM KhachHang  WHERE CMND = @TENUSER ),
	   TENNHOM= NAME
	   FROM sys.sysusers 
	   WHERE UID = (SELECT GROUPUID 
					 FROM SYS.SYSMEMBERS 
					   WHERE MEMBERUID= @UID)
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOTAIKHOAN]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOTAIKHOAN]
  @LGNAME VARCHAR(50),  @PASS VARCHAR(50),    @USERNAME VARCHAR(50),  @ROLE VARCHAR(50)   
AS
begin
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS, 'NGANHANG'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
  BEGIN
     RAISERROR ('Login name bị trùng', 16,1)
	 RETURN
  END 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RAISERROR ('Nhân viên đã có login name', 16,2)
       RETURN
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE<>'KhachHang'
      EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
 End
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOTAIKHOANKH]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_TAOTAIKHOANKH]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50)
AS
BEGIN
  DECLARE @RET INT
  
  EXEC @RET = SP_ADDLOGIN @LGNAME, @PASS, 'NGANHANG'
  IF (@RET <> 0)
  BEGIN
     RETURN;
  END
  
  EXEC @RET = SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET <> 0)
  BEGIN
     EXEC SP_DROPLOGIN @LGNAME;
     RETURN; 
  END
  
  EXEC sp_addrolemember 'KHACHHANG', @USERNAME
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TimNV]    Script Date: 25/06/2024 4:50:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_TimNV]
  @X NCHAR(10)
AS
 DECLARE @MACN VARCHAR(10), @HO nvarchar(50), @TEN nvarchar(10)
 IF  exists(select MANV from  dbo.NHANVIEN  where MANV =@X)
 BEGIN
   	SELECT TENCN= (SELECT TENCN FROM dbo.CHINHANH),  HO, TEN 
   	FROM NHANVIEN WHERE MANV=@X
 END
 ELSE
  IF  exists(select MANV from  LINK0.NGANHANG.dbo.NHANVIEN  where MANV =@X)
  BEGIN
    SELECT  @MACN= MACN,  @HO=HO, @TEN=TEN 
   	    FROM LINK0.NGANHANG.dbo.NHANVIEN WHERE MANV=@X
   	SELECT  TENCN=TENCN,  HO=@HO, TEN =@TEN
   	 FROM LINK0.NGANHANG.dbo.CHINHANH  WHERE MACN=@MACN
   	                  
  END
  ELSE  -- không có nv
     raiserror ( 'Ma nhan vien ban tim khong co', 16, 1)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'‘GT’ : gởi tiền vào TK , ‘RT’ : rút tiền khỏi TK' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'GD_GOIRUT', @level2type=N'COLUMN',@level2name=N'LOAIGD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -120
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PUBS"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 380
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SUBS"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 346
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_DS_PHANMANH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_DS_PHANMANH'
GO
USE [master]
GO
ALTER DATABASE [NGANHANG] SET  READ_WRITE 
GO
