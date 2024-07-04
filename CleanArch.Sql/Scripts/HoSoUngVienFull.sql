USE [HoSoUngVien]
GO
/****** Object:  Table [dbo].[Contact] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](200) NULL,
	[LastName] [nvarchar](200) NULL,
	[Email] [nvarchar](100) NULL,
	[PhoneNumber] [nvarchar](100) NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[QuocGia](
    [QuocGiaId] [int] IDENTITY(1,1) NOT NULL,
    [TenQuocGia] [nvarchar](max) NULL,
    [Note] [nvarchar](max) NULL,
    CONSTRAINT [PK_QuocGia] PRIMARY KEY CLUSTERED 
    (
        [QuocGiaId] ASC
    )
    WITH (
        PAD_INDEX = OFF,
        STATISTICS_NORECOMPUTE = OFF,
        IGNORE_DUP_KEY = OFF,
        ALLOW_ROW_LOCKS = ON,
        ALLOW_PAGE_LOCKS = ON
    )
    ON [PRIMARY]
);
CREATE TABLE [dbo].[Tinh](
    [TinhId] [int] IDENTITY(1,1) NOT NULL,
    [TenTinh] [nvarchar](max) NULL,
    [QuocGiaId] [int] NOT NULL,
    [Note] [nvarchar](max) NULL,
    CONSTRAINT [PK_Tinh] PRIMARY KEY CLUSTERED 
    (
        [TinhId] ASC
    )
    WITH (
        PAD_INDEX = OFF,
        STATISTICS_NORECOMPUTE = OFF,
        IGNORE_DUP_KEY = OFF,
        ALLOW_ROW_LOCKS = ON,
        ALLOW_PAGE_LOCKS = ON
    )
    ON [PRIMARY],
    CONSTRAINT [FK_Tinh_QuocGia] FOREIGN KEY ([QuocGiaId])
    REFERENCES [dbo].[QuocGia] ([QuocGiaId])
);
CREATE TABLE [dbo].[Huyen](
    [HuyenId] [int] IDENTITY(1,1) NOT NULL,
    [TenHuyen] [nvarchar](max) NULL,
    [TinhId] [int] NOT NULL,
    [Note] [nvarchar](max) NULL,
    CONSTRAINT [PK_Huyen] PRIMARY KEY CLUSTERED 
    (
        [HuyenId] ASC
    )
    WITH (
        PAD_INDEX = OFF,
        STATISTICS_NORECOMPUTE = OFF,
        IGNORE_DUP_KEY = OFF,
        ALLOW_ROW_LOCKS = ON,
        ALLOW_PAGE_LOCKS = ON
    )
    ON [PRIMARY],
    CONSTRAINT [FK_Huyen_Tinh] FOREIGN KEY ([TinhId])
    REFERENCES [dbo].[Tinh] ([TinhId])
);
CREATE TABLE [dbo].[Xa](
    [XaId] [int] IDENTITY(1,1) NOT NULL,
    [TenXa] [nvarchar](max) NULL,
    [HuyenId] [int] NOT NULL,
    [Note] [nvarchar](max) NULL,
    CONSTRAINT [PK_Xa] PRIMARY KEY CLUSTERED 
    (
        [XaId] ASC
    )
    WITH (
        PAD_INDEX = OFF,
        STATISTICS_NORECOMPUTE = OFF,
        IGNORE_DUP_KEY = OFF,
        ALLOW_ROW_LOCKS = ON,
        ALLOW_PAGE_LOCKS = ON
    )
    ON [PRIMARY],
    CONSTRAINT [FK_Xa_Huyen] FOREIGN KEY ([HuyenId])
    REFERENCES [dbo].[Huyen] ([HuyenId])
);

CREATE TABLE [dbo].[UngVien](
    [UngVienId] [int] IDENTITY(1,1) NOT NULL,
    [Ten] [nvarchar](max) NULL,
    [GioiTinh] [nvarchar](max) NULL,
    [NamSinh] [int] NOT NULL,
    [CMND] [nvarchar](max) NULL,
    [Ten] [nvarchar](max) NOT NULL,
    [GioiTinh] [nvarchar](max) NOT NULL,
    [NamSinh] [datetime] NOT NULL,
    [CMND] [nvarchar](max) NOT NULL,
    [QuocGiaId] [int] NOT NULL,
    [TinhId] [int] NOT NULL,
    [HuyenId] [int] NOT NULL,
    [XaId] [int] NOT NULL,
    CONSTRAINT [PK_UngVien] PRIMARY KEY CLUSTERED 
    (
        [UngVienId] ASC
    )
    WITH (
        PAD_INDEX = OFF,
        STATISTICS_NORECOMPUTE = OFF,
        IGNORE_DUP_KEY = OFF,
        ALLOW_ROW_LOCKS = ON,
        ALLOW_PAGE_LOCKS = ON
    )
    ON [PRIMARY]
);
--Không ràng buộc
--USE [HoSoUngVien]
--GO
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
--CREATE TABLE [dbo].[Contact](
--	[ContactId] [int] IDENTITY(1,1) NOT NULL,
--	[FirstName] [nvarchar](200) NULL,
--	[LastName] [nvarchar](200) NULL,
--	[Email] [nvarchar](100) NULL,
--	[PhoneNumber] [nvarchar](100) NULL,
-- CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
--(
--	[ContactId] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
--GO
--CREATE TABLE [dbo].[QuocGia](
--    [QuocGiaId] [int] IDENTITY(1,1) NOT NULL,
--    [TenQuocGia] [nvarchar](max) NULL,
--    [Note] [nvarchar](max) NULL,
--    CONSTRAINT [PK_QuocGia] PRIMARY KEY CLUSTERED 
--    (
--        [QuocGiaId] ASC
--    )
--    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
--GO
--CREATE TABLE [dbo].[Tinh](
--    [TinhId] [int] IDENTITY(1,1) NOT NULL,
--    [TenTinh] [nvarchar](max) NULL,
--    [QuocGiaId] [int] NULL,
--    [Note] [nvarchar](max) NULL,
--    CONSTRAINT [PK_Tinh] PRIMARY KEY CLUSTERED 
--    (
--        [TinhId] ASC
--    )
--    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
--GO
--CREATE TABLE [dbo].[Huyen](
--    [HuyenId] [int] IDENTITY(1,1) NOT NULL,
--    [TenHuyen] [nvarchar](max) NULL,
--    [TinhId] [int] NULL,
--    [Note] [nvarchar](max) NULL,
--    CONSTRAINT [PK_Huyen] PRIMARY KEY CLUSTERED 
--    (
--        [HuyenId] ASC
--    )
--    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
--GO
--CREATE TABLE [dbo].[Xa](
--    [XaId] [int] IDENTITY(1,1) NOT NULL,
--    [TenXa] [nvarchar](max) NULL,
--    [HuyenId] [int] NULL,
--    [Note] [nvarchar](max) NULL,
--    CONSTRAINT [PK_Xa] PRIMARY KEY CLUSTERED 
--    (
--        [XaId] ASC
--    )
--   WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
--GO

--CREATE TABLE [dbo].[UngVien](
--    [UngVienId] [int] IDENTITY(1,1) NOT NULL,
--    [Ten] [nvarchar](max) NULL,
--    [GioiTinh] [nvarchar](max) NULL,
--    [NamSinh] [int] NOT NULL,
--    [CMND] [nvarchar](max) NULL,
--    [Ten] [nvarchar](max) NOT NULL,
--    [GioiTinh] [nvarchar](max) NOT NULL,
--    [NamSinh] [datetime] NOT NULL,
--    [CMND] [nvarchar](max) NOT NULL,
--    [QuocGiaId] [int] NOT NULL,
--    [TinhId] [int] NOT NULL,
--    [HuyenId] [int] NOT NULL,
--    [XaId] [int] NOT NULL,
--    CONSTRAINT [PK_UngVien] PRIMARY KEY CLUSTERED 
--    (
--        [UngVienId] ASC
--    )
--   WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
--GO
