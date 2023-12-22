select SupplierID, CompanyName, Country,
case 
when Country='USA' then 'Amerika'
when Country='UK' then 'İngiltere'
else Country
end as [Yeni Ülke]
from dbo.Suppliers


--stok miktarı
--sıfırdan büyük ve 10 dan küçük ise 'Kritik Stok'
--sıfıra eşit veya küçük ise 'Stok Yok'
--hiç birisi değilse 'Stok Yeterli'

select ProductName, UnitsInStock, 

case
when UnitsInStock>0 and UnitsInStock<10 then 'Kritik Stok'
when UnitsInStock<=0 then 'Stok Yok'
else 'Stok Yeterli'
end
as Sonuc from dbo.Products