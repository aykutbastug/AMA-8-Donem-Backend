--sub query
select SUM(od.UnitPrice * od.Quantity) 
from dbo.OrderDetails as od
where od.OrderID in (select o.OrderID from dbo.Orders as o where o.ShipCountry='Finland')

select o.OrderID from dbo.Orders as o where o.ShipCountry='Finland'


--Kategori Adı, ürün sayısı
select c.*,
(select COUNT(p.ProductID) from dbo.Products as p where p.CategoryID=c.CategoryID) as [Toplam Ürün Sayısı]
from dbo.Categories as c


--Kategori Adı, ürün sayısı, kaç paralık satış yapılmış
select c.*,
(select COUNT(p.ProductID) from dbo.Products as p where p.CategoryID=c.CategoryID) as [Toplam Ürün Sayısı],

(select SUM(od.UnitPrice * od.Quantity) 
from dbo.OrderDetails as od 
inner join dbo.Products as p on p.ProductID=od.ProductID
where p.CategoryID=c.CategoryID) as [Toplam Satış Tutarı]

from dbo.Categories as c



