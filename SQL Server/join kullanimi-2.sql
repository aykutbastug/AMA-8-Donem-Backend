select * from dbo.Categories

select p.ProductID, p.ProductName, c.CategoryName 
from dbo.Products as p
inner join dbo.Categories as c on c.CategoryID=p.CategoryID

select p.ProductID, p.ProductName, c.CategoryName 
from dbo.Products as p
left join dbo.Categories as c on c.CategoryID=p.CategoryID

select p.ProductID, p.ProductName, c.CategoryName 
from dbo.Products as p
right join dbo.Categories as c on c.CategoryID=p.CategoryID


select p.ProductID, p.ProductName, c.CategoryName 
from dbo.Products as p
full outer join dbo.Categories as c on c.CategoryID=p.CategoryID



select p.ProductID, p.ProductName, c.CategoryName, s.CompanyName
from dbo.Products as p
inner join dbo.Categories as c on c.CategoryID=p.CategoryID
left join dbo.Suppliers as s on s.SupplierID=p.SupplierID


--Sipariş Tarihi, Kargo Adresi, Ürünün Adı, Kategorinin Adı, Siparişin Birim Fiyatı, Siparişin Miktarı, Siparişin Tutarı, Personelin Adı

select 
o.OrderDate as 'Sipariş Tarihi', 
o.ShipAddress + ' ' + o.ShipCity + '/' + o.ShipCountry + ' ' + o.ShipPostalCode as [Kargo Adresi],
p.ProductName as [Ürün Adı],
c.CategoryName as [Kategori Adı],
od.UnitPrice as [Birim Fiyat],
od.Quantity as [Miktar],
od.UnitPrice * od.Quantity as Tutar,
e.FirstName + ' ' + e.LastName as [Personel Adı]

from dbo.OrderDetails as od
inner join dbo.Orders as o on o.OrderID=od.OrderID
inner join dbo.Products as p on p.ProductID=od.ProductID
inner join dbo.Categories as c on c.CategoryID=p.CategoryID
inner join dbo.Employees as e on e.EmployeeID=o.EmployeeID