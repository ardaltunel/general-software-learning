using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ogren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region WriteLine
            // WriteLine yanına yazar
            /*
            Console.WriteLine("merhaba ben writeline");
            */
            #endregion

            #region Write
            // Write alt satıra yazar
            /*
            Console.Write("merhaba ben write ");
            Console.Write("bende write iki");
            */
            #endregion

            #region ReadKey
            // ReadKey bir tuşa basıldığında kodu okumaya devam eder
            /*
            Console.ReadKey();
            */
            #endregion

            #region ReadKey Enter
            // ReadKey sadece enter basıldığında kodu okumaya devam eder
            /*
            Console.WriteLine("Enter bas");
            while (Console.ReadKey().Key != ConsoleKey.Enter){
                Console.WriteLine(" olmaz enter basman lazım!");
            }
            Console.WriteLine("Enter bastın");
            */
            #endregion

            #region Değişkenler
            // değişken türlerine "c sharp için değişkenler" diye aratırsan tümünü görebilirsin
            // char ile charOrnek oluşturuk sonra değeri değiştirdik
            // tek tırnak arasında yazılması lazım ('a')
            // yorum satırına alınsın diye çif tırnak içine aldım ("a")
            /*
            char charOrnek = "a";
            Console.WriteLine(charOrnek);
            Console.ReadKey();
            Console.Clear();
            charOrnek = "b";
            Console.WriteLine(charOrnek);
            
            string ad;
            string soyad, sehir;
            ad = "Arda";
            soyad = "Altunel";
            sehir = "Artvin";
            Console.WriteLine("Ad = " + ad);
            Console.WriteLine("Soyad = " + soyad);
            Console.WriteLine("Şehir = " + sehir);
            
            int sayi1 = 10;
            Console.WriteLine("int veritipi = " + sayi1);
            
            double sayi2 = 20;
            double sayi3 = 30.4;
            Console.WriteLine("1. double veritipi = " + sayi2);
            Console.WriteLine("2. double veritipi = " + sayi3);
            
            bool deger = true;
            bool deger2 = false;
            Console.WriteLine("1. bool = " + deger);
            Console.WriteLine("2. bool = " + deger2);
            Console.WriteLine(2 + 2 == 5);
            Console.WriteLine(2 + 2 == 4);
            
            object obj1 = "Object";
            object obj2 = 20;

            var var1 = "Var";
            var var2 = 30;
            */
            #endregion

            #region Örnek (2 sayı oluştur bu sayıları topla)
            // 2 adet sayı oluştur bu sayıları topla
            /*
            int toplaSayi1 = 5, toplaSayi2 = 10;
            int sonuc;
            sonuc = toplaSayi1 + toplaSayi2;
            Console.WriteLine("Sonuç = " + sonuc);
            */
            #endregion

            #region Örnek (doğum yılı yıl değeri ad soyad değişkenleri oluşturup atamalarını yapalım)
            // doğum yılı yıl değeri ad soyad değişkenleri oluşturup atamalarını yapalım
            /*
            int guncelYil = 2024, dogumYil = 2004;
            int yas = guncelYil - dogumYil;
            string ad = "Arda", soyad = "Altunel";
            Console.WriteLine("Merhaba benim adım " + ad + " soyadım " + soyad + " yaşım " + yas);
            */
            #endregion

            #region Region Takibi Kolaylaştır
            // takibi kolaylaştırmak için region kullanabilirsin
            /*
            #region Console.ReadLine Tanımı
            Console.WriteLine("ben Console.ReadLine tanımıyım");
            #endregion
            */
            #endregion

            #region Kullanıcıya Yazdırmak
            // kullanıcıya yazdırmak
            /*
            Console.Write("Adınızı Giriniz: ");
            string ad = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz: ");
            string soyad = Console.ReadLine();
            Console.WriteLine("Senin Adın: " + ad + " " + soyad);
            */
            #endregion

            #region Örnek (kullanıcın yaşadığı şehiri memleketini ve yaşını sorup çıktısını alın)
            // kullanıcın yaşadığı şehiri memleketini ve yaşını sorup çıktısını alın
            /*
            string sehir, memleket, yas;
            Console.Write("Yaşadığınız Şehir: ");
            sehir = Console.ReadLine();
            Console.Write("Memleketin: ");
            memleket = Console.ReadLine();
            Console.Write("Yaşın: ");
            yas = Console.ReadLine();
            Console.WriteLine("Yaşadığınız Şehir: " + sehir + " Memleketin: " + memleket + " Yaşın: " + yas);
            */
            #endregion

            #region Tür Dönüşümleri (bilinçli ve bilinçsiz)
            // tür dönüşümleri (matamatiksel işlemler) 
            // bilinçsiz tür ve dönüştürülecek olan tür olarak 2'ye ayrılır
            /*
            string deger = "50";

            // int'e dönüştür (Convert Bilinçsiz)
            Convert.ToInt32(deger);
            // long'a döndürmek (Convert Bilinçsiz)
            Convert.ToInt64(deger);
            // double'a döndürmek (Convert Bilinçsiz)
            Convert.ToDouble(deger);
            // float'a döndürmek (Convert Bilinçsiz)
            Convert.ToSingle(deger);
            // decimal'a dönüştürmek (Convert Bilinçsiz)
            Convert.ToDecimal(deger);

            // int'e dönüştür (Parse Bilinçsiz)
            int.Parse(deger);
            // long'a dönüştür (Parse Bilinçsiz)
            long.Parse(deger);
            
            // bilinçli dönüştürme
            int sayi1 = 16;
            int sayi2 = 30;
            double sonuc = (double) sayi1 / sayi2;
            Console.WriteLine(sonuc);
            */
            #endregion

            #region Tür Dönüşümleri Örnekleri
            // tür dönüşümü örnekleri
            // 2 deger oluştur ve bu degerleri böl dönüştür sonucu bas
            /*
            string deger1 = "25";
            string deger2 = "30";
            int sayi1 = int.Parse(deger1);
            int sayi2 = int.Parse(deger2);
            double sonuc = (double) sayi2 / sayi1;
            Console.WriteLine("Sonuç: " + sonuc);

            // kullanıcıdan 2 sayı al ve toplamını ekrana yaz
            Console.Write("Toplanacak 1. Sayıyı Gir: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("Toplanacak 2. Sayıyı Gir: ");
            int sayi2 = int.Parse(Console.ReadLine());
            int sonuc = (sayi1 + sayi2);
            Console.WriteLine("Toplama Sonucunuz: " + sonuc);

            // kullanıcıdan 3 adet sayı isteyelim 3 adet sayının ortalamasını ekrana yazdır
            Console.Write("1. Sayıyı Gir: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Gir: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("3. Sayıyı Gir: ");
            int sayi3 = int.Parse(Console.ReadLine());
            double sonuc = ((double) (sayi1 + sayi2 + sayi3) / 3);
            Console.WriteLine("Sayıların Ortalaması: " + sonuc);
            */
            #endregion

            #region If Else - Else If
            // if else = else if
            // karar verme veya koşul oluşturmak
            // belirttiğim koşul yerine geliyorsa şunları gelmiyorsa bunları yap demektir
            /*
            if (true) // parantez içine koşul belirtilir
            {
                // koşul ture ise buradaki komut satırları işleme alınır
            }

            else if (true) // parantez içine koşul belirtilir
            {
                // koşul ture ise buradaki komut satırları işleme alınır
            }
            
            else // koşul belirtilmez
            {
                // koşullar uyuşmuyor ise buradaki komut satırları işleme alınır
            }

            // örnek
            int sayi1 = 3, sayi2 = 5;
            if (sayi1 > sayi2) {
                Console.WriteLine("1. Sayı Büyüktür");
            } else if (sayi1 < sayi2) {
                Console.WriteLine("1. Sayi Küçüktür");
            } else {
                Console.WriteLine("Sayılar Eşittir");
            }

            // 1 sayı talep edin tek ise sayı tektir çift ise sayı çift olarak konsola yazsın
            Console.Write("Bir Sayı Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi % 2 == 0) {
                Console.WriteLine("Girilen Sayı Çifttir");
            } else if (sayi % 2 == 1) {
                Console.WriteLine("Girilen Sayı Tektir");
            } else {
                Console.WriteLine("Beklenmedik Bir Hata Oldu");
            }

            // kullanıcıdan 2 sayı isteyelim girilen sayıların toplamı 3'e tam bölünüyorsa tam bölünüyor yazacak
            Console.WriteLine("Lütfen 2 sayı giriniz");
            Console.Write("İlk Sayı: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayı: ");
            int sayi2 = int.Parse(Console.ReadLine());
            if ((sayi1 + sayi2) % 3 == 0) {
                Console.WriteLine("Tam Bölünüyor");
            } else if (toplam % 3 == 1 || toplam % 3 == 2){
                Console.WriteLine("Tam Bölünmüyor");
            }

            // kullanıcıdan 3 sayı alın sayıların ortalaması 50 veya üzeri ise geçti kaldı ise kaldı mesajını döndürün
            Console.WriteLine("Lütfen 3 sayı giriniz");
            Console.Write("İlk Sayı: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayı: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("Üçüncü Sayı: ");
            int sayi3 = int.Parse(Console.ReadLine());
            double sonuc = (double) sayi1 + sayi2 + sayi3;
            if (sonuc / 3 >= 50)
            {
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }
            */
            #endregion

            #region While Döngüsü
            // while program içerisinde bazı durumlarda belilri komut satırlarını defalarca kez kullanmak isteyebiliriz
            // bu gibi durumlarda döngü mekanizmaları devereye girer
            // kaç defa döneci belli olmayan durumlarda kullanılır
            // koşul alanı vardır bu koşul ture olrak dönüyor ise çalışacaktır
            // syntax yazım kuralları
            /*
            while (kosul)
            {
                //komut satırı
            }
            */

            // 1 den 10 a kadar sayıları while ile yazdırıalım
            /*
            int sayac = 1, hedef = 10;
            while (sayac <= hedef)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
            */

            // kullanıcıdan 2 adet sayı telep edeilim
            // 1. sayı ile 2. sayı aradınsaki sayıları ekranı yazdıralım
            /*
            Console.WriteLine("2 Sayı Giriniz");
            Console.Write("İlk Sayı: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayı: ");
            int sayi2 = int.Parse(Console.ReadLine());
            while (sayi1 <= sayi2)
            {
                Console.WriteLine(sayi1);
                sayi1++;
            }
            */

            // 1- 100 arasındaki sayıları 2 ye tam bölüneneleri ekrana yazdıralım
            /*
            int sayi1 = 1, sayi2 = 100;
            while (sayi1 <= sayi2)
            {
                if (sayi1 % 2 == 0) {
                    Console.WriteLine(sayi1);   
                }
                sayi1++;
            }
            */

            // 1 - 100 arasındaki tek sayıların toplamını ekrana yazdır 
            /*
            int sayi1 = 1, sayi2 = 100;
            int toplam = 0;
            while (sayi1 <= sayi2)
            {
                if (sayi1 % 2 == 1)
                {
                    toplam += sayi1;
                    // toplam = toplam + sayi1; (daha kolay yazabilmek için üsttekini kullanıyoruz)
                }
                sayi1++;
            }
            Console.Write("Sayıların Toplamı: " + toplam);
            */
            #endregion

            #region Örnek (1. sayıdan 2. sayıya kadar olan sayıların toplamını ve ortalamasını ekrana yazdırın)
            // kullanıcıdan 2 adet sayı alalım
            // 1. sayıdan 2. sayıya kadar olan sayıların toplamını ve ortalamasını ekrana yazıdıralım
            // bu yapmak için 1. yöntem
            /*
            Console.WriteLine("2 Sayı Giriniz");
            Console.Write("İlk Sayı: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayı: ");
            int sayi2 = int.Parse(Console.ReadLine());
            int toplam = 0;
            int sayac = 0;
            if (sayi1 > sayi2) {
                while (sayi1 >= sayi2) {
                    toplam += sayi2;
                    sayi2++;
                    sayac++;
                }
                double ortalama = (double)toplam / sayac;
                Console.WriteLine("Sayıların Toplamı: " + toplam);
                Console.WriteLine("Sayıların Ortalaması: " + ortalama);
            } else if (sayi1 < sayi2) {
                while (sayi1 <= sayi2) {
                    toplam += sayi1;
                    sayi1++;
                    sayac++;
                }
                double ortalama = (double)toplam / sayac;
                Console.WriteLine("Sayıların Toplamı: " + toplam);
                Console.WriteLine("Sayıların Ortalaması: " + ortalama);
            } else {
                Console.WriteLine("Sayılar Birbirine Eşittir");
            }
            */

            // bu yapmak için 2. yöntem
            /*
            int sayi1, sayi2, toplam = 0, sayac = 0;
            double ortalama;
            Console.WriteLine("2 Sayı Giriniz");
            Console.Write("İlk Sayı: ");
            sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayı: ");
            sayi2 = int.Parse(Console.ReadLine());
            if (sayi1 == sayi2) {
                Console.WriteLine("Sayılar Birbirine Eşittir");
            } else {
                if (sayi1>sayi2) {
                    int gecici = sayi1;
                    sayi1 = sayi2;
                    sayi2 = gecici;
                }

                while (sayi1<sayi2) {
                    toplam += sayi1;
                    sayi1++;
                    sayac++;
                }
                Console.WriteLine("Sayıların Toplamı: " + toplam);
                ortalama = (double) toplam / sayac;
                Console.WriteLine("Sayıların Ortalaması: " + ortalama);
            }
            */
            #endregion

            #region Do While
            // while döngüsü mekanizmasında olduğu gibi koşula bağlıdır
            // ilk önce do içerisindeki komut satırları işlenir
            /*
            do
            {
                // komut satırları
                // koşula bakmadan çalışır
            } while (true);
            */

            // kullanıcıdan 2 sayı isteyelim bu sayıları toplayıp ekrana yazdıralım
            // yeni bir işlem yapmak istiyor musunuz diye soru yöneltelim
            // cevap 'e' ise işlem tekrar etsin
            /*
            char cevap;
            int sayi1, sayi2, toplam;
            do {
                Console.Clear();
                Console.WriteLine("2 Sayı Giriniz");
                Console.Write("İlk Sayı: ");
                sayi1 = int.Parse(Console.ReadLine());
                Console.Write("İkinci Sayı: ");
                sayi2 = int.Parse(Console.ReadLine());
                toplam = sayi1 + sayi2;
                Console.WriteLine("Toplama Sonucu: " + toplam);
                Console.Write("Yeni bir işlem yapmak için 'e' yazınız: ");
                cevap = char.Parse(Console.ReadLine());
            } while (cevap == 'e');
            */

            // kullanıcı adı ve şifre girildikten sonra giriş başarılı denecek
            // bellirtilen kullanıcı adı ve şifre girilmemiş ise giriş yapılamayacak
            /*
            string userName = "arda", password = "1234";
            string userNameGir, passwordGir;
            do {
                Console.Write("Kullanıcı adı: ");
                userNameGir = Console.ReadLine();
                Console.Write("Şifre: ");
                passwordGir = Console.ReadLine();

                if (userNameGir == userName && password == passwordGir) {
                    Console.Write($"Hoşgeldin, {userNameGir} olarak giriş yaptın.");
                } else {
                    Console.WriteLine("Hatalı giriş lütfen tekrar dene\n");
                }
            } while (userNameGir != userName && password != passwordGir);
            */

            // kullancıdan pozitif bir sayı girmesini isteyelim
            // negeatif sayı girene kadar bu işlemi yaptıralım
            // eğer negatif bir sayı girer ise sayı istemeyi bırkalım
            /*
            int sayi1;
            do
            {
                Console.Write("Pozitif bir sayı giriniz: ");
                sayi1 = int.Parse(Console.ReadLine());
                if (sayi1 < 0) {
                    Console.Write("Hata, bu sayı negatif");
                } else {
                    // Console.Write("pozitif");
                }
            } while (sayi1 >= 0);
            */

            // 1 sayı alalım 1 den girmiş olduğu sayıların toplamını yazdıralım
            /*
            int i = 1, toplam = 0;
            Console.Write("Bir Sayı Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            do {
                toplam += i;
                i++;
            } while (i <= sayi);
            Console.WriteLine($"1'den {sayi}'e kadar olan sayıların toplamı: {toplam}");
            */
            #endregion

            #region SwitchCase
            // if-else mekanizamasında olduğu gibi karşılaştırma işlemi yapmanızı sağlayan bir mekanizmadır 
            // yalnız mekanizma içerisinde sadece eşitlik sorgulaması yapılır
            // if-else gibi komplike sorgular yapılmaz
            /*
            switch (switch_on) // deger
            {
                default: // yazılması zorunlu degil else gibi
                    break; // çıkmak için
            }
            */

            // 1-12 arası bir sayı alalım
            // girilen sayıya göre ay bilgisini döndürelim
            /*
            Console.Write("1-12 Arası Bir Sayı Giriniz: ");
            int ay = int.Parse(Console.ReadLine());
            switch (ay)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Ağustos");
                    break;
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Hatalı bir sayı girdiniz");
                    break;
            }
            */

            // 1-12 arası bir sayı isteyelim mevsim bilgisini ekrana yazdıralım
            /*
            Console.Write("1-12 Arası Bir Sayı Giriniz: ");
            int mevsim = int.Parse(Console.ReadLine());
            switch (mevsim)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar");
                    break;
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış");
                    break;
                default:
                    Console.WriteLine("Hatalı bir sayı girdiniz");
                    break;
            }
            */
            #endregion

            #region Random Sınıfı
            // Programımız içerisinde bazı durumlarda rasgele sayı üretmek isteyebilir
            // Ramdom sayı üretmek için
            // 0 dan başlayım int veri tipinin max sayı arasındaki rasgele bir sayı üretmek için
            /*
            Random rnd = new Random();
            int rSayi1 = rnd.Next();
            Console.WriteLine(rSayi1);
            */

            // 50 ile 100 aralığında random sayı üretmek için
            /*
            Random rnd = new Random();
            int rSayi1 = rnd.Next(50, 101);
            Console.WriteLine(rSayi1);
            */

            // 0 ile 1 arasında random sayı üretmek
            /*
            Random rnd = new Random();
            double rSayi1 = rnd.NextDouble();
            Console.WriteLine(rSayi1);
            */

            // Sayısal loto çekilişlerine çıkan sayıları erkana yazdıran bir uygulama yazalım
            /*
            Random rnd = new Random();
            int sayac = 1, hedef = 6;
            while (sayac <= hedef)
            {
                Console.Write(rnd.Next(1, 61) + " ");
                sayac++;
            }
            */

            // 1 ile 10 arasında rastgele bir sayı üretelim kullanıcıdan sayıyı tahmin etmesini isteyelim sayıyı bulana kadar
            /*
            Random rnd = new Random();
            int rSayi1 = rnd.Next(1, 11);
            int tahmin = 0, i = 0;
            do {
                Console.Write("Sayıyı Tahmin Et: ");
                tahmin = int.Parse(Console.ReadLine());
                i++;
            } while (tahmin != rSayi1);
            Console.WriteLine($"Tebrikler, {i} denemede buldunuz");
            */
            #endregion

            #region Array
            // Array(Dizi)
            // Program yazarkeen bazı durumlarda aynı türden birden fazla değer tutmak zorunda kalabiliriz
            // Array tanımlama işlemini [] işaretleri arasında yaparız
            // İçerisinde 5 adet elaman barındıran int türünde bir array oluşturun ve içine elaman atayın
            /*
            int[] sayilar = new int[5];
            sayilar[0] = 5;
            sayilar[1] = 45;
            sayilar[2] = 100;
            sayilar[3] = -25;
            sayilar[4] = 0;

            Console.WriteLine($"0. indexteki 1. Eleman: {sayilar[0]}");
            Console.WriteLine($"0. indexteki 2. Eleman: {sayilar[1]}");
            Console.WriteLine($"0. indexteki 3. Eleman: {sayilar[2]}");
            Console.WriteLine($"0. indexteki 4. Eleman: {sayilar[3]}");
            Console.WriteLine($"0. indexteki 5. Eleman: {sayilar[4]}");
            */

            // Kullanıcıdan 3 adet sayı talep edelim
            // Sayıların toplamını ve ortalama ve ortalamasını erkana yazdıralım
            // Değişken tanımlarını Array ile yapalım
            /*
            int[] sayilar = new int[3];
            Console.Write("1. Sayıyı Giriniz: ");
            sayilar[0] = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            sayilar[1] = int.Parse(Console.ReadLine());
            Console.Write("3. Sayıyı Giriniz: ");
            sayilar[2] = int.Parse(Console.ReadLine());
            int toplam = sayilar[0] + sayilar[1] + sayilar[2];
            Console.WriteLine("\nSayıların Toplamı: " + toplam);
            double ort = (double) toplam / sayilar.Length;
            Console.WriteLine("Sayıların Ortalaması: " + ort);
            */

            // Kullanıcıdan 5 adet sayı talep edelim
            // Talep edilen sayıların 3'e tam bölünebilenlerini toplamnı ekrana yazdıralım
            // Array ile yapalım
            /*
            int[] sayilar = new int[5];
            Console.WriteLine("5 adet sayı girilecek");
            Console.Write("1. sayıyı giriniz: ");
            sayilar[0] = int.Parse(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            sayilar[1] = int.Parse(Console.ReadLine());
            Console.Write("3. sayıyı giriniz: ");
            sayilar[2] = int.Parse(Console.ReadLine());
            Console.Write("4. sayıyı giriniz: ");
            sayilar[3] = int.Parse(Console.ReadLine());
            Console.Write("5. sayıyı giriniz: ");
            sayilar[4] = int.Parse(Console.ReadLine());

            int toplam = 0;
            if (sayilar[0] % 3 == 0) {
                toplam += sayilar[0];
            }
            if (sayilar[1] % 3 == 0) {
                toplam += sayilar[1];
            }
            if (sayilar[2] % 3 == 0) {
                toplam += sayilar[2];
            }
            if (sayilar[3] % 3 == 0) {
                toplam += sayilar[3];
            }
            if (sayilar[4] % 3 == 0) {
                toplam += sayilar[4];
            }

            Console.WriteLine("3'e tam bölünenlen sayıların toplamları: " + toplam);
            */
            #endregion

            #region For
            // döngü yapıları adında belli olduğu gibi koşul doğruluğunu sağladığı sürece kendi bloğu içerisindeki komut satırlarını işleyen mekanizmadır
            // uygulama for döngüsüne girdiğine 1.ifade çalışır bu aşamada değişken tanımlama ve değişkene değer atama işlemleri uygulanır sadece ilk döngüde çalışır ve daha sonra çalışmaz
            // 1'den 10'a kadar olan sayıları ekrana yazdıralım
            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            // 1 ile 100 arasındaki sayıları ekrana yan yana yazdıralım
            /*
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
            }
            */

            // 1 ile 100 arasındaki sayılardan çift olanları ekrana yazdıralım
            /*
            for (int i = 2; i <= 100; i += 2)
            {
                Console.Write(i + " ");
            }
            */

            // 1 den başlayıp kullanıcının girmiş olduğu sayıya kadar olan sayıların toplamını ve ortalamasını yazdıralım
            /*
            int toplam = 0;
            int sayi;
            do
            {
                Console.Write("Bir Sayı Giriniz : ");
                sayi = int.Parse(Console.ReadLine());
                if (sayi <= 1)
                {
                    Console.WriteLine("Lütfen 1'den büyük bir sayı giriniz");
                }
            } while (sayi <= 1);

            for (int i = 1; i <= sayi; i++)
            {
                toplam += i;
            }
            Console.WriteLine("Sayıların Toplamı = " + toplam);
            Console.WriteLine("Sayıların Ortalaması = " + (double)toplam / sayi);
            */

            // A'dan başlayıp Z'ye kadar olan harfleri yazdıralım
            /*
            for (char karakter = 'a'; karakter <= 'z'; karakter++)
            {
                Console.Write(karakter + " ");
                if (karakter == 'g')
                {
                    Console.Write("ğ ");
                }
            }
            Console.WriteLine();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                Console.Write(i + " ");

            }
            */

            // iç içe for döngüsü kullanarak çarpım tablosu yazdıralım
            /*
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine(i + "x" + j + " = " + (i * j));
                }
                Console.WriteLine("--------------");
            }
            */
            #endregion

            #region For İle Array Oluşturma
            // for döngüsü ile daha önceden oluşturulmuş array leri doldurma
            /*
            int[] sayilar = new int[5];
            Console.WriteLine("5 Adet Sayı Girilecek ");
            Console.WriteLine("----------------------");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 1) + ". Sayıyı Giriniz:");
                sayilar[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();
            Console.WriteLine("Girdiğiniz Sayılar");
            Console.WriteLine("------------------");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(sayilar[i] + " ");
            }
            */

            // kullanıcıya kaç adet sayı girmek istediğini soralım
            // girmiş olduğu sayıların toplamını ve ortalamasını gösterelim
            // for döngüsü ve array yapısı kullanılacak
            /*
            int toplam = 0;
            int adet;
            Console.Write("Kaç adet sayı girilecek ? ");
            adet = int.Parse(Console.ReadLine());
            int[] sayilar = new int[adet];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 1) + ".Sayıyı Giriniz : ");
                sayilar[i] = int.Parse(Console.ReadLine());
                // toplam += sayilar[i];

            }
            for (int x = 0; x < sayilar.Length; x++)
            {
                toplam += sayilar[x];
            }
            Console.WriteLine("Sayıların Toplamı = " + toplam);
            Console.WriteLine("Sayıların Ortalaması = " + (double)toplam / sayilar.Length);
            */
            #endregion

            #region Foreach
            // foreach mekanizması döngüyü sağlaması için bir koleksiyona ihtiyaç duyar
            // bu koleksiyonun içerisindeki bütün öğeleri tekrar tekrar işleme alır
            /*
            int[] sayilar = new int[] {15 , 7 , 45 , 68 , -95 , 251};
            foreach (var yeniDonguSayilar in sayilar)
            {
                Console.WriteLine(yeniDonguSayilar);
            }
            */

            // 5 elamanlı bir sayı dizisiniz oluşturup for ile elamanları dolduralım
            // sonra foreach ile elamanları okuyup yan yana yazdıralım
            // sayıların toplamını ve ortalamasını gösterelim
            /*
            int[] sayilar = new int[5];
            Console.WriteLine("5 Adet Sayı Giriniz");
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 1) + ". Sayı Girin: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Girilen Sayılar: ");
            foreach (var item in sayilar)
            {
                toplam += item;
                Console.Write(item + " ");
            }
            Console.WriteLine("\nToplamları: " + toplam);
            Console.WriteLine("Ortalamaları: " + (double) toplam/sayilar.Length);
            */

            // 5 adet sayı alalım bir diziye kayıt edelim
            // girdiği sayılardan 3'e tam bölünelenleri ekrana yazdıralım foreach ile
            /*
            int[] sayilar = new int[5];
            Console.WriteLine("5 Adet Sayı Giriniz");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 1) + ". Sayı Girin: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("3'e Bölünen Sayılar ==> ");
            foreach (var item in sayilar)
            {
                if (item % 3 == 0)
                {
                    Console.Write(item + " ");
                }
            }
            */

            // bu dizi içerisindeki en uzun ve en kısa isimli sehirleri erkana yazıralım
            /*
            string[] sehirler = new string[]
            {
                "İstanbul",
                "Kırklareli",
                "Yozgat",
                "İzmir",
                "Muş",
            };
            string enKisa = sehirler[0], enUzun = sehirler[0];
            int enKucuk = sehirler[0].Length, enBuyuk = sehirler[0].Length;
            foreach (var item in sehirler)
            {
                if (enKucuk > item.Length)
                {
                    enKucuk = item.Length;
                    enKisa= item;
                }
                if (enBuyuk < item.Length)
                {
                    enBuyuk = item.Length;
                    enUzun = item;
                }
            }
            Console.WriteLine("En uzun isimli şehir: " + enUzun);
            Console.WriteLine("En kısa isimli şehir: " + enKisa);
            */
            #endregion

            #region Hazır String Methodlar
            // micrasoftun bize sunmuş olduğu bazı hazır string methodlar bulunmaktadır
            // bu methodlar sayasinde bir takım işlerimizi kolaylaştırabilirsiniz
            string metin = "Merhaba Dünya";
            /*
            Console.WriteLine(metin.Length);

            Console.WriteLine(metin.Replace("Dünya", "Mars"));

            Console.WriteLine(metin.IndexOf("a"));
            Console.WriteLine(metin.IndexOf("x"));

            Console.WriteLine(metin.LastIndexOf("a"));
            Console.WriteLine(metin.LastIndexOf("x"));

            Console.WriteLine(metin.ToLower());
            Console.WriteLine(metin.ToUpper());

            string tMetin = "     Selam     ";
            Console.WriteLine(tMetin.Trim());
            
            int arama = metin.LastIndexOf("a");
            if (arama == -1) {
                Console.WriteLine("Aradığınız Sonuç Bulunamadı");
            } else {
                Console.WriteLine("Aradığınız Sonuç " + arama + ". Indextedir");
            }

            bool cevap = metin.Contains("Dünya");
            if (cevap) {
                Console.WriteLine("Aradığınız Değer Bulundu");
            } else {
                Console.WriteLine("Aradığınız Değer Bulunamadı");
            }

            string isimler = "Ahmet,Methmet,Arda,Ali,Ayşe,Fatma";
            var isim = isimler.Split(',');
            foreach (var item in isim)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

               
            Console.ReadKey();
        }
    }
}
