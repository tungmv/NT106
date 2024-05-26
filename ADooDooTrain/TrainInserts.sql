insert into Tram VALUES
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
	('HP1', 'Ga Hải Phòng', 'Hải Phòng', 'Hải Phòng'),
	('HNA1', 'Ga Phủ Lý', 'Phủ Lý' ,'Hà Nam'),
	('NB1', 'Ga Ninh Bình', 'Ninh Bình', 'Ninh Bình'),
	('BDI2', 'Ga Diêu Trì', 'Tuy Phước', 'Bình Định'),
	('BT3', 'Ga Sông Mao', 'Hàm Thuận Bắc', 'Bình Thuận');

insert into Tau values
	('D10H-028', '18', 'HN-HCM', 'C'),
	('D10H-027', '18', 'HN-HCM', 'C'),
	('D13E-701', '41', 'HN-HCM', 'C'),
	('D18E-601', '41', 'HCM-BT', 'C'),
	('D18E-602', '41', 'HCM-BT', 'C'),
	('D18E-603', '41', 'HN-HP', 'C'),
	('D18E-604', '41', 'HN-HP', 'C'),
	('SE1', '12', 'HN-HCM', 'A'),
	('SE2', '14', 'HN-HCM', 'A'),
	('SH1', '20', 'HN-HCM', 'C')
	
insert into Tuyen values 
	('HN-HCM', 'Hà Nội - Hồ Chí Minh'),
	('HN-HP', 'Hà Nội - Hải Phòng'),
	('HCM-BT', 'Hồ Chí Minh - Bình Thuận')

insert into DiemDi values
	('HCM-BT', 'HCM1', '0'),
	('HCM-BT', 'DNI1', '29'),
	('HCM-BT', 'DNI2', '37'),
	('HCM-BT', 'BT1', '179'),
	('HCM-BT', 'BT2', '181'),
	('HN-HP', 'HN1', '0'),
	('HN-HP', 'HP1', '102'),
	('HN-HCM', 'HN1', '0'),
	('HN-HCM', 'HNA1', '58'),
	('HN-HCM', 'NB1', '115'),
	('HN-HCM', 'NA1', '319'),
	('HN-HCM', 'HUE1', '688'),
	('HN-HCM', 'DNA1', '791'),
	('HN-HCM', 'QNG1', '901'),
	('HN-HCM', 'BDI2', '1080'),
	('HN-HCM', 'NT1', '1315'),
	('HN-HCM', 'BT3', '1487'),
	('HN-HCM', 'DNI1', '1699'),
	('HN-HCM', 'HCM1', '1726')
	
insert into LichTrinh values
	('HCM-BT1', 'D18E-601', 'HCM-BT', '3:00:00'),
	('HCM-BT2', 'D18E-602', 'HCM-BT', '9:00:00'),
	('HCM-BT3', 'D18E-601', 'HCM-BT', '18:00:00'),
	('HCM-BT4', 'D18E-602', 'HCM-BT', '21:00:00'),
	('HN-HP1', 'D18E-603', 'HN-HP', '3:00:00'),
	('HN-HP2', 'D18E-604', 'HN-HP', '9:00:00'),
	('HN-HP3', 'D18E-603', 'HN-HP', '18:00:00'),
	('HN-HP4', 'D18E-604', 'HN-HP', '21:00:00'),
	('HN-HCM1', 'D10H-027', 'HN-HCM', '5:00:00', 'Monday', '0'),
	('HN-HCM2', 'D10H-028', 'HN-HCM', '17:00:00', 'Monday', '0'),
	('HN-HCM3', 'SE1', 'HN-HCM', '12:00:00', 'Monday', '0'),
	('HN-HCM4', 'SE2', 'HN-HCM', '21:00:00', 'Monday', '0'),
	('HN-HCM5', 'SH1', 'HN-HCM', '9:00:00', 'Tuesday', '0'),
	('HN-HCM6', 'D13E-701', 'HN-HCM', '3:00:00', 'Tuesday', '0'),
	('HN-HCM11', 'D10H-027', 'HN-HCM', '5:00:00', 'Thursday', '1'),
	('HN-HCM12', 'D10H-028', 'HN-HCM', '17:00:00', 'Thursday', '1'),
	('HN-HCM7', 'SE1', 'HN-HCM', '12:00:00', 'Thursday', '1'),
	('HN-HCM8', 'SE2', 'HN-HCM', '12:00:00', 'Thursday', '1'),
	('HN-HCM9', 'SH1', 'HN-HCM', '9:00:00', 'Friday', '1'),
	('HN-HCM10', 'D13E-701', 'HN-HCM', '3:00:00', 'Friday', '1');
	
insert into Toa VALUES
	('SE1G01', 'Mềm điều hòa', 'SE1'),
	('SE1G02', 'Mềm điều hòa', 'SE1'),
	('SE1N01', 'Nằm', 'SE1'),
	('SE1N02', 'Nằm', 'SE1'),
	('SE2S01', 'Mềm điều hòa', 'SE2'),
	('SE2S02', 'Mềm điều hòa', 'SE2'),
	('SE2S03', 'Mềm điều hòa', 'SE2'),
	('SE2N01', 'Nằm', 'SE2'),
	('SH1S01', 'Mềm', 'SH1'),
	('SH1S02', 'Mềm', 'SH1'),
	('SH1N01', 'Nằm', 'SH1'),
	('SH1N02', 'Nằm', 'SH1'),
	('D18E-601S01', 'Cứng', 'D18E-601'),
	('D18E-601S02', 'Cứng', 'D18E-601'),
	('D18E-601S03', 'Cứng điều hòa', 'D18E-601'),
	('D18E-601S04', 'Cứng điều hòa', 'D18E-601'),
	('D18E-603S01', 'Cứng điều hòa', 'D18E-603'),
	('D18E-603S02', 'Cứng điều hòa', 'D18E-603'),
	('D18E-603S03', 'Cứng điều hòa', 'D18E-603'),
	('D18E-603S04', 'Cứng điều hòa', 'D18E-603')

insert into Phong VALUES
	('SE1N01P1', 'SE1N01'),
	('SE1N01P2', 'SE1N01'),
	('SE1N01P3', 'SE1N01'),
	('SE1N01P4', 'SE1N01'),
	('SE1N01P5', 'SE1N01'),
	('SE1N02P1', 'SE1N02'),
	('SE1N02P2', 'SE1N02'),
	('SE1N02P3', 'SE1N02'),
	('SE1N02P4', 'SE1N02'),
	('SE1N02P5', 'SE1N02'),
	('SE2N01P1', 'SE2N01'),
	('SE2N01P2', 'SE2N01'),
	('SE2N01P3', 'SE2N01'),
	('SE2N01P4', 'SE2N01'),
	('SE2N01P5', 'SE2N01'),
	('SH1N01P1', 'SH1N01'),
	('SH1N01P2', 'SH1N01'),
	('SH1N01P3', 'SH1N01'),
	('SH1N01P4', 'SH1N01'),
	('SH1N01P5', 'SH1N01'),
	('SH1N02P1', 'SH1N02'),
	('SH1N02P2', 'SH1N02'),
	('SH1N02P3', 'SH1N02'),
	('SH1N02P4', 'SH1N02'),
	('SH1N02P5', 'SH1N02')
	
insert into Giuong VALUES
	('01', 'SE1N01P1'),
	('02', 'SE1N01P1'),
	('03', 'SE1N01P1'),
	('04', 'SE1N01P1'),
	('01', 'SE1N01P2'),
	('02', 'SE1N01P2'),
	('03', 'SE1N01P2'),
	('04', 'SE1N01P2'),
	('01', 'SE1N01P3'),
	('02', 'SE1N01P3'),
	('03', 'SE1N01P3'),
	('04', 'SE1N01P3'),
	('01', 'SE1N01P4'),
	('02', 'SE1N01P4'),
	('03', 'SE1N01P4'),
	('04', 'SE1N01P4'),
	('01', 'SE1N01P5'),
	('02', 'SE1N01P5'),
	('03', 'SE1N01P5'),
	('04', 'SE1N01P5')
	
insert into Ghe values
	('01', 'SE1G02', '1'),
	('02', 'SE1G02', '1'),
	('03', 'SE1G02', '1'),
	('04', 'SE1G02', '1'),
	('05', 'SE1G02', '1'),
	('06', 'SE1G02', '1'),
	('07', 'SE1G02', '1'),
	('08', 'SE1G02', '1'),
	('09', 'SE1G02', '1'),
	('10', 'SE1G02', '1'),
	('11', 'SE1G02', '1'),
	('12', 'SE1G02', '1'),
	('13', 'SE1G02', '1'),
	('14', 'SE1G02', '1'),
	('15', 'SE1G02', '1'),
	('16', 'SE1G02', '1'),
	('17', 'SE1G02', '1'),
	('18', 'SE1G02', '1'),
	('19', 'SE1G02', '1'),
	('20', 'SE1G02', '1'),
	('21', 'SE1G02', '1'),
	('22', 'SE1G02', '1'),
	('23', 'SE1G02', '1'),
	('24', 'SE1G02', '1'),
	('25', 'SE1G02', '1'),
	('26', 'SE1G02', '1'),
	('27', 'SE1G02', '1'),
	('28', 'SE1G02', '1'),
	('29', 'SE1G02', '1'),
	('30', 'SE1G02', '1'),
	('31', 'SE1G02', '1'),
	('32', 'SE1G02', '1'),
	('33', 'SE1G02', '1'),
	('34', 'SE1G02', '1'),
	('35', 'SE1G02', '1'),
	('36', 'SE1G02', '1'),
	('37', 'SE1G02', '1'),
	('38', 'SE1G02', '1'),
	('39', 'SE1G02', '1'),
	('40', 'SE1G02', '1')
