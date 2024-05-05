/*liet ke cac tuyen tau di tu a -> b?*/
select id_tuyen 
from DiemDi dd, tram t
where dd.id_tram = t.id_tram and t.tinh = 'Hồ Chí Minh' /*a*/
INTERSECT
select id_tuyen 
from DiemDi dd, tram t
where dd.id_tram = t.id_tram and t.tinh = 'Bình Thuận' /*b*/

/*liet ke cac tuyen tau di qua x?*/
select distinct ID_LichTrinh, tentuyen from LichTrinh lt, tuyen t, tram tr, diemdi dd
where lt.id_tuyen = t.ID_Tuyen and dd.id_tuyen = t.ID_Tuyen and tr.id_tram = dd.id_tram and tinh = 'Đồng Nai' /*x*/

/*liet ke cac tram ma mot tuyen x di qua?*/
select distinct tentram, Tinh
from tram tr, tuyen t, diemdi dd
where dd.id_tuyen = t.id_tuyen and dd.id_Tram = tr.id_tram and tentuyen = 'Hồ Chí Minh - Bình Thuận'

/*khoang cach tu a toi a'?*/
select abs(sub1.khoangcach - sub2.khoangcach) as KhoangCach from
	(select khoangcach from diemdi dd, tram tr where dd.id_tram = tr.id_tram and tentram = 'Ga Hố Nai') as sub1,
	(select KhoangCach from diemdi dd, tram tr where dd.id_tram = tr.id_tram and tentram = 'Ga Phan Thiết') as sub2
