-- Komut yourumu yazmak için kullanılır
-- SQL komutları execute(derleme) edildiği anda işleme alınmaz

-- Select sorgusu bir veritabanı içersininde bulunan tabloların içerisinde kayıtlı olan verileri listelemenizi sağlar

-- Örnek
Select CompanyName from Customers

/*
Bir tablo içerisindeki tüm kolonları listelemek isterseniz * işareti ile sorgulama işlemi yapılabilir
Yanlız zorunlu kalınmadığı taktirde kullanılması gerekmektedir
Büyük çaplı projelerde performans sorunu yaşatabilir
*/

-- Örnek
Select * from Customers

-- Employees tablosu içerisindeki FirstName-LastName-Title kolonlarını listeleyim
Select 
	FirstName,LastName,Title 
from Employees

/*
Where komutu select sorgusu içerisinde filtreleme işlemerini uygulamak için bir komuttur
Where komutu işleminden sonra bir koşul işlemi uygulanır
Koşul uygulama işlemi eslasında karşılaştırma operatörleri ve mantıksal operatörler kullanılır
*/

-- ContactTitle bilgisi Owner olan müşterileri işteyelim
Select 
	CompanyName,
	ContactName,
	ContactTitle 
From Customers 
Where ContactTitle='Owner'

-- Ülkesi mexico veya germany olan müşterileri listeleyeim (customners tablosu) (contry kolonu)
Select 
	ContactName,
	ContactTitle,
	Country 
From Customers 
Where Country='Germany' or Country='Mexico'

-- London şehrinde yaşayan çalışanları listeleyim
Select 
	FirstName,
	LastName,
	City 
From Employees 
Where City='London'

-- Ürün fiyatı 100$ ve üzeri olan ürünleri listeleyelim
Select 
	ProductName,
	SupplierID,
	QuantityPerUnit,
	UnitPrice 
From Products 
Where UnitPrice >= 100

-- Fax bilgisi boş olan müşterileri listeleyelim
Select 
	CompanyName,
	ContactTitle,
	Fax 
From Customers 
Where Fax is null

-- Fax bilgisi boş olmayan müşterileri listeleyelim
Select 
	CompanyName,
	ContactTitle,
	Fax 
From Customers 
Where Fax is not null

/*
Order By komutu sorgulama işlemleri yazıldıktan sonra verileri sırlamanızı sağlayan bir komut sistemidir
Order By komutundan sonra herhanbi klona bağlı kalarak işlem yapcaksanız o klonu belirtmeniz gerekmetedir
Sıralama işlemerli iki şekilde yapılabilir
ASC => küçükten büyüğe
DESC => büyükten küçüğe
*/

-- Örnek
select 
	CategoryName 
from Categories 
order by CategoryName asc

-- Ürünüleri fiyat bilgine göre küçükten büyüğe doğru sırayalayım
select 
	ProductName,
	UnitPrice 
from Products 
order by UnitPrice asc

-- Çalışanların ünvan kısaltması ve ad bilgilerine göre küçükten büyüğe sıralayın
select 
	TitleOfCourtesy,
	FirstName 
from Employees 
order by TitleOfCourtesy,FirstName asc

-- Ülkesi Germany olan müşterileri contactnameine göre afacbetic olarak sıralayalım
select 
	ContactName,
	Country 
from Customers 
Where Country='Germany' 
order by ContactName asc

/*
Like komutu where sorgulaması içerisinde belirtilmiş kolonda benzer metin var mı yok mu sorgulaması yapmamızı sağlar
Sorgulama işleminde sadece metinsel değerler kullanılabilir
% operatörü aracılığı ile sorgulama sağlanır
Birkaç farklı sorgulama yöntemi vardır
'a%' => % operatöründen önce metinsel ifade belirtilirse , belirtilen metin ile başlayan sorguları getirir
'%a%' => iki % operatörü arasında metin yazılırsa o metin içerisinde herhangi bir yerde belirtilen metin varsa sorguyu getirir
'%a' => belirtilen metinden önce % operatörü kullanılırsa , belirtilen metin ile biten sorguları getirir
*/

-- Örnek
-- Firma adı a harfi ile başlayan müşterileri listeleyelim
select * 
from Customers
where CompanyName like 'a%'

-- Firma adında market kelimesi geçen müşterileri listeleyelim
select 
	CompanyName,
	ContactName 
from Customers 
where CompanyName like '%market%'

--Ürün adı C ile başlayan ürünleri alfabetik sıra ile listeleyelim
select ProductName 
from Products
where ProductName like 'c%' 
order by ProductName asc

-- Manager ünvanına sahip firma yetkililerini listeleyelim
select 
	Title,
	FirstName 
from Employees 
where Title like '%manager%'

/*
In
Bir sorgu içerisinde bir kolonda birden fazla eşitlik sağlaması yaparak filtreleme işlemi uygulanacak ise in komutunu kullanabiliriz
Sadece where içerisinde kullanılabilir
Sayısal ve metinsel ifadeler için kullanılır
*/

-- Örnek
-- Ülkesi Germany ve Mexico olan müşterileri listeleyelim
Select 
	Country
from Customers
where Country in ('Germany','Mexico')

-- Ünvanı owner ve sales agent olan müşterileri listeleyelim
select 
	CompanyName,
	ContactName,
	ContactTitle 
from Customers
where ContactTitle in ('Owner','Sales Agent')

-- Ülkesi UK , USA ve Brazil olmayan müşterileri listeleyelim
select 
	CompanyName,
	Country 
from Customers
where Country not in ('Uk','usa','brazil')
order by Country

/*
Between
Sql sorgu dili içerisinde tablo içerisindeki bir kolonda aralık belirterek sorgulama yapmak istediğinizde between komutunu kullanırız
Sadece where işleminde sayısal değerler için kullanılır
*/

-- Örnek
-- Fiyatı 30$ ile 50$ arasında olan ürünleri listeleyelim
select 
	ProductName,
	UnitPrice
from Products 
where UnitPrice between 30 and 50 
order by UnitPrice asc

/*
Aggregate Functions (Hazır Fonksiyonlar)
Sql sorgu dili içerisinde tüm programlama dillerinde olduğu gibi hazır fonksiyonlar vardır
Bunlardan en sık kullanılanları örnek ile beraber işleyelim
*/

-- Count
-- Sql içerisinde bir tabloda kolona bağlı olarak o veriden kaç adet veri var ise bilgisini sayısal ifade olarak geri döndürür

-- Örnek
-- Kaç adet müşterim var ?
select count(CustomerID) as Toplam 
from Customers

-- DISTINCT
-- Bir sorgu içerisindeki verileri belirtilen kolon adına göre kendini tekrarlayan veriler var ise bu verileri süzer ve tek veri halinde listeler

-- Örnek
-- Hangi ülkelere ihracat yapıyorum ?
select distinct(Country) 
from Customers

/*
TOP x
Sql sorgusu içerisinde kaç adet veri listelemek istediğimiz belirttiğimiz bir fonksiyondur
Top fonksiyonunda parantez bulunmaz
Top ifadesinden sonra sayı türünden listelemek istediğiniz veri sayısını yazmanız gerekmektedir
Sadece select ifadesi içerisinde kullanılabilir
*/

-- Örnek
-- İlk 5 müşteriyi listeleyelim
Select TOP 5 * 
from Customers

-- Fiyatı en pahalı olan 5 ürünü listeleyelim
select top 5 UnitPrice,ProductName 
from Products
order by UnitPrice desc

-- Kargo ücreti 15'den büyük , fiyatı en ucuz olan 10 siparişi listeleyelim
select top 10 CustomerID,Freight 
from Orders 
where Freight > 15 
order by Freight asc

/*
Sum
Sql sorgusu içerisinde belirtilen sayısal kolonun toplam değerini verir
Geriye ondalıklı değer döndürür
*/

-- Örnek
-- Müşterilerin ödediği toplam kargo ücreti
select sum(Freight) as [Total Freight] 
from Orders

-- Elimde toplam ne kadarlık satış yapmışım
select sum((UnitPrice * Quantity)*(1-Discount)) as TotalOrder
from [Order Details]

/*
AVG
Sorgu içerisinde belirtilen kolonun ortalamasını hesaplar
Sadece sayısal verilerde kullanılır
*/

-- Örnek
-- Ürünlerimin ortalama fiyatı ne kadardır ?
select 
	AVG(UnitPrice) as AveragePrice 
from Products

/*
Max
Sql sorgusu içerisinde balirtilen kolonun maksimum değerini verir
Sadece sayısal kolonlarda kullanılabilir
*/

-- Örnek
-- En pahalı kagro ücreti ne kadardır
select 
	max(Freight) as MaxFreight 
from Orders

/*
Min
Sql sorgu içerisinde belirtilen kolonunn minumum değerini verir
Sadece sayısal kolonlarda kullanılabilir
*/

-- Örnek
-- En ucuz ürün fiyatı ne kadardır
select 
	min(UnitPrice) as MinPrice 
from Products

-- Len
-- Sql sorgusu içerisinde belirtilen kolonun metinsel karakter uzunlugu sayı türünde geri döndürür

-- Örnek
-- 'Merhaba SQL' yazısını karakter uzunlugunu hesaplayalım
select len('Merhaba SQL') as uzunluk

-- En uzun adı olan firmanın karakter sayısı
select 
	max(len(CompanyName)) as EnUzunFrimaAdi 
from Customers

/*
GETDATE()
GETDATE() fonksiyonu şuanki zamanı bize yyyy-MM-dd HH:mm:ss tipinde geri döndürür

YEAR(<kolon>)
YEAR(<kolon>) fonksiyonu içerisinde belirtilmiş olan tarih bilgisinin yıl değerini geriye döndürür
yıl bilgisini yyyy formatında geri döner
*/

-- Örnek
-- 2024-05-07 tarihinin yıl bilgisini geriye döndirelim
select YEAR('2024-05-07')

-- Örnek
select 
	FirstName, 
	LastName, 
	YEAR(HireDate) as HireDate 
from Employees 
order by HireDate asc

-- Örnek
select 
	FirstName, 
	LastName, 
	YEAR(GETDATE())-YEAR(BirthDate) as Age 
from Employees 
order by Age asc

-- Örnek
-- Fiyatı en yüksek olan ürünümün kategori bilgisi nedir
select CategoryName 
from Categories 
where CategoryID = (select top 1 CategoryID from Products order by UnitPrice desc)

-- Ürünlerimi kategori isimleri ile beraber listeleyelim
-- Tablolara takma isim vererek erişim
select 
	p.ProductName, 
	p.UnitPrice, 
	(
	select 
		c.CategoryName 
	from Categories as c 
	where c.CategoryID = p.CategoryID
	) as Categories
from Products as p

-- Örnek
-- Çalışanlarımı rapor vereceği kişiler ile birlikte listeleyelim
select 
	(c.FirstName + ' ' + c.LastName) as FullName,
	(
		select
			(r.FirstName + ' ' + r.LastName) as ReportsTo
		from Employees as r
		where r.EmployeeID = c.ReportsTo
	)
from Employees as c

-- Ürünlerimi Categori adı ve tedarikçi frima isimleri ile beraber listeleyelim
-- (produsts, categories, suppliers tabloları) (catergortyname, productname, companyname)
select
	ProductName,
	(
		select CategoryName
		from Categories
		where Categories.CategoryID = Products.CategoryID
	) as CategoryName,
	(
		select CompanyName
		from Suppliers
		where Suppliers.SupplierID = Products.SupplierID
	) as CompanyName
from Products

/*	
Group By
Sql sorguları içerisinde bir kolona bağlı kalınarak verileri gruplama işlemi yapmamızı sağlar
Genellikle Where ifadesi ile Order By arasında yazılır
Gruplama işlemi yaptığımızda Select ifadesi içerisinde * ile tüm verileri listeleyemezsiniz
Mutlaka gruplanan kolon ismini belirtmeniz gerekmektedir
Diğer kolonları direkt olarak kullanamazsınız
Hazır metodlar ile işlemleri yapıp listeleyebilirsiniz
*/
	
-- Örnek
-- Hangi kategoride kaç adet ürünüm var
select
	(
		select
			Categories.CategoryName
		from Categories
		where Categories.CategoryID = Products.CategoryID
	) as CategoryName,
	COUNT(Products.ProductID) as Amount
from Products
group by Products.CategoryID

-- Hangi ürünümden kaç adet satın alınmış 
-- Ürün adı ve adet bilgisi olarak listeleyelim
-- (Order details , products) 
select 
	(
	 select
		 ProductName
	 from Products
	 where Products.ProductID = od.ProductID
	) as ProductName,
	sum(od.Quantity) as Amount
from [Order Details] as od
group by od.ProductID
order by Amount asc

-- Hangi tedarikçiden kaç çeşit ürün alıyorum
-- Tedarikçi adı ve çeşit adet bilgisi olarak listeleyelim
-- (Products , suppliers) (CompanyName)
select
	(
		select
			Suppliers.CompanyName
		from Suppliers
		where Suppliers.SupplierID = Products.SupplierID
	) as CompanyName,
	count(Products.ProductID) as Amount
from Products
group by Products.SupplierID

-- Hangi ülkede kaç adet müşterim var
-- Ülke adı ve müşteri sayısı olarak listeleyelim
select
	Country,
	count(CustomerID) as Amount
from Customers
group by Country

/*	
Having
Sql sorgusu içerisinde tablolarda bulunan verileri Where ifadesi ile sorgulama işlemini yapabiliyoruz
Fakat Hazır fonksiyonlar aracılığı ile hesaplamış veriler ram üzerinde hesaplanan soyut değerler olduğundan dolayı bu değerleri filtreleme işlemlerini where ifadesi ile yapamıyoruz
Bunun için Having ifadesini kullanıyoruz
İşleyişi Where ifadesi ile birebir aynıdır

Not: Having ifadesi GroupBy ifadesi var ise GroupBy ifadesinden sonra kullanılmalıdır
*/

-- Örnek 
-- Hangi ürünümden toplam kaç adet satın alınmış ? Satılan ürünlerden toplam 500 ve üzeri olanları listeleyelim
select
	(
		select	
		ProductName
		from Products
		where Products.ProductID = [Order Details].ProductID
	),
	sum([Order Details].Quantity) as Amount
from [Order Details]
group by [Order Details].ProductID
having sum([Order Details].Quantity) >=500
order by Amount

-- Örnek 
-- Satış değeri 1500$ ve üzeri olan siparişleri listeleyelim
select
	OrderID,
	sum((Quantity*UnitPrice)*(1-Discount)) as Price
from [Order Details]
group by OrderID
having sum((Quantity*UnitPrice)*(1-Discount)) >=1500
order by Price 

-- CREATE DATABASE
-- Yeni bir database oluşturmak için kullanılan bir komuttur
-- 'CREATE DATABASE' komutundan sonra oluşturmak istediğiniz veritabanı adını değişken tnaımlama kurallarına bağlı kalarak yazmanız gerekmektedir
Create Database Sinif301

-- Use
-- Sql programla dili içerisinde database seçimini yapmak için kullanılırız

-- Create Table
-- Bir veri tabanı üzerinde yeni bir tablo oluşturmak için kullanılır. Kendisine ait () bloğu vardır
-- İçerisinde barındırılacak olan alanlar bu alan içerisinde kolonad, veritip ve özellikleri şeklinde tanımlanır
-- Tablo içerisinde kolon ismi belirtirken yine değişken tanımlama kurallarına uyulması gerekmektedir

-- Kolon => tablo içerisinde oluşturulacak kolonun adı
-- VeriTipi => Kolon içerisinde hangi türden veri barındılıacak ise o veritipi yazılır
-- Özellik => Kolona tanımlanack olan özellikleri tanımlayabiliriz , yazmak zorunda değiliz(Primary Key , Identitiy(n,n))
-- KolonBilgisi=> 'Null' veya 'Not Null' değerinin alabildiği alandır.'Null' belirttiğimiz kolon içerisinde değer girme zorunluluğu yoktur.Herhangi bir bilgi girilmezse default olarak 'Null' değeri kabul edilir
create table Ogrenciler
(
	Id int Primary Key Identity(1,1) Not Null,
	Ad Nvarchar(50) not null,
	Soyad Nvarchar(50) not null,
	Adres Nvarchar(250),
	DogumTarihi datetime,
	Not1 tinyint not null,
	Not2 tinyint

)
select *
from Ogrenciler

-- GO
-- GO ifadesi sql komut satırları içerisinde birden fazla komut satırı var ise her satır arasında kullanılmalıdır
-- GO ifadesi sayesinde bir tablo oluşturma işlemi veya CRUD işlemleri aşamasında bir üstteki satırın yaptığı işlemi tam anlamı ile bitirip daha sonra alt satıra geçmesini sağlar

-- Örnek
-- Stok adında bir database oluşturalım
-- Database içerisinde Kategoriler ,Ürünler adında iki tane tablo olsun
-- Kategoriler (ID(Pk),KategoriAdı,Aciklama)
-- Ürünler (Id(pk), KategoriAdı,UrunAdı,Fiyat,StokMiktarı)
Create Database Stok
Go
Use Stok
Go
Create Table Kategoriler
(
	ID int Primary Key Identity(1,1) not null,
	KategoriAdi nvarchar(25) not null,
	Aciklama nvarchar(255)
)
Go
Create Table Urunler
(
	ID int Primary Key Identity(1,1) not null,
	KategoriAdı Nvarchar(50) not null ,
	UrunAdi nvarchar(50) not null,
	Fiyat money Not null,
	StokMiktari int not null

)

-- Insert
-- Sql sorgu dili içerisinde bir tabloya kayıt ekleme işlemi için kullanılır
-- Insert işlemi 'Into' komutu ile birlikte kullanılır
-- INSERT INTO komutularını yazdıktan sonra işlem yapmak istediğiniz tablonun adı yazılır
-- Sonrasında () parantez içerisinde değer eklemek istediğiniz kolon isimleri yazılır
-- Daha sonra values komutu yazılarak tekrar () parantez içerisinde sırası ile eklemek istediğiniz değerler yazılır
-- NOT: Insert işlemi yapılırken PK bilgisi ve değeri girilmez
Insert into Ogrenciler (Ad , Soyad ,Adres,DogumTarihi,Not1) values ('Ahmet','KAÇAR','Kadıköy','2001-01-01',65)
select * from Ogrenciler

-- INNER JOIN , LEFT JOIN , RIGHT JOIN , FULL JOIN

-- Joinler , birden fazla tabloyu birbirine bağlamak için kullanılan bir yöntemdir
-- Joinler sayesinde ilişkilendirilmiş olan tabloları birbirleri ile bağlayıp sınırsız bir şekilde işlem yapabilirsiniz
-- Tabloları bağlama bir kolonun PK(Primary Key) kolonu ile bir diğer tablonun FK(Foreign Key) kolonu birbirleriyle ilişkilendirimiş ise sağlanabilir
-- Bu eşleştirme işlemine Diagram tablosundan ulaşabilirsiniz

-- Inner Join
-- Tabloda birleştirdiğimiz alana göre sadece eşleşen verileri getirir

-- Left Join
-- Join ifadesinin solunda kalan tablodaki tüm veriler , diğer tablodanun ise sadece ilgili alanlarını getirir.Diğer tablo eşleşmiyor ise NULL sonucu gelir

-- Right Join
-- Left join mantığında çalışır . 2.Tablodanun tüm verilerini getirir 1.tablonun eşleşen kısımları gelir

-- Full Join
-- Her iki tabloda da tüm kayıtlar gelir.Eşleşmeyen kayıtlar var ise NULL gelir

-- Örnek
-- Ürünlerimi kategori isimleriyle beraber listeleyelim
-- (Categories tablosu , Products Tablosu)
select
	ProductName,
	Categories.CategoryName
from Products inner join Categories on Products.CategoryID=Categories.CategoryID

-- Çalışanlarım ne kadarlık satış yapmış
-- (employees , orders , order details)
-- (Çalışan ad soyad , kazanç)
select
	(Employees.FirstName + ' ' +Employees.LastName) as FullName ,
	Sum((od.Quantity *od.UnitPrice) * (1-od.Discount)) as TotalPrice
from Employees 
  inner join Orders on Employees.EmployeeID=Orders.EmployeeID
  inner join [Order Details] as od on od.OrderID=Orders.OrderID
  group by Employees.FirstName + ' ' +Employees.LastName

-- Hangi kategoride kaç tane ürün satmışım
-- (Categories , products , order details)
select
	CategoryName,
	Sum(Quantity) as Amount
from Categories
  inner join Products on Categories.CategoryID =Products.CategoryID
  inner join [Order Details] as od on od.ProductID =Products.ProductID
  group by CategoryName
  order by Amount

-- Datediff
-- Tarih bilgisine bağlı olarak iki tarih arasındaki farkı bulmanızı sağlar
-- Bu fonksiyonu kullanmak için 3 farklı parametreye ihtiyacınız vardır
-- 1.Parametre => Tarih bilgisinin hangi kısmına bağlı kalarak hesaplama işlemi yapacağınızı belirtmeniz gerekir (Day,Month,Year)
-- 2.Parametre =>Önce gelen tarih bilgisi
-- 3.Parametre =>Sonra gelen tarih bilgisi

-- Örnek
-- İki tarih arasındaki farkı gün , ay , yıl şeklinde hesaplayalım
-- Tarihler '2013-03-18' ile '2024-05-16' 
Select DATEDIFF(Day,'2013-03-18','2024-05-16') as [Gün Farkı]
Select DATEDIFF(Month,'2013-03-18','2024-05-16') as [Ay Farkı]
Select DATEDIFF(Year,'2013-03-18','2024-05-16') as [Yıl Farkı]

-- DELETE
-- Bir tablodaki bir veya birden fazla satırı silmek için kullanılan bir komuttur
-- Silme işlemi yaparken UPDATE işleminde olduğu gibi filtreleme işlemi yapmaya özen gösteriniz
-- Aksi takdirde elinizdeki tüm verileri kaybedebilirsiniz

-- Örnek
-- Öğrenciler tablosunda Primary Key kolon bilgisi  2 olan öğrenciyi silelim
Select * From Ogrenciler
Delete Ogrenciler where Id=2

-- Update
-- Bir tablodaki veya birden fazla satırı güncelleme işlemi yapmak için kullandığımız komuttur
-- Update komutunu kullanırken dikkatli olunması gerekmektedir
-- Aksi takdirde tablo içerisindeki tüm kayıtları update edebiliriz.Mevcut kayıtları kaybedebiliriz
-- Update işlemi yapılırken mutlaka Where ifadesi ile filtreleme yapınız.Bu sayede güncellemek istediğiniz satır veya satırlara nokta atışı şekinde ulaşabilirsiniz
Use Sinif301
Go
Select * from Ogrenciler
Update Ogrenciler
Set Adres='Bakırköy'
where Ad='Ahmet' and Soyad='Kaçar'

-- Değişkenler
-- Değişken en basit tanımı ile bir verinin saklanmasında kullanılan yapıdır
-- Değişkenler sql sorgu dili içerisinde declare ifadesi ile tanımlanır
-- Declare ifadesiniden sonra @ işareti eklenerek değişken adı yazılır ve sonra içerisinde barındıracağı veri tipi belirtilir
-- Değişken isminin önüne @ işareti mutlaka eklemeniz gerekmektedir

-- Örnek
Declare @sayi int
Declare @ad nvarchar(15)
Declare @soyad nvarchar(25)
Declare @n1 int , @n2 int ,@ortalama float

-- Değikenlere Değer atama
-- 'Set' veya 'Select' ifadesi kullanılarak değikenlere değer ataması yapılır
Set @n1=60
set @n2=55

-- Print()
-- Sql sorgu dili içerisinde ekrana bir değer yazdırmak için Print() fonksiyonu kullanılırız
-- () parantez içerisine bir değer veya değişken belirttiğimizde o değer ekrana yazdırılır
Print(@n1)
Print(@n2)
set @ortalama =(@n1 + @n2)/2
Print(@ortalama)

-- Select ifadesi ile değişkene değer atama işlemi

-- Örnek
-- En pahalı ürünün fiyatını @EnPahali değişkeni içerisine aktarıp ekrana yazdıralım
Use NORTHWND
Go
Declare @EnPahali money
Select
	Top 1 @EnPahali = UnitPrice
	From Products
	Order By UnitPrice Desc

select * from Products where UnitPrice=@EnPahali
Print(@EnPahali)

-- Exists
-- Sql sorguları içerisinde belirtilen sorgu cümlesi sonucunha herhangi bir değer var mı sorusunu sorar
-- Geriye 'bit' tipinde değer döndürür(0,1)

-- Örnek
-- Müşterimin içerisinde Turkiye ülkesine ait müşteri var mı?
declare @country nvarchar(50)
set @country='Germany'
if exists(select * from Customers where Country=@country)
	begin
		Select * from Customers where Country=@country
	end
else
	begin
		Print(@country + ' ülkesi bulunamadı')
	end

-- If-Else
-- Sql dilinde if-else yapısı belli bir koşula baplı kalarak sorgularınızı koşula bağlı olarak yönlendirmenizi sağlar
-- İşlenecek komut satırları begin-end komutları içerisinde yazılır

-- Örnek
-- Tanımlanan 2 değişken içerisindeki sayıların hangisi büyük onu bulalım
Declare @sayi1 int ,@sayi2 int
Set @sayi1=15
set @sayi2=30

if(@sayi1 >@sayi2)
	begin
		print('Sayı 1 Büyüktür')
	end
else if (@sayi2 > @sayi1)
	begin
		print('Sayı 2 Büyüktür')
	end
else
	begin
		Print('Sayılar Eşittir')
	end

-- Ürünlerimin ortalama fiyatı 30$ dan düşükse 'Düşük Fiyat' değilse 'Yüksek Fiyat' diye ekrana yazı yazdıralım
Declare @ortalama money
select 
	@ortalama =avg(UnitPrice)
from Products

if(@ortalama > 30)
	begin
		Print('Yüksek Fiyat')
	end
else
	begin
		Print('Düşük Fiyat')
	end

-- While
-- Sql sorgu dilinde , C# programlama dilinde de olduğu gibi koşula bağlı olarak bazı sql sorgu komutlarını tekrarlatabilirsiniz
-- While mekanizması koşul sonucu doğruluğu sağladığı sürece içerisinde kod bloğunu işleme alır

-- Örnek
-- 10'dan geriye doğru yazdıran bir while döngüsü yazalım
declare @sayi int
set @sayi=10
while(@sayi >0)
begin
	print(@sayi)
	set @sayi =@sayi-1
end

-- BREAK => break komutu döngü mekanizmasını sonlandırmak için kullanılır
declare @sayac int
set @sayac=1
while(@sayac <10)
begin
	Print(@sayac)
	if(@sayac=5)
	begin
			break
	end
	set @sayac=@sayac+1
end

-- Switch-Case
-- Sql sorguları içerisinde switch-case mekanizmları ile karşılaştırma işlemleri yapabilirsiniz
-- Switch-case mekanizmasını tek başına kullanabildiğiniz gibi 'Select' sorguları içerisinde de kullanabilirsiniz
-- c# programlama dilinde olduğu gibi birebir eşitlik sağlamak zorunda değilsiniz .Komplike sorgular oluşturabilirsiniz ( < , > , >=, ....)

-- Örnek
-- @Not isminde bir değişken tanımlayalım . Not içerisindeki değere göre 100'lük sisteme göre aldığı notu ekrana yazdıralım
declare @not int
set @not=70

Select 
case
	when @not <45 then
		'Not : 1'
	when @not <55 then
		'Not : 2'
	when @not <70 then
		'Not : 3'
	when @not <80 then
		'Not : 4'
	else
		'Not : 5'
	End as NotBilgisi

-- Örnek 
-- Çalışanlarım içerisinde 1992 yılında işe girenler 'Çok Eski Çalışan',1993 yılında işe girenlere 'Eski Çalışan',1994 yılında işe girenlere 'Yeni Çalışan' bilgileri ile çalışanları listeleyelim
-- (Çalışan adı soyadı ,ünvanı, işe giriş tarihi , çalışan türü)
select
	(FirstName + ' '+LastName) as FuullName,
	Title,
	HireDate,
	(
	 case
		when YEAR(HireDate) = 1992 Then
			'Çok Eski Çalışan'
		when Year(HireDate) = 1993 Then
			'Eski Çalışan'
		else
			'Yeni Çalışan'
		End
	) as EmployeeType
from Employees

-- Örnek
-- Ürünlerim içerisinde stok miktarı 20'nin altında olan ürünlere 'Stok Bitmek Üzere' , 50 nin altında olanlara 'Stokları Gözden Geçiriniz' ,diğerlerine ise 'Stokta sorun yok' bilgilerinin yazdığı bir kolon ile ürünleri stok miktarına göre listeleyelim
-- (Kategori adı , tedarikçi adı , ürün adı , stok miktarı , stok bilgisi)
-- (Products , categories , suppliers)
select
	Categories.CategoryName,
	Suppliers.CompanyName,
	ProductName,
	UnitsInStock,
	(
		case
			when UnitsInStock <20 then	'Stok Bitmek Üzere'
			when UnitsInStock <50 then  'Stokları Gözden Geçir'
			else 'Stokta Sorun Yok'
			end	
	) as UnitInStockInfo
from Products 
inner join Categories on Categories.CategoryID=Products.CategoryID
inner join Suppliers on Products.SupplierID = Suppliers.SupplierID
order by Products.UnitsInStock

-- View
-- View lar sorguları basitleştirmek , erişim izinlerini düzenlemek , farklı sunuculardaki eşdeğer verileri karşılaştırmak veya  bazı durumlar sorgu süresini kısaltmak için kullanılan , gerçekte olmayan select ifadeleri için tanımlanmış olan sanal tablolardır

-- 3 farklı kullanımı vardır
-- Create View
-- Alter View
-- Delete View

-- Order By Kullanılmaz
-- İsimsiz kolon bırakılmaz
-- SubQuery yöntemi ile sorgulama işlemi yapılmaz
-- Insert , Update ve Delete işlemi kullanamazsınız
-- Herhangi bir parametre yollayamazsınız

-- 1 -Create View
--Yeni bir sanal tablo oluşturmak için kullanılır

--Örnek
--Alman müşterileri getiren bir View oluşturalım
Use NORTHWND
GO
Create view AlmanMusteriler as
select * from Customers Where Country='Germany'

-- Oluşturduğumuz View'ları Database içerisindeki View klasörü altında listeleyebiliriz
-- Oluşturulan Ciewları select etmek için standar select işlemi kullanılır
Select * From AlmanMusteriler
	
-- Oluşturduğumuz View içerisinde ünvanı yönetici olanları listeleyelim
Select
	CompanyName,ContactName,ContactTitle
from AlmanMusteriler
	Where ContactTitle like '%manager%'
	order by ContactName asc


-- Alter View
-- Oluşturulan tablo içerisindeki sql sorgusunu değiştirmek için kullanılır

-- Örnek
-- Alman Müşterileri view tablosunu güncelleyelim
alter view AlmanMusteriler
as
	select
	CustomerID,CompanyName,ContactName,ContactTitle,Country
	from Customers
	Where Country='Germany'
		
Select * From AlmanMusteriler

-- 3-Drop View
-- Mevcut View ı silmek için kullanılır

Drop view AlmanMusteriler

-- Örnek
-- Ürün adı , Ürün Stok Bilgisi, Ürün Fiyatı , Kategori Adı ve Tedarikçi adını listeleyen bir view oluşturalım ve çağıralım
create view Urunler
as	
Select
	Products.ProductName,
	Products.UnitsInStock,
	Products.UnitPrice,
	Categories.CategoryName,
	Suppliers.CompanyName
from Products
Inner Join Categories on Products.CategoryID=Categories.CategoryID
Inner Join Suppliers on Products.SupplierID=Suppliers.SupplierID
Select * From Urunler
