insert into tram VALUES
	('DNI1', 'Ga Biên Hòa', 'Biên Hòa', 'Đồng Nai'),
	('DNI2', 'Ga Hố Nai', 'Biên Hòa', 'Đồng Nai'),
	('DN3', 'Ga Long Khánh', 'Biên Hòa', 'Đồng Nai'),
	('HCM1', 'Ga Sài Gòn', '3', 'Hồ Chí Minh'),
	('HCM2', 'Ga Gò Vấp', '3', 'Hồ Chí Minh'),
	('BDG1', 'Ga Dĩ An', 'Dĩ An', 'Bình Dương'),
	('BD2', 'Ga Sóng Thần', 'Dĩ An', 'Bình Dương'),
	('BT1', 'Ga Bình Thuận', 'Phan Thiết', 'Bình Thuận'),
	('BT2', 'Ga Phan Thiết', 'Phan Thiết', 'Bình Thuận'),
	('BDI1', 'Ga Quy Nhơn', 'Quy Nhơn', 'Bình Định'),
	('NT1', 'Ga Nha Trang', 'Nha Trang', 'Khánh Hòa'),
	('QNG1', 'Ga Quảng Ngãi', 'Quảng Ngãi', 'Quảng Ngãi'),
	('QNI1', 'Ga Hạ Long', 'Hạ Long', 'Quảng Ninh'),
	('DNA1', 'Ga Đà Nẵng', 'Đà Nẵng', 'Đà Nẵng'),
	('HUE1', 'Ga Huế', 'Huế', 'Thừa Thiên Huế'),
	('NA1', 'Ga Vinh', 'Vinh', 'Nghệ An'),
	('HN1', 'Ga Hà Nội', 'Hòan Kiếm', 'Hà Nội'),
	('HP1', 'Ga Hải Phòng', 'Hải Phòng', 'Hải Phòng')

insert into Tau values
	('D10H-028', '18'),
	('D10H-027', '18'),
	('D13E-701', '41'),
	('D18E-601', '41'),
	('D18E-602', '41'),
	('D18E-603', '41'),
	('D18E-604', '41')
	
insert into Tuyen values 
	('HN-HCM'),
	('HN-HP'),
	('HCM-BT')

insert into DiemDi values
	('HCM-BT', 'HCM1', '0'),
	('HCM-BT', 'DNI1', '29'),
	('HCM-BT', 'DNI2', '37'),
	('HCM-BT', 'BT1', '179'),
	('HCM-BT', 'BT2', '181'),
	('HN-HP', 'HN1', '0'),
	('HN-HP', 'HP1', '102');
	
insert into LichTrinh values
	('HCM-BT', '3:00:00', 'D18E-601'),
	('HCM-BT', '9:00:00', 'D18E-602'),
	('HCM-BT', '18:00:00', 'D18E-601'),
	('HCM-BT', '21:00:00', 'D18E-602'),
	('HN-HP', '3:00:00', 'D18E-603'),
	('HN-HP', '9:00:00', 'D18E-604'),
	('HN-HP', '18:00:00', 'D18E-603'),
	('HN-HP', '21:00:00', 'D18E-604');
	