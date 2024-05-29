create database BTLC#
go 
use BTLC#
go 
create table linhvuchoatdong (
	malvhd varchar(10) primary key not null, 
	linhvuchoatdong nvarchar(50) not null
)

create table khachhang (
	makh varchar(30) primary key not null,
	tenkh nvarchar(50) not null,
	diachi nvarchar(100) not null,
	dienthoai varchar(15) not null,
	email varchar(50),
	malvhd varchar(10) not null,
	constraint fk_kh_lvhd foreign key (malvhd) references linhvuchoatdong(malvhd)
)

create table phongban (
	mapb varchar(10) primary key not null,
	phongban nvarchar(30) not null
)

create table chucvu (
	macv varchar(10) primary key not null,
	chucvu nvarchar(30) not null
)

create table chuyenmon (
	macm varchar(10) primary key not null,
	chuyenmon nvarchar(30) not null
)

create table trinhdo (
	matd varchar(10) primary key not null,
	trinhdo nvarchar(30) not null
)

create table nhanvien (
	manv varchar(30) primary key not null,
	tennv nvarchar(50) not null,
	gioitinh nvarchar(5) not null,
	diachi nvarchar(100) not null,
	dienthoai varchar(15) not null,
	email varchar(50),
	ngaysinh date not null,
	macm varchar(10) not null,
	constraint fk_nv_cm foreign key (macm) references chuyenmon(macm),
	matd varchar(10) not null,
	constraint fk_nv_td foreign key (matd) references trinhdo(matd),
	macv varchar(10) not null,
	constraint fk_nv_cv foreign key (macv) references chucvu(macv),
	mapb varchar(10) not null,
	constraint fk_nv_pb foreign key (mapb) references phongban(mapb)
)

create table quangcao (
	maqc varchar(30) primary key not null,
	manv varchar(30) not null,
	makh varchar(30) not null,
	ngayky date not null,
	constraint fk_qc_nv foreign key (manv) references nhanvien(manv),
	constraint fk_qc_kh foreign key (makh) references khachhang(makh)
)

create table vietbai (
	mavb varchar(30) primary key not null,
	manv varchar(30) not null,
	makh varchar(30) not null,
	ngayky date not null,
	constraint fk_vb_nv foreign key (manv) references nhanvien(manv),
	constraint fk_vb_kh foreign key (makh) references khachhang(makh)
)

create table bao (
	mabao varchar(10) primary key not null,
	tenbao nvarchar(100) not null,
	diachi nvarchar(100) not null,
	sdt varchar(15) not null,
	email varchar(50)
)

create table theloai (
	matheloai varchar(10) primary key not null,
	theloai nvarchar(30) not null
)

create table dichvu (
	madv varchar(10) primary key not null,
	dichvu nvarchar(30) not null
)

create table chitietquangcao (
	mactqc varchar(30) not null primary key,
	maqc varchar(30) not null,
	constraint fk_ctqc_qc foreign key (maqc) references quangcao(maqc) on delete cascade,
	madv varchar(10) not null,
	constraint fk_ctqc_dv foreign key (madv) references dichvu(madv),
	mabao varchar(10) not null,
	constraint fk_ctqc_bao foreign key (mabao) references bao(mabao),
	noidung nvarchar(500) not null,
	ngaybd date not null,
	ngaykt date not null,
	dongia float not null
)

create table chitietvietbai (
	mactvb varchar(30) not null primary key,
	mavb varchar(30) not null,
	constraint fk_ctvb_vb foreign key (mavb) references vietbai(mavb) on delete cascade,
	mabao varchar(10) not null,
	constraint fk_ctvb_bao foreign key (mabao) references bao(mabao),
	matheloai varchar(10) not null,
	constraint fk_ctvb_theloai foreign key (matheloai) references theloai(matheloai),
	tieude nvarchar(500) not null,
	noidung nvarchar(4000) not null,
	ngaydang date not null,
	nhuanbut float not null
)

create table banggiaqc (
	mabao varchar(10) not null,
	constraint fk_bgqc_bao foreign key (mabao) references bao(mabao),
	madv varchar(10) not null,
	constraint fk_bgqc_dv foreign key (madv) references dichvu(madv),
	dongia float not null,
	constraint pk_bgqc primary key (mabao,madv)
)

create table banggiavb (
	mabao varchar(10) not null,
	constraint fk_bgvb_bao foreign key (mabao) references bao(mabao),
	matheloai varchar(10) not null,
	constraint fk_bgvb_tl foreign key (matheloai) references theloai(matheloai),
	nhuanbut float not null,
	constraint pk_bgvb primary key (mabao,matheloai)
)

insert into phongban values ('PB01',N'Phòng Sale 1');
insert into phongban values ('PB02',N'Phòng Sale 2');
insert into phongban values ('PB03',N'Phòng Sale 3');
insert into phongban values ('PB04',N'Phòng Quản Lý')

insert into chuyenmon values ('CM01',N'Cấp bậc 1');
insert into chuyenmon values ('CM02',N'Cấp bậc 2');
insert into chuyenmon values ('CM03',N'Cấp bậc 3')

insert into trinhdo values ('TD01',N'Cử nhân');
insert into trinhdo values ('TD02',N'Tiến sĩ');
insert into trinhdo values ('TD03',N'Thạc sĩ')

insert into chucvu values ('CV01',N'Biên tập viên');
insert into chucvu values ('CV02',N'Cộng tác viên');
insert into chucvu values ('CV03',N'Chuyên viên truyền thông');
insert into chucvu values ('CV04',N'Phóng viên')

insert into bao values ('B01',N'Báo Tuổi Trẻ',N'60A Hoàng Văn Thụ, P.9, Q.Phú Nhuận, Tp. Hồ Chí Minh','0918033133','tto@tuoitre.com.vn');
insert into bao values ('B02',N'Báo VNExpress',N'Tầng 10, Tòa A FPT Tower, số 10 Phạm Văn Bạch, Dịch Vọng, Cầu Giấy, Hà Nội','0247300889','');
insert into bao values ('B03',N'Báo Người Lao Động',N'127 Võ Văn Tần, Phường Võ Thị Sáu, Quận 3 - TPHCM','0283930626','doanhnghiep@admicro.vn');
insert into bao values ('B04',N'CafeF',N'Tầng 21 Tòa nhà Center Building, Số 1 Nguyễn Huy Tưởng, Thanh Xuân, Hà Nội','0926864344','info@cafef.vn');
insert into bao values ('B05',N'Kenh14.vn',N'Tầng 21, tòa nhà Center Building, số 1 Nguyễn Huy Tưởng, Thanh Xuân Trung, Thanh Xuân, Hà Nội','0247309555','giaitrixahoi@admicro.vn');
insert into bao values ('B06',N'Báo mới',N'Tầng 16, Tòa nhà TNR Tower, số 54A Nguyễn Chí Thanh, Láng Thượng, Đống Đa, Hà Nội','0243542355','contact.baomoi@epi.com.vn');

insert into theloai values ('TL01',N'Thể thao');
insert into theloai values ('TL02',N'Kinh doanh');
insert into theloai values ('TL03',N'Bất động sản');
insert into theloai values ('TL04',N'Ngân hàng');
insert into theloai values ('TL05',N'Chứng khoán');

insert into linhvuchoatdong values ('LVHD01',N'Thể thao');
insert into linhvuchoatdong values ('LVHD02',N'Kinh doanh');
insert into linhvuchoatdong values ('LVHD03',N'Bất động sản');
insert into linhvuchoatdong values ('LVHD04',N'Ngân hàng');
insert into linhvuchoatdong values ('LVHD05',N'Chứng khoán')

insert into dichvu values ('DV01',N'Landing Page');
insert into dichvu values ('DV02',N'Banner TVC');
insert into dichvu values ('DV03',N'Native Ads')

insert into banggiaqc values ('B01','DV01',700000)
insert into banggiaqc values ('B01','DV02',1000000)
insert into banggiaqc values ('B01','DV03',800000)
insert into banggiaqc values ('B02','DV01',1000000)
insert into banggiaqc values ('B02','DV02',1500000)
insert into banggiaqc values ('B02','DV03',1200000)
insert into banggiaqc values ('B03','DV01',750000)
insert into banggiaqc values ('B03','DV02',1200000)
insert into banggiaqc values ('B03','DV03',1000000)
insert into banggiaqc values ('B04','DV01',1500000)
insert into banggiaqc values ('B04','DV02',1700000)
insert into banggiaqc values ('B04','DV03',2000000)
insert into banggiaqc values ('B05','DV01',900000)
insert into banggiaqc values ('B05','DV02',1300000)
insert into banggiaqc values ('B05','DV03',1700000)
insert into banggiaqc values ('B06','DV01',950000)
insert into banggiaqc values ('B06','DV02',1650000)
insert into banggiaqc values ('B06','DV03',1800000)

insert into banggiavb values ('B01','TL01',500000)
insert into banggiavb values ('B01','TL02',1000000)
insert into banggiavb values ('B01','TL03',1500000)
insert into banggiavb values ('B01','TL04',1000000)
insert into banggiavb values ('B01','TL05',1200000)
insert into banggiavb values ('B02','TL01',800000)
insert into banggiavb values ('B02','TL02',1500000)
insert into banggiavb values ('B02','TL03',2000000)
insert into banggiavb values ('B02','TL04',850000)
insert into banggiavb values ('B02','TL05',1350000)
insert into banggiavb values ('B03','TL01',450000)
insert into banggiavb values ('B03','TL02',950000)
insert into banggiavb values ('B03','TL03',1200000)
insert into banggiavb values ('B03','TL04',950000)
insert into banggiavb values ('B03','TL05',1000000)
insert into banggiavb values ('B04','TL01',850000)
insert into banggiavb values ('B04','TL02',1200000)
insert into banggiavb values ('B04','TL03',1300000)
insert into banggiavb values ('B04','TL04',1400000)
insert into banggiavb values ('B04','TL05',1500000)
insert into banggiavb values ('B05','TL01',865000)
insert into banggiavb values ('B05','TL02',1000000)
insert into banggiavb values ('B05','TL03',1300000)
insert into banggiavb values ('B05','TL04',1400000)
insert into banggiavb values ('B05','TL05',1450000)
insert into banggiavb values ('B06','TL01',750000)
insert into banggiavb values ('B06','TL02',950000)
insert into banggiavb values ('B06','TL03',1250000)
insert into banggiavb values ('B06','TL04',1400000)
insert into banggiavb values ('B06','TL05',1650000)

insert into khachhang values ('KH01',N'Phạm Hoàng An',N'Hà Nội','0365478951','hoangan12@gmail.com','LVHD01');
insert into khachhang values ('KH02',N'Nguyễn Văn Thuận',N'Long An','0458791456','aben11@gmail.com','LVHD02')
insert into khachhang values ('KH03',N'Lâm Đình Khoa',N'Đồng Tháp','0947815426','anhpha2405@gmail.com','LVHD03')
insert into khachhang values ('KH04',N'Trần Thái Linh',N'Hà Nội','0365412789','yeah1606@gmail.com','LVHD04')
insert into khachhang values ('KH05',N'Phùng Tùng Anh',N'Hà Nội','0341257845','tunganh789@gmail.com','LVHD05')
insert into khachhang values ('KH06',N'Phùng Thanh Tùng',N'Hà Nội','0965412541','thanhtung15@gmail.com','LVHD01')
insert into khachhang values ('KH07',N'Lê Đức Anh',N'Bắc Giang','0987451245','jinjun@gmail.com','LVHD02')
insert into khachhang values ('KH08',N'Nguyễn Quỳnh Trang',N'Vĩnh Phúc','0998741524','quynhtrang92@gmail.com','LVHD03')
insert into khachhang values ('KH09',N'Nguyễn Huy Hoàng',N'Hà Nội','0365978412','hhoang@gmail.com','LVHD04')
insert into khachhang values ('KH10',N'Phùng Trang Anh',N'Hà Nội','0321458785','tranganht10@gmail.com','LVHD05')
insert into khachhang values ('KH11',N'Lê Khôi',N'Hà Nội','0986541236','Lekhoai1285@gmail.com','LVHD01')
insert into khachhang values ('KH12',N'Nguyễn Văn Ngọc',N'Hà Nội','0369741241','vanngocnguyen12@gmail.com','LVHD02')
insert into khachhang values ('KH13',N'Hoàng Văn Khoa',N'Hải Phòng','0983214561','hoangkhoa12@gmail.com','LVHD03')

insert into nhanvien values ('NV01',N'Phạm Hồng Anh',N'Nam',N'Hà Nội','0245879415','pha@gmail.com','2003-08-05','CM01','TD01','CV01','PB01')
insert into nhanvien values ('NV02',N'Nguyễn Hữu Mạnh',N'Nam',N'Nghệ An','0654781245','NHM@gmail.com','2003-01-09','CM02','TD02','CV02','PB02')
insert into nhanvien values ('NV03',N'Nguyễn Ngọc An',N'Nam',N'Thanh Hóa','0987451425','NNA@gmail.com','2003-08-02','CM03','TD03','CV03','PB03')
insert into nhanvien values ('NV04',N'Đỗ Đình Thắng',N'Nam',N'Bắc Giang','0784512459','DDT@gmail.com','2003-04-26','CM01','TD01','CV04','PB04')
insert into nhanvien values ('NV05',N'Nguyễn Hoàng Anh',N'Nam',N'Thái Bình','0654124789','NHA@gmail.com','2003-10-16','CM02','TD02','CV01','PB01')

insert into quangcao values ('QC29052024_093111','NV01','KH01','2024-05-18')
insert into quangcao values ('QC29052024_093348','NV02','KH02','2024-05-10')
insert into quangcao values ('QC29052024_093423','NV03','KH03','2024-04-30')
insert into quangcao values ('QC29052024_093515','NV04','KH04','2024-05-01')
insert into quangcao values ('QC29052024_093520','NV05','KH05','2024-05-20')

insert into vietbai values ('VB29052024_093539','NV01','KH06','2024-04-28')
insert into vietbai values ('VB29052024_093553','NV02','KH07','2024-04-15')
insert into vietbai values ('VB29052024_093600','NV03','KH08','2024-04-01')
insert into vietbai values ('VB29052024_093606','NV04','KH09','2024-03-26')
insert into vietbai values ('VB29052024_093611','NV05','KH10','2024-03-29')

insert into chitietquangcao values ('CTQC29052024_094339','QC29052024_093111','DV01','B01',N'Quảng cáo sản phẩm mới ra mắt với siêu công nghệ','2024-05-20','2024-05-22',700000)
insert into chitietquangcao values ('CTQC29052024_094646','QC29052024_093111','DV02','B02',N'Quảng cáo sản phẩm mới ra mắt với siêu công nghệ','2024-05-20','2024-05-22',1500000)
insert into chitietquangcao values ('CTQC29052024_094657','QC29052024_093111','DV03','B03',N'Quảng cáo sản phẩm mới ra mắt với siêu công nghệ','2024-05-20','2024-05-22',1000000)

insert into chitietquangcao values ('CTQC29052024_094841','QC29052024_093348','DV01','B04',N'Giới thiệu một siêu dự án mang lại lợi nhuận bất ngờ','2024-05-15','2024-05-22',1500000)
insert into chitietquangcao values ('CTQC29052024_095016','QC29052024_093348','DV02','B05',N'Giới thiệu một siêu dự án mang lại lợi nhuận bất ngờ','2024-05-15','2024-05-22',1300000)
insert into chitietquangcao values ('CTQC29052024_095020','QC29052024_093348','DV03','B06',N'Giới thiệu một siêu dự án mang lại lợi nhuận bất ngờ','2024-05-15','2024-05-22',1800000)

insert into chitietquangcao values ('CTQC29052024_095758','QC29052024_093423','DV01','B02',N'5 bước giúp bạn thuyết phục người đối diện','2024-05-05','2024-05-12',1000000)
insert into chitietquangcao values ('CTQC29052024_095805','QC29052024_093423','DV01','B04',N'5 bước giúp bạn thuyết phục người đối diện','2024-05-05','2024-05-12',1500000)
insert into chitietquangcao values ('CTQC29052024_095809','QC29052024_093423','DV01','B06',N'5 bước giúp bạn thuyết phục người đối diện','2024-05-05','2024-05-12',950000)

insert into chitietquangcao values ('CTQC29052024_095813','QC29052024_093515','DV02','B04',N'SUM SYMPHONY - Tiên phong sống chuẩn thượng lưu tại Đà Nẵng','2024-05-06','2024-05-10',1700000)
insert into chitietquangcao values ('CTQC29052024_095817','QC29052024_093515','DV02','B05',N'SUM SYMPHONY - Tiên phong sống chuẩn thượng lưu tại Đà Nẵng','2024-05-06','2024-05-10',1300000)
insert into chitietquangcao values ('CTQC29052024_095821','QC29052024_093515','DV02','B06',N'SUM SYMPHONY - Tiên phong sống chuẩn thượng lưu tại Đà Nẵng','2024-05-06','2024-05-10',1650000)

insert into chitietquangcao values ('CTQC29052024_095826','QC29052024_093520','DV03','B01',N'Mercedes Benz E-Class Một tâm thế mới','2024-05-25','2024-05-29',800000)
insert into chitietquangcao values ('CTQC29052024_095832','QC29052024_093520','DV03','B03',N'Mercedes Benz E-Class Một tâm thế mới','2024-05-25','2024-05-29',1000000)
insert into chitietquangcao values ('CTQC29052024_095836','QC29052024_093520','DV03','B05',N'Mercedes Benz E-Class Một tâm thế mới','2024-05-25','2024-05-29',1700000)

insert into chitietvietbai values ('CTVB29052024_101005','VB29052024_093539','B01','TL01',N'Djokovic thắng nhọc ở vòng đầu Roland Garros',N'PHÁPTay vợt số một thế giới Novak Djokovic hạ chủ nhà Pierre-Hugues Herbert 6-4, 7-6(3)','2024-05-02',500000)
insert into chitietvietbai values ('CTVB29052024_101010','VB29052024_093539','B02','TL01',N'Djokovic thắng nhọc ở vòng đầu Roland Garros',N'PHÁPTay vợt số một thế giới Novak Djokovic hạ chủ nhà Pierre-Hugues Herbert 6-4, 7-6(3)','2024-05-02',800000)
insert into chitietvietbai values ('CTVB29052024_101013','VB29052024_093539','B03','TL01',N'Djokovic thắng nhọc ở vòng đầu Roland Garros',N'PHÁPTay vợt số một thế giới Novak Djokovic hạ chủ nhà Pierre-Hugues Herbert 6-4, 7-6(3)','2024-05-02',450000)

insert into chitietvietbai values ('CTVB29052024_101017','VB29052024_093553','B04','TL02',N'Giá vé máy bay toàn cầu qua đỉnh',N'Sau giai đoạn bùng nổ du lịch hậu Covid-19, giá vé máy bay toàn cầu đã hạ nhiệt từ mức đỉnh do nhu cầu giảm ở châu Âu và Á.','2024-04-18',1200000)
insert into chitietvietbai values ('CTVB29052024_101020','VB29052024_093553','B05','TL02',N'Giá vé máy bay toàn cầu qua đỉnh',N'Sau giai đoạn bùng nổ du lịch hậu Covid-19, giá vé máy bay toàn cầu đã hạ nhiệt từ mức đỉnh do nhu cầu giảm ở châu Âu và Á.','2024-04-20',1000000)
insert into chitietvietbai values ('CTVB29052024_101025','VB29052024_093553','B06','TL02',N'Giá vé máy bay toàn cầu qua đỉnh',N'Sau giai đoạn bùng nổ du lịch hậu Covid-19, giá vé máy bay toàn cầu đã hạ nhiệt từ mức đỉnh do nhu cầu giảm ở châu Âu và Á.','2024-04-22',950000)

insert into chitietvietbai values ('CTVB29052024_101029','VB29052024_093600','B02','TL03',N'Giá nhà Mỹ tăng 4 tháng liên tiếp',N'Tháng qua, giá trung bình của một căn nhà hiện hữu tại Mỹ cao hơn 5,7% so với cùng kỳ 2023, là tháng tăng thứ 4 liên tiếp.','2024-04-06',2000000)
insert into chitietvietbai values ('CTVB29052024_101033','VB29052024_093600','B04','TL03',N'Giá nhà Mỹ tăng 4 tháng liên tiếp',N'Tháng qua, giá trung bình của một căn nhà hiện hữu tại Mỹ cao hơn 5,7% so với cùng kỳ 2023, là tháng tăng thứ 4 liên tiếp.','2024-04-07',1300000)
insert into chitietvietbai values ('CTVB29052024_101036','VB29052024_093600','B06','TL03',N'Giá nhà Mỹ tăng 4 tháng liên tiếp',N'Tháng qua, giá trung bình của một căn nhà hiện hữu tại Mỹ cao hơn 5,7% so với cùng kỳ 2023, là tháng tăng thứ 4 liên tiếp.','2024-04-08',1250000)

insert into chitietvietbai values ('CTVB29052024_101043','VB29052024_093606','B04','TL04',N'Ngân Hàng UOB khởi xướng chương trình “Hành Động Xanh, Tương Lai Xanh”',N'Ngân hàng UOB Việt Nam vừa ra mắt chương trình "Hành động xanh, tương lai xanh"','2024-04-01',1400000)
insert into chitietvietbai values ('CTVB29052024_101047','VB29052024_093606','B05','TL04',N'Ngân Hàng UOB khởi xướng chương trình “Hành Động Xanh, Tương Lai Xanh”',N'Ngân hàng UOB Việt Nam vừa ra mắt chương trình "Hành động xanh, tương lai xanh"','2024-04-02',1400000)
insert into chitietvietbai values ('CTVB29052024_101052','VB29052024_093606','B06','TL04',N'Ngân Hàng UOB khởi xướng chương trình “Hành Động Xanh, Tương Lai Xanh”',N'Ngân hàng UOB Việt Nam vừa ra mắt chương trình "Hành động xanh, tương lai xanh"','2024-04-03',1400000)

insert into chitietvietbai values ('CTVB29052024_101056','VB29052024_093611','B01','TL05',N'Chứng khoán lấy lại mốc 1.280 điểm',N'VN-Index giữ sắc xanh cả ngày và tăng vào những phút cuối phiên, đóng cửa ở sát 1.282 điểm - vùng giá trước phiên giảm cuối tuần trước. ','2024-04-03',1200000)
insert into chitietvietbai values ('CTVB29052024_101100','VB29052024_093611','B03','TL05',N'Chứng khoán lấy lại mốc 1.280 điểm',N'VN-Index giữ sắc xanh cả ngày và tăng vào những phút cuối phiên, đóng cửa ở sát 1.282 điểm - vùng giá trước phiên giảm cuối tuần trước. ','2024-04-04',1000000)
insert into chitietvietbai values ('CTVB29052024_101104','VB29052024_093611','B05','TL05',N'Chứng khoán lấy lại mốc 1.280 điểm',N'VN-Index giữ sắc xanh cả ngày và tăng vào những phút cuối phiên, đóng cửa ở sát 1.282 điểm - vùng giá trước phiên giảm cuối tuần trước. ','2024-04-05',1450000)