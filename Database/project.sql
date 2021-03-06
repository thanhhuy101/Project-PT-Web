USE [master]
GO
/****** Object:  Database [WebsiteBanDoAn]    Script Date: 6/27/2022 12:50:22 PM ******/
CREATE DATABASE [WebsiteBanDoAn]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WebsiteBanDoAn', FILENAME = N'D:\N3CN22\Web\PTWeb\Project\WebsiteBanDoAn.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WebsiteBanDoAn_log', FILENAME = N'D:\N3CN22\Web\PTWeb\Project\WebsiteBanDoAn_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WebsiteBanDoAn] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WebsiteBanDoAn].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WebsiteBanDoAn] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET ARITHABORT OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WebsiteBanDoAn] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WebsiteBanDoAn] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WebsiteBanDoAn] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WebsiteBanDoAn] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET RECOVERY FULL 
GO
ALTER DATABASE [WebsiteBanDoAn] SET  MULTI_USER 
GO
ALTER DATABASE [WebsiteBanDoAn] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WebsiteBanDoAn] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WebsiteBanDoAn] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WebsiteBanDoAn] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WebsiteBanDoAn] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WebsiteBanDoAn] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'WebsiteBanDoAn', N'ON'
GO
ALTER DATABASE [WebsiteBanDoAn] SET QUERY_STORE = OFF
GO
USE [WebsiteBanDoAn]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 6/27/2022 12:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[MoTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chi tiet hoa don]    Script Date: 6/27/2022 12:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chi tiet hoa don](
	[MaCT] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [int] NULL,
	[MaSP] [int] NULL,
	[SoLuong] [int] NULL,
	[Gia] [money] NULL,
 CONSTRAINT [PK_Chi tiet hoa don] PRIMARY KEY CLUSTERED 
(
	[MaCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 6/27/2022 12:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[subject] [nvarchar](50) NULL,
	[contents] [nvarchar](max) NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhGia]    Script Date: 6/27/2022 12:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhGia](
	[MaRV] [int] IDENTITY(1,1) NOT NULL,
	[MaSP] [int] NULL,
	[MaKH] [int] NULL,
	[NgayReview] [date] NULL,
	[NDReview] [nvarchar](max) NULL,
	[Writing] [nvarchar](max) NULL,
 CONSTRAINT [PK_DanhGia] PRIMARY KEY CLUSTERED 
(
	[MaRV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GioHang]    Script Date: 6/27/2022 12:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioHang](
	[MaGH] [int] IDENTITY(1,1) NOT NULL,
	[MaSP] [int] NULL,
	[TenSP] [nvarchar](50) NULL,
	[GiaSP] [money] NULL,
	[SoLuong] [int] NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_GioHang] PRIMARY KEY CLUSTERED 
(
	[MaGH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/27/2022 12:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaSP] [int] NULL,
	[MaAd] [int] NULL,
	[TenKH] [nvarchar](50) NULL,
	[TenSP] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[DiaChi] [nvarchar](max) NULL,
	[GiaSP] [money] NULL,
	[NgayLap] [date] NULL,
	[TongSoLuong] [int] NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 6/27/2022 12:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[MaLoai] [int] NULL,
	[TenSP] [nvarchar](50) NULL,
	[HinhAnh] [nvarchar](50) NULL,
	[GiaSP] [money] NULL,
	[MoTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_MonAn] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/27/2022 12:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaAd] [int] IDENTITY(1,1) NOT NULL,
	[TenAd] [nvarchar](50) NULL,
	[TenTK] [nvarchar](50) NULL,
	[Matkhau] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaAd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 6/27/2022 12:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[Matkhau] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([MaLoai], [TenLoai], [MoTa]) VALUES (1, N'DoAn', N'very good')
INSERT [dbo].[Category] ([MaLoai], [TenLoai], [MoTa]) VALUES (2, N'DoUong', N'healthy')
INSERT [dbo].[Category] ([MaLoai], [TenLoai], [MoTa]) VALUES (3, N'FastFood', N'balance')
INSERT [dbo].[Category] ([MaLoai], [TenLoai], [MoTa]) VALUES (4, N'Breakfast', N'healthy')
INSERT [dbo].[Category] ([MaLoai], [TenLoai], [MoTa]) VALUES (5, N'Eat fast', N'healthy')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Chi tiet hoa don] ON 

INSERT [dbo].[Chi tiet hoa don] ([MaCT], [MaHD], [MaSP], [SoLuong], [Gia]) VALUES (1, 1, 1, 5, 30.0000)
INSERT [dbo].[Chi tiet hoa don] ([MaCT], [MaHD], [MaSP], [SoLuong], [Gia]) VALUES (2, 2, 2, 2, 50.0000)
INSERT [dbo].[Chi tiet hoa don] ([MaCT], [MaHD], [MaSP], [SoLuong], [Gia]) VALUES (3, 3, 3, 3, 99.0000)
INSERT [dbo].[Chi tiet hoa don] ([MaCT], [MaHD], [MaSP], [SoLuong], [Gia]) VALUES (5, 4, 17, 4, 120.0000)
INSERT [dbo].[Chi tiet hoa don] ([MaCT], [MaHD], [MaSP], [SoLuong], [Gia]) VALUES (6, 5, 18, 5, 80.0000)
SET IDENTITY_INSERT [dbo].[Chi tiet hoa don] OFF
GO
SET IDENTITY_INSERT [dbo].[Contact] ON 

INSERT [dbo].[Contact] ([Id], [Name], [Sdt], [email], [subject], [contents]) VALUES (1, N'thien', N'123', N'12ff3@gmail.com', N'Hoi tham', N'fsafsd')
INSERT [dbo].[Contact] ([Id], [Name], [Sdt], [email], [subject], [contents]) VALUES (2, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Sdt], [email], [subject], [contents]) VALUES (3, N'thanh huy', N'1234567812', N'12ff33@gmail.com', N'Hoi tham', N'vui choi đa')
SET IDENTITY_INSERT [dbo].[Contact] OFF
GO
SET IDENTITY_INSERT [dbo].[DanhGia] ON 

INSERT [dbo].[DanhGia] ([MaRV], [MaSP], [MaKH], [NgayReview], [NDReview], [Writing]) VALUES (1, 1, 1, CAST(N'2022-05-15' AS Date), N'Bò kho', N'Thơm ngon, bổ dưỡng')
INSERT [dbo].[DanhGia] ([MaRV], [MaSP], [MaKH], [NgayReview], [NDReview], [Writing]) VALUES (2, 2, 2, CAST(N'2022-05-13' AS Date), N'Hủ tiếu', N'Mềm ngon quá đã')
INSERT [dbo].[DanhGia] ([MaRV], [MaSP], [MaKH], [NgayReview], [NDReview], [Writing]) VALUES (3, 3, 3, CAST(N'2022-04-02' AS Date), N'Mì ý', N'Thơm ngon, bổ dưỡng')
INSERT [dbo].[DanhGia] ([MaRV], [MaSP], [MaKH], [NgayReview], [NDReview], [Writing]) VALUES (5, 17, 4, CAST(N'2023-01-01' AS Date), N'Bò bít tết', N'Mềm ngon quá đã')
INSERT [dbo].[DanhGia] ([MaRV], [MaSP], [MaKH], [NgayReview], [NDReview], [Writing]) VALUES (6, 18, 5, CAST(N'2023-04-08' AS Date), N'Cơm tấm', N'Thơm ngon, bổ dưỡng')
SET IDENTITY_INSERT [dbo].[DanhGia] OFF
GO
SET IDENTITY_INSERT [dbo].[GioHang] ON 

INSERT [dbo].[GioHang] ([MaGH], [MaSP], [TenSP], [GiaSP], [SoLuong], [TongTien]) VALUES (1, 1, N'Bòkho', 100000.0000, 5, 150.0000)
INSERT [dbo].[GioHang] ([MaGH], [MaSP], [TenSP], [GiaSP], [SoLuong], [TongTien]) VALUES (2, 2, N'Hủ tiếu', 40000.0000, 2, 100.0000)
INSERT [dbo].[GioHang] ([MaGH], [MaSP], [TenSP], [GiaSP], [SoLuong], [TongTien]) VALUES (3, 3, N'Cơm tấm', 30000.0000, 3, 297.0000)
INSERT [dbo].[GioHang] ([MaGH], [MaSP], [TenSP], [GiaSP], [SoLuong], [TongTien]) VALUES (9, 17, N'Mì ý', 500000.0000, 4, 480.0000)
INSERT [dbo].[GioHang] ([MaGH], [MaSP], [TenSP], [GiaSP], [SoLuong], [TongTien]) VALUES (10, 18, N'Bò bít tết', 888888.0000, 5, 300.0000)
INSERT [dbo].[GioHang] ([MaGH], [MaSP], [TenSP], [GiaSP], [SoLuong], [TongTien]) VALUES (11, 19, N'Phở', 222222.0000, 2, 222222.0000)
INSERT [dbo].[GioHang] ([MaGH], [MaSP], [TenSP], [GiaSP], [SoLuong], [TongTien]) VALUES (12, 20, N'Bánh canh', 992234.0000, 3, 992234.0000)
SET IDENTITY_INSERT [dbo].[GioHang] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHD], [MaSP], [MaAd], [TenKH], [TenSP], [SDT], [DiaChi], [GiaSP], [NgayLap], [TongSoLuong], [TongTien]) VALUES (1, 1, 1, N'Bùi Thanh Huy', N'Bò kho', NULL, N'813/5/7 VietNam,P.5.Q.TB', 100000.0000, CAST(N'2022-10-04' AS Date), 1, 100000.0000)
INSERT [dbo].[HoaDon] ([MaHD], [MaSP], [MaAd], [TenKH], [TenSP], [SDT], [DiaChi], [GiaSP], [NgayLap], [TongSoLuong], [TongTien]) VALUES (2, 2, 2, N'Hồ Văn Hiền', N'Cơm tấm', NULL, N'294/22 Bình Tiên p8 q6', 20000.0000, CAST(N'2002-04-28' AS Date), 2, 20000.0000)
INSERT [dbo].[HoaDon] ([MaHD], [MaSP], [MaAd], [TenKH], [TenSP], [SDT], [DiaChi], [GiaSP], [NgayLap], [TongSoLuong], [TongTien]) VALUES (3, 3, 3, N'Đỗ Mạnh Cường', N'Mì ý', NULL, N'123/5/1 Campuchia,P.15.Q.13', 31111.0000, CAST(N'2111-11-11' AS Date), 3, 311555.0000)
INSERT [dbo].[HoaDon] ([MaHD], [MaSP], [MaAd], [TenKH], [TenSP], [SDT], [DiaChi], [GiaSP], [NgayLap], [TongSoLuong], [TongTien]) VALUES (4, 4, 4, N'Nguyễn Văn A', N'Hủ tiếu', NULL, N'813/5/7 VietNam,P.5.Q.TB', 211.0000, CAST(N'2022-01-04' AS Date), 4, 255.0000)
INSERT [dbo].[HoaDon] ([MaHD], [MaSP], [MaAd], [TenKH], [TenSP], [SDT], [DiaChi], [GiaSP], [NgayLap], [TongSoLuong], [TongTien]) VALUES (5, 5, 5, N'Nguyễn Văn B', N'Cơm sườn', NULL, N'123/5/1 Campuchia,P.15.Q.13', 555555.0000, CAST(N'2021-04-02' AS Date), 5, 666666.0000)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[MonAn] ON 

INSERT [dbo].[MonAn] ([MaSP], [MaLoai], [TenSP], [HinhAnh], [GiaSP], [MoTa]) VALUES (1, 1, N'Bò kho', N'sp7.jpg', 100000.0000, N'Bò kho bánh mì là một món ăn ngon, quen thuộc, mỗi khi nhắc đến hầu như ai cũng sẽ hình dung ngay đến một món ăn đậm đà với màu cam nâu bắt mắt cùng với thịt thăn bò được ninh nhừ, thấm vị, có độ béo của mỡ và giòn ngon của gân.')
INSERT [dbo].[MonAn] ([MaSP], [MaLoai], [TenSP], [HinhAnh], [GiaSP], [MoTa]) VALUES (2, 5, N'Hủ tiếu', N'sp8.jpg', 40000.0000, N'Hủ tiếu Nam Vang là 1 trong những món hủ tiếu Sài Gòn được du nhập từ Campuchia. Tuy nhiên, khi về đến Sài Gòn, món ăn này được chế biến lại sao cho phù hợp với khẩu vị của người dân địa phương. Nồi nước dùng được nấu công phu, trong veo, mang vị thanh ngọt đặc trưng, thu hút nhiều du khách khi đến du lịch Sài Gòn. ')
INSERT [dbo].[MonAn] ([MaSP], [MaLoai], [TenSP], [HinhAnh], [GiaSP], [MoTa]) VALUES (3, 4, N'Cơm tấm', N'sp2.jpg', 30000.0000, N'Cơm tấm là món ăn đặc sản của người dân miền Nam. Nó được ưa chuộng tại rất nhiều vùng miền, đặc biệt là Sài Gòn. Hiện nay, món cơm tấm đã có mặt trên khắp các tỉnh thành của đất nước và cả nước ngoài. Cơm tấm được làm từ hạt tấm, trứng ốp la, chả trứng, lạp xưởng. Cơm tấm thường được sử dụng cho bữa sáng nhưng đôi khi người ta cũng thưởng thức nó vào buổi trưa hoặc buổi tối. ')
INSERT [dbo].[MonAn] ([MaSP], [MaLoai], [TenSP], [HinhAnh], [GiaSP], [MoTa]) VALUES (17, 3, N'Mì ý', N'sp6.jpg', 500000.0000, N'Mì Ý (hay Spaghetti) thường được biết đến với danh hiệu là món ăn “quốc hồn quốc túy” của đất nước Ý - nơi cả con người lẫn ẩm thực đều quyến rũ theo một nét riêng của mình. Tuy nhiên, không nhiều người biết rằng, cách làm mì Ý ngày nay lại được bắt nguồn từ vùng đất xa xôi của những người Ả Rập.')
INSERT [dbo].[MonAn] ([MaSP], [MaLoai], [TenSP], [HinhAnh], [GiaSP], [MoTa]) VALUES (18, 2, N'Bò bít tết', N'sp3.jpg', 888888.0000, N'Bò bít tết (beefsteak) là một món ăn đã quá phổ biến trong ẩm thực châu Âu. Chế biến bít tết theo phong cách Việt thì đơn giản hơn rất nhiều. Bạn cũng không cần phải có lò nướng hay phải là người nấu nướng quá giỏi vẫn có thể thực hiện món ăn này. Chắc chắn, vị mềm mềm có một chút dai, thấm gia vị đậm đà của thịt bò cùng miếng khoai tây nóng hổi, mềm giòn sẽ khiến bạn thích thú.')
INSERT [dbo].[MonAn] ([MaSP], [MaLoai], [TenSP], [HinhAnh], [GiaSP], [MoTa]) VALUES (19, 1, N'Phở', N'sp9.jpg', 222222.0000, N'Việt Nam là một quốc gia có nền ẩm thực độc đáo đa dạng. Mỗi vùng quê trên đất nước đều có đặc sản của quê mình. Nếu như Huế nổi tiếng với mè xửng, cơm hến, Quảng Nam nổi tiếng với mì Quảng, Nghệ An có cháo Lươn thì Hà Nội có phở,…Phở từ lâu đã được biết đến như một món ăn thân thuộc, gần gũi và phổ biến nhất của người dân đất Bắc.')
INSERT [dbo].[MonAn] ([MaSP], [MaLoai], [TenSP], [HinhAnh], [GiaSP], [MoTa]) VALUES (20, 4, N'Bánh canh', N'sp10.jpg', 992234.0000, N'Bánh canh là một món ăn độc đáo với nhiều “phiên bản”, thể hiện nét đẹp văn hóa của các vùng miền. Sợi bánh canh mềm dai, nước dùng đậm đà từ xương hầm và rau củ đã tạo nên sức hấp dẫn của món ăn này.')
INSERT [dbo].[MonAn] ([MaSP], [MaLoai], [TenSP], [HinhAnh], [GiaSP], [MoTa]) VALUES (22, 1, N'hy', N'bò kho.png', 1000.0000, N'hehe')
SET IDENTITY_INSERT [dbo].[MonAn] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaAd], [TenAd], [TenTK], [Matkhau]) VALUES (1, N'Hồ Văn Hiền', N'HVH', N'45678')
INSERT [dbo].[NhanVien] ([MaAd], [TenAd], [TenTK], [Matkhau]) VALUES (2, N'Bùi Thanh Huy', N'BTK', N'12345')
INSERT [dbo].[NhanVien] ([MaAd], [TenAd], [TenTK], [Matkhau]) VALUES (3, N'Đỗ Mạnh Cường', N'DMC', N'12345')
INSERT [dbo].[NhanVien] ([MaAd], [TenAd], [TenTK], [Matkhau]) VALUES (4, N'Nguyễn Văn A', N'NVA', N'78965')
INSERT [dbo].[NhanVien] ([MaAd], [TenAd], [TenTK], [Matkhau]) VALUES (5, N'Nguyễn Văn B', N'NVB', N'78965')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([MaKH], [TenKH], [SDT], [GioiTinh], [DiaChi], [Matkhau]) VALUES (1, N'Hồ Văn Hiền', 12345678, N'Nam', N'813/5/7 VietNam,P.5.Q.TB', NULL)
INSERT [dbo].[User] ([MaKH], [TenKH], [SDT], [GioiTinh], [DiaChi], [Matkhau]) VALUES (2, N'Bùi Thanh Huy', 123456789, N'Nam', N'123/5/1 Campuchia,P.15.Q.13', NULL)
INSERT [dbo].[User] ([MaKH], [TenKH], [SDT], [GioiTinh], [DiaChi], [Matkhau]) VALUES (3, N'Đỗ Mạnh Cường', 12345678, N'Nam', N'123/5/1 Campuchia,P.15.Q.13', NULL)
INSERT [dbo].[User] ([MaKH], [TenKH], [SDT], [GioiTinh], [DiaChi], [Matkhau]) VALUES (4, N'Nguyễn Văn A', 123456789, N'Nam', N'813/5/7 VietNam,P.5.Q.TB', NULL)
INSERT [dbo].[User] ([MaKH], [TenKH], [SDT], [GioiTinh], [DiaChi], [Matkhau]) VALUES (5, N'Nguyễn Văn B', 12345678, N'Nữ', N'123/5/1 Campuchia,P.15.Q.13', NULL)
INSERT [dbo].[User] ([MaKH], [TenKH], [SDT], [GioiTinh], [DiaChi], [Matkhau]) VALUES (6, N'Nguyễn Văn AB', 1234567890, N'Nam', N'123/5/ Quang Trung P.7 Q.QT', N'1234')
INSERT [dbo].[User] ([MaKH], [TenKH], [SDT], [GioiTinh], [DiaChi], [Matkhau]) VALUES (7, N'Nguyễn Văn ABC', 1234567812, N'Nữ', N'123/5/ Quang Trung P.7 Q.QT', N'123')
INSERT [dbo].[User] ([MaKH], [TenKH], [SDT], [GioiTinh], [DiaChi], [Matkhau]) VALUES (8, N'Nguyễn Văn ABCD', 1234564561, N'Nam', N'123/5/ Quang Trung P.7 Q.QT', N'123')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Chi tiet hoa don]  WITH CHECK ADD  CONSTRAINT [FK_Chi tiet hoa don_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[Chi tiet hoa don] CHECK CONSTRAINT [FK_Chi tiet hoa don_HoaDon]
GO
ALTER TABLE [dbo].[Chi tiet hoa don]  WITH CHECK ADD  CONSTRAINT [FK_Chi tiet hoa don_MonAn] FOREIGN KEY([MaSP])
REFERENCES [dbo].[MonAn] ([MaSP])
GO
ALTER TABLE [dbo].[Chi tiet hoa don] CHECK CONSTRAINT [FK_Chi tiet hoa don_MonAn]
GO
ALTER TABLE [dbo].[DanhGia]  WITH CHECK ADD  CONSTRAINT [FK_DanhGia_Customer] FOREIGN KEY([MaKH])
REFERENCES [dbo].[User] ([MaKH])
GO
ALTER TABLE [dbo].[DanhGia] CHECK CONSTRAINT [FK_DanhGia_Customer]
GO
ALTER TABLE [dbo].[DanhGia]  WITH CHECK ADD  CONSTRAINT [FK_DanhGia_MonAn] FOREIGN KEY([MaSP])
REFERENCES [dbo].[MonAn] ([MaSP])
GO
ALTER TABLE [dbo].[DanhGia] CHECK CONSTRAINT [FK_DanhGia_MonAn]
GO
ALTER TABLE [dbo].[GioHang]  WITH CHECK ADD  CONSTRAINT [FK_GioHang_MonAn] FOREIGN KEY([MaSP])
REFERENCES [dbo].[MonAn] ([MaSP])
GO
ALTER TABLE [dbo].[GioHang] CHECK CONSTRAINT [FK_GioHang_MonAn]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaAd])
REFERENCES [dbo].[NhanVien] ([MaAd])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [FK_MonAn_Category] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[Category] ([MaLoai])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [FK_MonAn_Category]
GO
USE [master]
GO
ALTER DATABASE [WebsiteBanDoAn] SET  READ_WRITE 
GO
