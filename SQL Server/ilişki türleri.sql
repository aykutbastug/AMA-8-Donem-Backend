--İLİşKİ TÜRLERİ

-----------------------------1. Bir'e Bir İlişki
--ilişkili tablolarda bir biriyle ilişkili maksimum birer satır olur.

--1. Tablo = Öğrenciler
--Öğrenci Id, Adı, Soyadı, Telefon, Email

--2. Tablo = Özlük Bilgileri
--Özlük Id, Öğrenci Id, Tc kimlik No, Doğum tarihi, Doğum Yeri, Anne Adı, Baba Adı



-----------------------------2. Bir'e Çok İlişki
--ilişkili tablolardan birisindeki tek satır ile diğerindeki birden fazla satır ilişkilidir

--3.Tablo = Veliler
--VeliId, Öğrenci Id, VeliTipi, Adı Soyadı, İş Adresi, Telefon



-----------------------------3. Çok'a Çok İlişki
--bir birleriyle birden fazla satır ile ilişkilidirler

--4.Tablo = Öğretmenler
--Öğretmen Id, Adı Soyadı, Branş

--5.Tablo = Dersler
--Ders Id, Ders Adı


--6.Tablo ÖğretmenDers
--Id, Öğretmen Id, Ders Id