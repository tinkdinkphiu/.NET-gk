
CREATE DATABASE CarRentalDB;
GO
USE CarRentalDB;
GO


CREATE TABLE KhachHang
(
    KhachHangID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Ten NVARCHAR(50) NOT NULL,
    SoDienThoai NVARCHAR(20) NOT NULL,
    DiaChi NVARCHAR(100),
    Email NVARCHAR(100)
)
GO

CREATE TABLE Accounts
(
    AccountID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(255) NOT NULL, 
    Role NVARCHAR(50) NOT NULL
);
GO

INSERT INTO Accounts (Username, Password, Role)
VALUES ('admin', 'admin123', 'admin');
go
INSERT INTO Accounts (Username, Password, Role)
VALUES ('employee', 'employee123', 'employee');
go

CREATE TABLE XeOto
(
    XeOtoID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    HangXe NVARCHAR(50) NOT NULL,
    Model NVARCHAR(50) NOT NULL,
    LoaiXe NVARCHAR(50) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL,
    GiaThue DECIMAL(18, 2) NOT NULL,
);
go

-- Chèn dữ liệu giả cho KhachHang
INSERT INTO KhachHang (Ten, SoDienThoai, DiaChi, Email)
VALUES
    (N'Nguyễn Văn A', '0901234567', N'123 Đường ABC, Quận 1, TP.HCM', 'nguyenvana@example.com'),
    (N'Trần Thị B', '0987654321', N'456 Đường XYZ, Quận 2, TP.HCM', 'tranthib@example.com'),
    ( N'Lê Văn C', '0912345678', N'789 Đường LMN, Quận 3, TP.HCM', 'levanc@example.com');
    GO

CREATE TABLE DonDatXe
(
    DonDatXeID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    KhachHangID INT NOT NULL, -- Thay thế KhachHangID bằng tên bảng tương ứng
    XeOtoID INT NOT NULL,
    GiaThue DECIMAL(18, 2) NOT NULL,
    NhienLieu NVARCHAR(20) NOT NULL,
    DiemDen NVARCHAR(100) NOT NULL,
    ThoiGianThue DATETIME NOT NULL,
    ThoiGianTraDk DATETIME NOT NULL,
    TinhTrangThanhToan BIT NOT null,
    Total DECIMAL(18, 2) DEFAULT 0,
    ThoiGianTra DATETIME NULL,
    FOREIGN KEY (KhachHangID) REFERENCES KhachHang (KhachHangID),
    FOREIGN KEY (XeOtoID) REFERENCES XeOto (XeOtoID)
);
GO
CREATE TABLE TinhNangXe
(
    TinhNangID INT PRIMARY KEY IDENTITY(1,1),
    TenTinhNang NVARCHAR(100) NOT NULL
);
GO

-- Bảng kết nối n:n giữa XeOto và TinhNang
CREATE TABLE DonDatXe_TinhNang
(
    DonDatXeID INT NOT NULL,
    TinhNangID INT NOT NULL,
    PRIMARY KEY (DonDatXeID, TinhNangID),
    FOREIGN KEY (DonDatXeID) REFERENCES DonDatXe (DonDatXeID),
    FOREIGN KEY (TinhNangID) REFERENCES TinhNangXe (TinhNangID)
);
go
-- Tạo dữ liệu cho các tính năng
INSERT INTO TinhNangXe (TenTinhNang) VALUES
    (N'Bản đồ'),
    (N'Camera cập lề'),
    (N'Cảm biến lốp'),
    (N'Cửa sổ trời'),
    (N'Khe cắm USB'),
    (N'Nắp thùng xe bán tải'),
    (N'Bluetooth'),
    (N'Camera hành trình'),
    (N'Cảm biến va chạm'),
    (N'Định vị GPS'),
    (N'Lốp dự phòng'),
    (N'Camera 360'),
    (N'Camera lùi'),
    (N'Cảnh báo tốc độ');
GO
-- Tạo dữ liệu ngẫu nhiên cho 100 dòng XeOto
-- Tạo dữ liệu ngẫu nhiên cho 100 dòng XeOto
DECLARE @i INT = 1;

WHILE @i <= 100
BEGIN
    -- Chọn ngẫu nhiên một hãng xe từ danh sách
    DECLARE @HangXe NVARCHAR(255);
    SELECT TOP 1 @HangXe = HangXe
    FROM (
        VALUES
            (N'Toyota'),
            (N'Chevrolet'),
            (N'Ford'),
            (N'Honda'),
            (N'Hyundai'),
            (N'Isuzu'),
            (N'Suzuki'),
            (N'Kia'),
            (N'Mitsubishi'),
            (N'Lexus'),
            (N'Mazda'),
            (N'Nissan'),
            (N'Subaru'),
            (N'Ssangyong'),
            (N'Land Rover')
    ) AS HangXeList (HangXe)
    ORDER BY NEWID();

    -- Tạo một model ngẫu nhiên
    DECLARE @Model NVARCHAR(255);
    SET @Model = 'Model' + CAST(@i AS NVARCHAR(10));

    -- Chọn ngẫu nhiên một loại xe từ danh sách
    DECLARE @LoaiXe NVARCHAR(255);
    SELECT TOP 1 @LoaiXe = LoaiXe
    FROM (
        VALUES
            (N'4 cho (Mini)'),
            (N'4 cho (Sedan)'),
            (N'4 cho (Hatchback)'),
            (N'5 cho (CUV Gam cao)'),
            (N'7 cho (SUV Gam cao)'),
            (N'7 cho (MPV Gam thap)'),
            (N'Ban tai')
    ) AS LoaiXeList (LoaiXe)
    ORDER BY NEWID();

    -- Chọn ngẫu nhiên một trạng thái
    DECLARE @TrangThai NVARCHAR(255);
    SET @TrangThai = IIF(RAND() > 0.5, N'Sẵn sàng', N'Đang cho thuê');

    -- Thêm dòng dữ liệu vào bảng XeOto
    INSERT INTO XeOto (HangXe, Model, LoaiXe, TrangThai, GiaThue)
    VALUES (@HangXe, @Model, @LoaiXe, @TrangThai, 13000);

    SET @i = @i + 1;
END;
GO

DECLARE @counter INT = 0;
DECLARE @randomDateStart DATE, @randomDateEnd DATE, @randomDateReturn DATE;
DECLARE @randomKhachHangID INT, @randomXeOtoID INT;
DECLARE @randomGiaThue DECIMAL(18, 2), @randomTotal DECIMAL(18, 2);
DECLARE @randomNhienLieu NVARCHAR(20);
DECLARE @maxKhachHangID INT, @maxXeOtoID INT;

-- Lấy số lượng tối đa của ID trong các bảng liên quan
SELECT @maxKhachHangID = MAX(KhachHangID) FROM KhachHang;
SELECT @maxXeOtoID = MAX(XeOtoID) FROM XeOto;

WHILE @counter < 100
BEGIN
    -- Tạo dữ liệu ngẫu nhiên
    SET @randomDateStart = DATEADD(DAY, (RAND() * 365), '2022-10-01');
    SET @randomDateReturn = DATEADD(DAY, (RAND() * 10), @randomDateStart);
    SET @randomDateEnd = DATEADD(DAY, (RAND() * 10), @randomDateStart); -- giả sử thời gian thuê từ 1-10 ngày
    SET @randomKhachHangID = CAST(RAND() * @maxKhachHangID AS INT) + 1;
    SET @randomXeOtoID = CAST(RAND() * @maxXeOtoID AS INT) + 1;
    SET @randomGiaThue = CAST(RAND() * 1000 + 13000 AS DECIMAL(18, 2));
    SET @randomTotal = @randomGiaThue * (DATEDIFF(DAY, @randomDateStart, @randomDateEnd) + 1);
    SET @randomNhienLieu = CASE WHEN RAND() < 0.5 THEN N'Xăng' ELSE N'Dầu' END;

    -- Thêm dữ liệu vào bảng DonDatXe
    INSERT INTO DonDatXe (KhachHangID, XeOtoID, GiaThue, NhienLieu, ThoiGianThue, TinhTrangThanhToan, Total, ThoiGianTra, ThoiGianTraDk, DiemDen)
    VALUES (@randomKhachHangID, @randomXeOtoID, @randomGiaThue, @randomNhienLieu, @randomDateStart, 1, @randomTotal, @randomDateEnd, @randomDateReturn, N'Nha Trang');

    SET @counter = @counter + 1;
END
go

DECLARE @counter INT = 0;
DECLARE @randomDateStart DATE, @randomDateEnd DATE, @randomDateReturn DATE;
DECLARE @randomKhachHangID INT, @randomXeOtoID INT;
DECLARE @randomGiaThue DECIMAL(18, 2), @randomTotal DECIMAL(18, 2);
DECLARE @randomNhienLieu NVARCHAR(20);
DECLARE @maxKhachHangID INT, @maxXeOtoID INT;

-- Lấy số lượng tối đa của ID trong các bảng liên quan
SELECT @maxKhachHangID = MAX(KhachHangID) FROM KhachHang;
SELECT @maxXeOtoID = MAX(XeOtoID) FROM XeOto;
WHILE @counter < 100
BEGIN
    -- Tạo dữ liệu ngẫu nhiên
    SET @randomDateStart = DATEADD(DAY, (RAND() * 335), '2023-01-01');
    SET @randomDateReturn = DATEADD(DAY, (RAND() * 10), @randomDateStart);
    SET @randomDateEnd = DATEADD(DAY, (RAND() * 10), @randomDateStart); -- giả sử thời gian thuê từ 1-10 ngày
    SET @randomKhachHangID = CAST(RAND() * @maxKhachHangID AS INT) + 1;
    SET @randomXeOtoID = CAST(RAND() * @maxXeOtoID AS INT) + 1;
    SET @randomGiaThue = CAST(RAND() * 1000 + 13000 AS DECIMAL(18, 2));
    SET @randomTotal = @randomGiaThue * (DATEDIFF(DAY, @randomDateStart, @randomDateEnd) + 1);
    SET @randomNhienLieu = CASE WHEN RAND() < 0.5 THEN N'Xăng' ELSE N'Dầu' END;

    -- Thêm dữ liệu vào bảng DonDatXe
    INSERT INTO DonDatXe (KhachHangID, XeOtoID, GiaThue, NhienLieu, ThoiGianThue, TinhTrangThanhToan, Total, ThoiGianTra, ThoiGianTraDk, DiemDen)
    VALUES (@randomKhachHangID, @randomXeOtoID, @randomGiaThue, @randomNhienLieu, @randomDateStart, 1, @randomTotal, @randomDateEnd, @randomDateReturn, N'Nha Trang');

    SET @counter = @counter + 1;
END
go