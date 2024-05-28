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
	noidung text not null,
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