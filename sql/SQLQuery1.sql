-- Komut yourumu yazmak için kullanılır
-- SQL komutları execute(derleme) edildiği anda işleme alınmaz

-- Select
-- Select sorgusu bir veritabanı içersininde bulunan tabloların içerisinde kayıtlı olan verileri listelemenizi sağlar

-- Syntax
-- Select <KolonAdı / KolonAdlari> Form <Tablo>

-- Örnek
-- Select CompanyName from Customers

-- Bir tablo içerisindeki tüm kolonları listelemek isterseniz * işareti ile sorgulama işlemi yapılabilir
-- Yanlız zorunlu kalınmadığı taktirde kullanılması gerekmektedir
-- Büyük çaplı projelerde performans sorunu yaşatabilir

-- Örnek
-- Select * from Customers

-- Employees tablosu içerisindeki FirstName-LastName-Title kolonlarını listeleyim
-- Select FirstName,LastName,Title from Employees

-- Where
-- Where komutu select sorgusu içerisinde filtreleme işlemerini uygulamak için bir komuttur
-- Where komutu işleminden sonra bir koşul işlemi uygulanır
-- Koşul uygulama işlemi eslasında karşılaştırma operatörleri ve mantıksal operatörler kullanılır

-- Syntax
-- Select <Kolon> From <Tablo> Where <Koşul>

-- ContactTitle bilgisi Owner olan müşterileri işteyelim
-- Select CompanyName,ContactName,ContactTitle From Customers Where ContactTitle='Owner'

-- Ülkesi mexico veya germany olan müşterileri listeleyeim (customners tablosu) (contry kolonu)
-- Select ContactName,ContactTitle,Country From Customers Where Country='Germany' or Country='Mexico'

-- London şehrinde yaşayan çalışanları listeleyim
-- Select FirstName,LastName,City From Employees Where City='London'

-- Ürün fiyatı 100$ ve üzeri olan ürünleri listeleyelim
-- Select ProductName,SupplierID,QuantityPerUnit,UnitPrice From Products Where UnitPrice >= 100

-- Fax bilgisi boş olan müşterileri listeleyelim
-- Select CompanyName,ContactTitle,Fax From Customers Where Fax is null

-- Fax bilgisi boş olmayan müşterileri listeleyelim
-- Select CompanyName,ContactTitle,Fax From Customers Where Fax is not null

-- Order By
-- Order By komutu sorgulama işlemleri yazıldıktan sonra verileri sırlamanızı sağlayan bir komut sistemidir
-- Order By komutundan sonra herhanbi klona bağlı kalarak işlem yapcaksanız o klonu belirtmeniz gerekmetedir
-- Sıralama işlemerli iki şekilde yapılabilir
-- ASC => küçükten büyüğe
-- DESC => büyükten küçüğe

-- Örnek
-- select CategoryName from Categories order by CategoryName asc

-- Ürünüleri fiyat bilgine göre küçükten büyüğe doğru sırayalayım
-- select ProductName,UnitPrice from Products order by UnitPrice asc

-- Çalışanların ünvan kısaltması ve ad bilgilerine göre küçükten büyüğe sıralayın
-- select TitleOfCourtesy,FirstName from Employees order by TitleOfCourtesy,FirstName asc

-- Ülkesi Germany olan müşterileri contactnameine göre afacbetic olarak sıralayalım
-- select ContactName,Country from Customers Where Country='Germany' order by ContactName asc

/*
Like komutu where sorgulaması içerisinde belirtilmiş kolonda benzer metin var mı yok mu sorgulaması yapmamızı sağlar
Sorgulama işleminde sadece metinsel değerler kullanılabilir
% operatörü aracılığı ile sorgulama sağlanır
Birkaç farklı sorgulama yöntemi vardır
'a%' => % operatöründen önce metinsel ifade belirtilirse , belirtilen metin ile başlayan sorguları getirir
'%a%' => iki % operatörü arasında metin yazılırsa o metin içerisinde herhangi bir yerde belirtilen metin varsa sorguyu getirir
'%a' => belirtilen metinden önce % operatörü kullanılırsa , belirtilen metin ile biten sorguları getirir
*/

-- Syntax
-- Select <Kolon'lar> From <Tablo> Where <kolon> like <sorgu>

-- Örnek
-- Firma adı a harfi ile başlayan müşterileri listeleyelim
-- select * from Customers where CompanyName like 'a%'

-- Firma adında market kelimesi geçen müşterileri listeleyelim
-- select CompanyName,ContactName from Customers where CompanyName like '%market%'

--Ürün adı C ile başlayan ürünleri alfabetik sıra ile listeleyelim
-- select ProductName from Products where ProductName like 'c%' order by ProductName asc

-- Manager ünvanına sahip firma yetkililerini listeleyelim
-- select Title,FirstName from Employees where Title like '%manager%'

/*
In
Bir sorgu içerisinde bir kolonda birden fazla eşitlik sağlaması yaparak filtreleme işlemi uygulanacak ise in komutunu kullanabiliriz
Sadece where içerisinde kullanılabilir
Sayısal ve metinsel ifadeler için kullanılır
*/

-- Syntax
-- Select <Kolon'lar> From<Tablo> Where <kolon> in (değer1,değer2,değer3,....)

-- Örnek
-- Ülkesi Germany ve Mexico olan müşterileri listeleyelim
-- Select Country from Customers where Country in ('Germany','Mexico')

-- Ünvanı owner ve sales agent olan müşterileri listeleyelim
-- select CompanyName,ContactName,ContactTitle from Customers where ContactTitle in ('Owner','Sales Agent')

-- Ülkesi UK , USA ve Brazil olmayan müşterileri listeleyelim
-- select CompanyName,Country from Customers where Country not in ('Uk','usa','brazil') order by Country

-- Between
-- Sql sorgu dili içerisinde tablo içerisindeki bir kolonda aralık belirterek sorgulama yapmak istediğinizde between komutunu kullanırız
-- Sadece where işleminde sayısal değerler için kullanılır

-- Syntax
-- Select <Kolon'lar> From <Tablo> where <kolon> between <deger1> and <deger2>

-- Örnek
-- Fiyatı 30$ ile 50$ arasında olan ürünleri listeleyelim
-- select ProductName,UnitPrice from Products where UnitPrice between 30 and 50 order by UnitPrice asc

-- Aggregate Functions (Hazır Fonksiyonlar)
-- Sql sorgu dili içerisinde tüm programlama dillerinde olduğu gibi hazır fonksiyonlar vardır
-- Bunlardan en sık kullanılanları örnek ile beraber işleyelim

-- Count
-- Sql içerisinde bir tabloda kolona bağlı olarak o veriden kaç adet veri var ise bilgisini sayısal ifade olarak geri döndürür

-- Syntax
-- Select Count(<kolon>) from <tablo>

-- Örnek
-- Kaç adet müşterim var ?
-- select count(CustomerID) as Toplam from Customers

-- DISTINCT
-- Bir sorgu içerisindeki verileri belirtilen kolon adına göre kendini tekrarlayan veriler var ise bu verileri süzer ve tek veri halinde listeler

-- Syntax
-- Select Distinct(<kolon>) from <tablo>

-- Örnek
-- Hangi ülkelere ihracat yapıyorum ?
-- select distinct(Country) from Customers

/*
TOP x
Sql sorgusu içerisinde kaç adet veri listelemek istediğimiz belirttiğimiz bir fonksiyondur
Top fonksiyonunda parantez bulunmaz
Top ifadesinden sonra sayı türünden listelemek istediğiniz veri sayısını yazmanız gerekmektedir
Sadece select ifadesi içerisinde kullanılabilir
*/

-- Syntax
-- Select TOP <x> from <Tablo>

-- Örnek
-- İlk 5 müşteriyi listeleyelim
-- Select TOP 5 * from Customers

-- Fiyatı en pahalı olan 5 ürünü listeleyelim
-- select top 5 UnitPrice,ProductName from Products
-- order by UnitPrice desc

-- Kargo ücreti 15'den büyük , fiyatı en ucuz olan 10 siparişi listeleyelim
-- select top 10 CustomerID,Freight from Orders where Freight > 15 order by Freight asc

-- Sum
-- Sql sorgusu içerisinde belirtilen sayısal kolonun toplam değerini verir
-- Geriye ondalıklı değer döndürür

-- Syntax
-- Select SUM(<kolon>) from <tablo>

-- Örnek
-- Müşterilerin ödediği toplam kargo ücreti
-- select sum(Freight) as [Total Freight] from Orders

-- Elimde toplam ne kadarlık satış yapmışım
-- select sum((UnitPrice * Quantity)*(1-Discount)) as TotalOrder from [Order Details]

-- AVG
-- Sorgu içerisinde belirtilen kolonun ortalamasını hesaplar
-- Sadece sayısal verilerde kullanılır

-- Syntax
-- Select AVG(<Kolon>) from <tablo>

-- Örnek
-- Ürünlerimin ortalama fiyatı ne kadardır ?
-- select AVG(UnitPrice) as AveragePrice from Products

-- Max
-- Sql sorgusu içerisinde balirtilen kolonun maksimum değerini verir
-- Sadece sayısal kolonlarda kullanılabilir

-- Syntax
-- Select Max(<kolon>) from <tablo>

-- Örnek
-- En pahalı kagro ücreti ne kadardır
-- select max(Freight) as MaxFreight from Orders

-- Min
-- Sql sorgu içerisinde belirtilen kolonunn minumum değerini verir
-- Sadece sayısal kolonlarda kullanılabilir

-- Syntax
-- Select Min(<kolon>) from <tablo>

-- Örnek
-- En ucuz ürün fiyatı ne kadardır
-- select min(UnitPrice) as MinPrice from Products

-- Len
-- Sql sorgusu içerisinde belirtilen kolonun metinsel karakter uzunlugu sayı türünde geri döndürür

-- Örnek
-- 'Merhaba SQL' yazısını karakter uzunlugunu hesaplayalım
-- select len('Merhaba SQL') as uzunluk

-- En uzun adı olan firmanın karakter sayısı
-- select max(len(CompanyName)) as EnUzunFrimaAdi from Customers

-- GETDATE()
-- GETDATE() fonksiyonu şuanki zamanı bize yyyy-MM-dd HH:mm:ss tipinde geri döndürür

-- YEAR(<kolon>)
-- YEAR(<kolon>) fonksiyonu içerisinde belirtilmiş olan tarih bilgisinin yıl değerini geriye döndürür
-- yıl bilgisini yyyy formatında geri döner

-- Örnek
-- 2024-05-07 tarihinin yıl bilgisini geriye döndirelim
-- select YEAR('2024-05-07')

-- Örnek
/*
select 
	FirstName, 
	LastName, 
	YEAR(HireDate) as HireDate 
from Employees 
order by HireDate asc
*/

-- Örnek
/*
select 
	FirstName, 
	LastName, 
	YEAR(GETDATE())-YEAR(BirthDate) as Age 
from Employees 
order by Age asc
*/

-- Örnek
-- Fiyatı en yüksek olan ürünümün kategori bilgisi nedir
/*
select CategoryName 
from Categories 
where CategoryID = (select top 1 CategoryID from Products order by UnitPrice desc)
*/

-- Ürünlerimi kategori isimleri ile beraber listeleyelim
-- Tablolara takma isim vererek erişim
/*
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
*/
