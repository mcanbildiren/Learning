--select
--ANSII
Select ContactName,CompanyName,City from Customers

Select * from Customers where City = 'Berlin'

select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc -- descending , asc ascending

select count(*) Adet from Products 

select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO data transformation object ^

select * from Products p inner join [Order Details] od --[] is for name errors
on p.ProductID = od.ProductID -- inner join only brings matching data

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID -- have it on left side but not on right + matching data

select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null --customers that didn't buy 

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID -- combining multiple joins