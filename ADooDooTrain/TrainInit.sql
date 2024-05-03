create table Tau (
	ID_Tau varchar(15) primary key not null unique,
	TuoiTho integer default 0,
	constraint check_tau check (TuoiTho >=0)
);

create table Toa (
	ID_Toa varchar(15) primary key not null unique,
	Loai varchar(10) default 'thuong',
	ID_Tau varchar(15),
	constraint check_toa check (Loai in ('thuong', 'sang', 'giuong nam')),
	foreign key (ID_Tau) references Tau(ID_Tau)
);

create table Ghe (
	ID_Ghe varchar(15) primary key not null unique,
	Loai varchar(4) default 'cung' not null, /*cung hoac mem*/
	ID_Toa varchar(15) foreign key references Toa(ID_Toa),
	constraint check_ghe check (Loai in ('cung', 'mem')),
	
);

create table Phong (
	ID_Phong varchar(15) primary key not null unique,
	Loai varchar(1) default '4' not null, /*4 hoac 6 giuong*/
	ID_Toa varchar(15) foreign key references Toa(ID_Toa),
	constraint check_phong check (Loai in ('4', '6'))
);

create table Giuong (
	ID_Giuong varchar(15) primary key not null unique,
	ID_Phong varchar(15),
	foreign key (ID_Phong) references Phong(ID_Phong)
);

create table Tram (
	ID_Tram varchar(15) primary key not null unique,
	TenTram varchar(30) not null,
	Thanhpho varchar(30) not null,
	Tinh varchar(15)
);

create table LoTrinh (
	ID_LoTrinh varchar(15) primary key not null unique,
	XuatPhat varchar(15) not null,
	DiemDen varchar(15) not null,
	KhoiHanh text,
	ThoiGian integer default 0,	/*thoi gian uoc chung (ETA)*/
	foreign key (XuatPhat) references Tram(ID_Tram),
	foreign key (DiemDen) references Tram(ID_Tram),
	constraint check_lotrinh check (ThoiGian >=0)
);

create table VeNgoi (
	ID_VeNgoi varchar(20) primary key not null,
	ID_LoTrinh varchar(15) not null,
	ID_Ghe varchar(15) not null,
	DonGia integer default 0,
	KhaDung integer default 1,
	foreign key (ID_LoTrinh) references LoTrinh(ID_LoTrinh),
	foreign key (ID_Ghe) references Ghe(ID_Ghe),
	constraint check_tien check (DonGia >=0 and (KhaDung >=0 or KhaDung <=1))
);

create table VeNam (
	ID_VeNam varchar(20) primary key not null,
	ID_LoTrinh varchar(15) not null,
	ID_Giuong varchar(15) not null,
	DonGia integer default 0,
	KhaDung integer default 1,
	foreign key (ID_LoTrinh) references LoTrinh(ID_LoTrinh),
	foreign key (ID_Giuong) references Giuong(ID_Giuong),
	constraint check_tien check (DonGia >=0 and (KhaDung >=0 or KhaDung <=1))
);