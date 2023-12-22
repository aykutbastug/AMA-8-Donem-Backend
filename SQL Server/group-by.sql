select Country, City from dbo.Customers group by Country, City
select Country, City from dbo.Customers group by Country, City order by Country, City

--from
--join'ler
--where
--group by
--order by

select Country, COUNT(Country) as [Kayıt Sayısı] from dbo.Customers group by Country


select c.CategoryID, c.CategoryName, COUNT(p.CategoryID) as [Ürün Sayısı] 
from dbo.Categories as c
inner join dbo.Products as p on p.CategoryID=c.CategoryID
where c.CategoryName like 'C%' and p.ProductName like 'G%'
group by c.CategoryID, c.CategoryName



select c.CategoryID, c.CategoryName, SUM(p.UnitsInStock) as [Stok Miktarı] 
from dbo.Categories as c
inner join dbo.Products as p on p.CategoryID=c.CategoryID
group by c.CategoryID, c.CategoryName



select SUM(UnitsInStock) from dbo.Products where CategoryID=5


--hangi ülkeye kaç paralık satış yapmışım.
select c.Country, SUM(od.UnitPrice * od.Quantity) as TotalPrice
from dbo.Customers as c
inner join dbo.Orders as o on o.CustomerID=c.CustomerID
inner join dbo.OrderDetails as od on od.OrderID=o.OrderID
--where
group by c.Country
having SUM(od.UnitPrice * od.Quantity)>20000
order by c.Country

--sipariş detay üzerinden gidilen hali
select o.ShipCountry,SUM(od.Quantity*od.UnitPrice) as[Tutar]from dbo.OrderDetails as odinner join dbo.Orders as o on o.OrderID = od.OrderIDgroup by o.ShipCountry


--en az tutar sipariş veren müşteriyi dönen sql cümlesini yazınız.
select top 1 c.ContactName, SUM(od.UnitPrice * od.Quantity) as TotalPrice
from dbo.Customers as c
inner join dbo.Orders as o on o.CustomerID=c.CustomerID
inner join dbo.OrderDetails as od on od.OrderID=o.OrderID
group by c.ContactName
order by TotalPrice