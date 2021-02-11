-- Select ten sonraki yıldız tüm kolonları seçme anlamındadır. Spesifik bir şey yazarsak o kolonlar gelir.
--Select ContactName,CompanyName,City from Customers 
-- ANSII Standarts
Select ContactName Adi,CompanyName Şirket,City Şehir from Customers 

-- şehri London olan tüm kolonları seç 
-- Case insensitive büyük küçük farketmez
Select * from Customers where City = 'London'

sEleCt * from Products where CategoryID = 1 or CategoryID = 4

sEleCt * from Products where CategoryID = 1 and UnitPrice >= 10

sEleCt * from Products order by UnitPrice desc --ascending --descending

select count(*) from Products where CategoryID = 2


-- Products içindeki kategory Id leri tekrar etmeyecek şekild grupla. count yardımı ile say

--Fiyatı 20 den fazla olan ürünleri CategoryId ye göre grupla ve onlardan 10 dan az olanları yapıştır
--Having cumulative lerde kullanılır
select categoryID,count(*) from Products where UnitPrice > 20 group by CategoryID having COUNT(*) < 10


-- Products ve categories tablolarını birleştir ve Id ler eşit olduğunda == on bastır
select Products.ProductID, Products.ProductID, Products.UnitPrice, Categories.CategoryID
from Products p inner join Categories c 
on Products.ProductID = Categories.CategoryID
inner join Orders on OrderID = CategoryID
-- inner join iki tabloda eşleşen dataları getirir.
-- DTO data transformation obect joinler c# ile ilişkilendirme


-- Hiç satılmayan ürünleri listele de indirim yapıp elimizden çıkarak
-- inner jon eşleşenleri, left join SOLDA OLUP SAĞDA OLMAYANLARI DA GETİR.
-- Ürünlerde olup satış detayında olmayan satılmamış üründür
select * from Products p left join [Order Details] od 
on p.ProductID = od.ProductID


-- Solda olan ve sağda olanları da listele ancak datası olmayanları
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null


select p.ProductName as 'UrunAdi', sum(od.Quantity * od.UnitPrice) as 'ToplamKazanc' from Products p 
inner join [Order Details] od on od.ProductID = p.ProductID inner join Orders o on o.OrderID = od.OrderID group by p.ProductName