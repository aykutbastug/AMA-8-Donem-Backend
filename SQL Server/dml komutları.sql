select * from dbo.Categories
--dbo.Categories tablosundaki tüm kolonları ve tüm satırları listeler

select CategoryID, CategoryName from dbo.Categories
--dbo.Categories tablosundaki CategoryID, CategoryName kolonlarına ait tüm satırları listeler

select [CustomerID],[ShipCountry] from [dbo].[Orders]

select [Adı Soyadı], adres from dbo.[müşteri tablosu]

select * from Northwind.dbo.Employees
select * from [Northwind].[dbo].[Employees]

--alias as keyword'ü ile kullanılabilir. (kolonlara çıkan lisrede bir başlık vermek için kullanılır)
select FirstName as [Adı], LastName as [Soyadı ..] from dbo.Employees

--TOP komutu ile istediğmiz sayıdaki ilk kayıtları getirebiliriz
select top 3 * from dbo.Employees
select top 3 FirstName, LastName from dbo.Employees
SELECT TOP(3) * from dbo.Employees

--select cümlesindeki tabloya as keyword'ü ile kısa takma adlar verilerbilir
select c.CompanyName, c.Country from dbo.Customers as c

--distinct komutu ile yinelenen satırları kaldırarak liste alabiliriz
select distinct Country from dbo.Customers

--where keyword'ü ile tablo içindeki verilerde filtreleme yapabilirz
--ülkesi Germany olan tüm müşterileri listeler
select * from dbo.Customers where Country='Germany'
select * from dbo.Categories where CategoryID=5
select * from dbo.Categories where CategoryID='5'


--ülkesi Germany olmayan tüm müşterileri listeler (<> işareti değilse anlamına gelir)
select * from dbo.Customers where Country<>'Germany'
select * from dbo.Categories where CategoryID<>5


select * from dbo.Customers where Country='Germany' and Country='France'
select * from dbo.Customers where Country='Germany' or Country='France'
select * from dbo.Customers where Country='Mexico' and City='México D.F.'


select * from dbo.Customers where Country='Mexico' and City='México D.F.' and (PostalCode='05021' or PostalCode='05022')

--Region kolonu NULL olan kayıtları listeler
select * from dbo.Customers where Region is null

--Region kolonu NULL olmayan kayıtları listeler
select * from dbo.Customers where Region is not null

select * from dbo.Customers where Region is null or Region=''


select * from dbo.OrderDetails where UnitPrice>50
select * from dbo.OrderDetails where UnitPrice<50
select * from dbo.OrderDetails where UnitPrice>=50
select * from dbo.OrderDetails where UnitPrice<=50
select * from dbo.OrderDetails where UnitPrice>50 and UnitPrice<60


--Sipariş detaylarında indirim yapılan kayıtları listeleyen sql cümleciğini yazınız.
select * from OrderDetails where Discount>0

select * from dbo.Employees where BirthDate is null
select * from dbo.Employees where BirthDate is not null
select * from dbo.Employees where BirthDate='19520219'
select * from dbo.Employees where BirthDate>'19520219'
select * from dbo.Employees where BirthDate>'1955-03-04 00:00:00.000'
select * from dbo.Employees where BirthDate>'1955-03-04'
select * from dbo.Employees where BirthDate>'01.30.1955' --ay-gün-yıl şeklinde yazılır kabul eder


--like (x) ile biten, (x) ile başlaya içinde (x) geçen gibi filtreler uygulamak için kullanılır
select * from Employees where [Address] like '7%' --7 ile başlayan kayıtları listeler
select * from Employees where [Address] like '%d.' -- d. ile biten kayıtları listeler
select * from Employees where [Address] like '%Ave%' --içinde Ave kelimesi geçen kayıtları listeler
select * from Employees where [Address] LIKE '%e%' --içinde e harfi geçen kayıtları listeler


--
select * from dbo.Customers where Country='Germany' or Country='France'
--in komutu ile verilern değerleri içeren kayıtları listeler
select * from dbo.Customers where Country in ('Germany','France','UK') 
select * from dbo.OrderDetails where Quantity IN (4, 8)

--not in komutu ile verilern değerleri içermeyen kayıtları listeler
select * from dbo.Customers where Country not in ('Germany','France')
select * from dbo.OrderDetails where Quantity NOT IN (4, 8)


--between komutu iki değer arasındaki kayıtları listeler
select * from dbo.OrderDetails where Quantity>=4 and Quantity<=10
select * from dbo.OrderDetails where Quantity between 4 and 10


select ProductName as [Ürün Adı], (UnitPrice * UnitsInStock) as [Tutar] from dbo.Products
select FirstName, LastName, FirstName + ' ' + LastName as [Adı Soyadı] from dbo.Employees
select FirstName, LastName, FirstName + 5 as [Adı Soyadı] from dbo.Employees 
--artı opratörü eğer sol ve sağda aynı tipde veri yoksa hata verir. birisi string birisi sayısal değer ise


select * from dbo.Customers order by CompanyName
select * from dbo.Customers order by CompanyName asc
select * from dbo.Customers order by CompanyName desc


select * from dbo.Customers where Country='Germany' order by CompanyName
select * from dbo.Customers order by Country, City desc
select * from dbo.Customers order by Country desc, City desc
select * from dbo.Customers order by Country desc, City asc


--siparişin ürün ıdsi, ürün birim fiyatı, miktarı ve tutarı alanlarını bana dönen sql cümleciğini yazınız
select ProductID as [Ürün Kodu], UnitPrice as [Birim Fiyat], Quantity as [Miktar], UnitPrice * Quantity as [Tutar] from dbo.OrderDetails order by (UnitPrice * Quantity) desc

--1-select
--2-kolonlar
--3-from
--4-where (varsa)
--5-order by sıralama (varsa)