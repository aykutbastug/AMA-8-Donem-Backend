select * from [dbo].[Musteriler]


INSERT INTO dbo.Musteriler VALUES('Aykut BAŞTUĞ', 'İstanbul')
insert into dbo.Musteriler (AdiSoyadi, [Adres]) VALUES ('Aykut BAŞTUĞ 2', 'Ümraniye')
insert into dbo.Musteriler ([Adres], AdiSoyadi) VALUES ('Ankara', 'Aykut BAŞTUĞ 3')
insert into dbo.Musteriler (AdiSoyadi) VALUES ('Aykut BAŞTUĞ 4')
insert into dbo.Musteriler (AdiSoyadi, Adres) VALUES ('Aykut BAŞTUĞ 5', NULL)



UPDATE dbo.Musteriler set AdiSoyadi='Aykut BASTUG 5' where Id=6
UPDATE dbo.Musteriler set Adres='Manisa' where Adres is null
UPDATE dbo.Musteriler set AdiSoyadi='Aykut BASTUG 6', Adres='İstanbul' where Id=6

update dbo.Musteriler set AdiSoyadi='Aykut BASTUG 1' where AdiSoyadi='Aykut BASTUG'
update dbo.Musteriler set Adres='İzmir' where Adres='Istanbul'

select * from dbo.Musteriler  where Adres='Istanbul'



delete from dbo.Musteriler where Id=8
delete from dbo.Musteriler where Adres='Izmir'
delete from dbo.Musteriler


truncate table dbo.Musteriler