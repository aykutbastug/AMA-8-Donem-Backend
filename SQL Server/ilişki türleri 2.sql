select * from dbo.OKUL_Ogrenciler
select * from dbo.OKUL_OzlukBilgileri
select * from dbo.OKUL_Veliler
select * from dbo.OKUL_Dersler
select * from dbo.OKUL_Ogretmenler
select * from dbo.OKUL_OgretmenDers

insert into dbo.OKUL_Ogrenciler values ('Öğrenci 3', '547333', 'ogrenci3@deneme.com', 85)


insert into dbo.OKUL_OzlukBilgileri 
([OgrenciId], [KimlikNo], [DogumTarihi]) 
values 
(4, '6789', '19870929')

--delete from dbo.OKUL_OzlukBilgileri where OzlukId=7

insert into dbo.OKUL_Veliler values (4, 'BABA', 'Veli 4-1', '545000', 'İstanbul')


insert into dbo.OKUL_Dersler values ('Matematik')
insert into dbo.OKUL_Dersler values ('Türkçe')
insert into dbo.OKUL_Dersler values ('Geometri')

insert into dbo.OKUL_Ogretmenler values ('Öğretmen 3', 'Fen Bilgisi')

insert into dbo.OKUL_OgretmenDers values (1, 1)
insert into dbo.OKUL_OgretmenDers values (1, 3)

insert into dbo.OKUL_OgretmenDers values (2, 2)
insert into dbo.OKUL_OgretmenDers values (2, 3)

insert into dbo.OKUL_OgretmenDers values (3, 1)
insert into dbo.OKUL_OgretmenDers values (3, 2)
insert into dbo.OKUL_OgretmenDers values (3, 3)