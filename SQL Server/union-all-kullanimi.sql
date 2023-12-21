select 'Customer' as RecordType, CompanyName, Country from dbo.Customers
union all
select 'Supplier' as RecordTypeyy, CompanyName, Country from dbo.Suppliers



select 'Customer' as RecordType, CompanyName, Country from dbo.Customers where Country='Germany'
union all
select 'Supplier' as RecordTypeyy, CompanyName, Country from dbo.Suppliers where Country='Germany'
union all
select 'Hiçbiri' as RecordType, '', ''


select RecordType, CompanyName, Country from (select 'Customer' as RecordType, CompanyName, Country from dbo.Customers
union all
select 'Supplier' as RecordTypeyy, CompanyName, Country from dbo.Suppliers) as tumKayitlar
where Country='Germany'
order by CompanyName