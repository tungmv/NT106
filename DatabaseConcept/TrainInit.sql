create table Tau (
	ID_Tau varchar(15) primary key,
	TuoiTho integer default 0,
	constraint check_tau check (TuoiTho >=0)
);

create table Toa (
	ID_Toa varchar(15) primary key,
	Loai varchar(10) default 'thuong',
	ID_Tau varchar(15),
	constraint check_toa check (Loai in ('thuong', 'sang', 'giuong nam')),
	foreign key (ID_Tau) references Tau(ID_Tau) on delete cascade on update cascade
);

create table Ghe (
	ID_Ghe varchar(15) primary key,
	Loai varchar(4) default 'cung' not null, /*cung hoac mem*/
	ID_Toa varchar(15),
	foreign key (ID_Toa) references Toa(ID_Toa) on delete cascade on update cascade,
	constraint check_ghe check (Loai in ('cung', 'mem')),
	
);

create table Phong (
	ID_Phong varchar(15) primary key,
	Loai varchar(1) default '4' not null, /*4 hoac 6 giuong*/
	ID_Toa varchar(15)
	foreign key (ID_Toa) references Toa(ID_Toa) on delete cascade on update cascade,
	constraint check_phong check (Loai in ('4', '6'))
);

create table Giuong (
	ID_Giuong varchar(15) primary key,
	ID_Phong varchar(15),
	foreign key (ID_Phong) references Phong(ID_Phong) on delete cascade on update cascade
);

create table Tram (
	ID_Tram varchar(15) primary key,
	TenTram varchar(30) not null,
	Thanhpho varchar(30) not null,
	Tinh varchar(15)
);

create table Tuyen (
	ID_Tuyen varchar(15) primary key,
);

create table DiemDi(
	ID_Tuyen varchar(15),
	ID_Tram varchar(15),
	KhoangCach real,
	foreign key (ID_Tuyen) references Tuyen(ID_Tuyen),
	foreign key (ID_Tram) references Tuyen(ID_Tram),
	constraint distance check (KhoangCach >=0)
);

create table VeNgoi (
	ID_VeNgoi varchar(20) primary key,
	ID_Tuyen varchar(15),
	ID_Ghe varchar(15),
	DonGia integer default 0,
	KhaDung integer default 1,
	foreign key (ID_Tuyen) references Tuyen(ID_Tuyen) on delete cascade on update cascade,
	foreign key (ID_Ghe) references Ghe(ID_Ghe) on delete cascade on update cascade,
	constraint dieukien_ve check ((DonGia >= 0) and (KhaDung >=0))
);

create table VeNam (
	ID_VeNam varchar(20) primary key,
	ID_Tuyen varchar(15),
	ID_Giuong varchar(15),
	DonGia integer default 0,
	KhaDung integer default 1,
	foreign key (ID_Tuyen) references Tuyen(ID_Tuyen) on delete cascade on update cascade,
	foreign key (ID_Giuong) references Giuong(ID_Giuong) on delete cascade on update cascade,
	constraint dieukien_ve check ((DonGia >= 0) and (KhaDung >=0))
);

create table LichTrinh (
	ID_DiemDi varchar(15),
	KhoiHanh datetime,
	ID_Tau varchar(15),
	foreign key (ID_Tau) references Tau(ID_Tau) on update cascade on delete cascade,
	foreign key (ID_DiemDi) references DiemDi(ID_DiemDi) on update cascade on delete cascade
);