--select


select * from Customers where City='Berlin'


select  * from Products where CategoryID=1 or CategoryID=3

select  * from Products where CategoryID=1 and UnitPrice>10


select * from Products where CategoryID=1 order by UnitPrice asc


select count (*) from Products where CategoryID=2


select categoryID, count(*) from products where UnitPrice>20
 group by CategoryID having count(*)<10



select Products.ProductID, Products.ProductName, Products.UnitPrice,
Categories.CategoryName
from  Products inner join Categories 
on  Products.CategoryID=Categories.CategoryID

---DTO Data Transformation Object

select * from  Products p left join [Order Details] od
 on p.ProductID=od.ProductID

select * from Customers c left join Orders o 
on c.CustomerID=o.CustomerID

where o.CustomerID is null 