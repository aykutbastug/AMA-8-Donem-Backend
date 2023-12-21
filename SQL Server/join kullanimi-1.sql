--iki tablo arasındaki sadece eşleşen kayıtları bize getirir
select o.OgrenciId, o.AdiSoyadi, ob.KimlikNo, ob.DogumTarihi
from dbo.OKUL_Ogrenciler as o
inner join dbo.OKUL_OzlukBilgileri as ob on ob.OgrenciId=o.OgrenciId


select o.*, v.VeliTipi, v.AdiSoyadi 
from dbo.OKUL_Ogrenciler as o
inner join dbo.OKUL_Veliler as v on v.OgrenciId=o.OgrenciId



select o.OgrenciId, o.AdiSoyadi, ob.KimlikNo, ob.DogumTarihi
from dbo.OKUL_Ogrenciler as o
LEFT JOIN dbo.OKUL_OzlukBilgileri as ob on ob.OgrenciId=o.OgrenciId

select * from dbo.OKUL_Ogrenciler


select o.OgrenciId, o.AdiSoyadi, ob.*
from dbo.OKUL_Ogrenciler as o
RIGHT JOIN dbo.OKUL_OzlukBilgileri as ob on ob.OgrenciId=o.OgrenciId

select * from dbo.OKUL_OzlukBilgileri



select o.AdiSoyadi, ob.KimlikNo, ob.DogumTarihi, v.VeliTipi, v.AdiSoyadi 
from dbo.OKUL_Ogrenciler as o
inner join dbo.OKUL_Veliler as v on v.OgrenciId=o.OgrenciId
inner join dbo.OKUL_OzlukBilgileri as ob on ob.OgrenciId=o.OgrenciId
where v.VeliTipi='ANNE'
order by o.AdiSoyadi desc



select o.AdiSoyadi, d.DersAdi
from dbo.OKUL_OgretmenDers as od
inner join dbo.OKUL_Ogretmenler as o on o.OgretmenId=od.OgretmenId
left join dbo.OKUL_Dersler as d on d.DersId=od.DersId