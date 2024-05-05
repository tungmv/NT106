create table khachhang(
	ID_KhachHang varchar(50) primary key,
	HoTen varchar not null,
	NamSinh integer,
	SoDienThoai varchar(12), 
	Email varchar(100),
	NgayTao datetime default CURRENT_TIMESTAMP,
	constraint check_kh check ((NamSinh > 1900) and (length(SoDienThoai) > 10))
)

create table KhongPhaiMatKhau(
	ID_KhachHang varchar(50),
	Hashed varchar(64) not null,
	Salt varchar(50),
	foreign key (ID_KhachHang) references khachhang(ID_KhachHang) 
	on delete cascade 
	on update cascade
)

create table LichSuDatVeNgoi(
	ID_VeNgoi varchar(50) primary key,
	ID_KhachHang varchar(50),
	foreign key (ID_KhachHang) references KhachHang(ID_KhachHang) 
	on delete CASCADE
	on update CASCADE
)