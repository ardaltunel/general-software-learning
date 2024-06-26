﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
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
            // microsoftun bize sunmuş olduğu bazı hazır string methodlar bulunmaktadır
            // bu methodlar sayasinde bir takım işlerimizi kolaylaştırabilirsiniz
            // string metin = "Merhaba Dünya";
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

            #region Math Methodları
            // math sınıfı içerisinde tanımlanmış sınıflar ile matamatiksel işlemlerde işimizi kolaylaştırır
            /*
            Console.WriteLine(Math.Abs(-59)); // math.abs bir sayının mutlak değerini verir
            Console.WriteLine(Math.Ceiling(9.2)); // ceiling bir üst sayıya yuvarlar
            Console.WriteLine(Math.Floor(7.9)); // floor bir alt sayıya yuvarlar
            Console.WriteLine(Math.Round(13.21364, 2)); // round küsüratın kaç basamak olarak gözükeceğini seçmemiz içindir
            Console.WriteLine(Math.Max(-8,15)); // max en büyük değeri döndürür
            Console.WriteLine(Math.Min(-12,40)); // min en küçük değeri döndürür
            Console.WriteLine(Math.Pow(6,2)); // pow üssü alma işlemi yapar
            Console.WriteLine(Math.Sqrt(36)); // sqrt karakök alma işlemi yapar
            Console.WriteLine(Math.PI); // pi sayısını verir
            Console.WriteLine(Math.E); // e sayısını verir
            Console.WriteLine(Math.Sin(15)); // sin trigonometir içerisinde bulunan sinüs hesaplamarı içindir
            Console.WriteLine(Math.Asin(0.54818)); // asin radyan değere karşılık gelen açıyı radyan değeri olarak verir
            Console.WriteLine(Math.Log10(100)); // log10 10 tabanına göre logaritmasını hesaplar
            Console.WriteLine(Math.Log(16,2)); // log ikinci girilen sayıya göre tabanına logaritmasını hesaplar
            */

            // kullanıcıdan 3 adet sayı alınız bu sayıları en küçüğünü ve en büyüğünü ekrana yazdırın
            /*
            Console.WriteLine("Lütfen 3 Sayı Giriniz\n");
            Console.Write("1. Sayı: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayı: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("3. Sayı: ");
            int sayi3 = int.Parse(Console.ReadLine());
            int enKucuk = Math.Min(Math.Min(sayi1, sayi2),sayi3);
            int enBuyuk = Math.Max(Math.Max(sayi1, sayi2),sayi3);
            Console.WriteLine("\nEn Küçük Sayı: " + enKucuk);
            Console.WriteLine("En Büyük Sayı: " + enBuyuk);
            */
            #endregion

            #region Array Methodları
            // işleyişlerin kolaylaşmalarını sağlamak amacıyla bir takım array methodları vardır
            //int[] sayilar = new int[] { 23 , 45 , 62 , 0 , 1 , -51 , 5 , 4500 , -239 };

            // ekrana yazdırmak
            /*
            foreach (var item in sayilar) {
                Console.Write(item + " ");
            }
            */

            // sort alfabetik sıralamak veya küçükten büyüğe doğru sıralar
            /*
            Array.Sort(sayilar);
            foreach (var item in sayilar) {
                Console.Write(item + " ");
            }
            */

            // reverse terse döndürür
            /*
            Array.Reverse(sayilar);
            foreach (var item in sayilar) {
                Console.Write(item + " ");
            }
            */

            // indexof dizide arama işlemi yapıyor
            /*
            int sonuc = Array.IndexOf(sayilar, 62);
            if (sonuc == -1) {
                Console.Write("Aranan Değer Bulunamadı");
            } else {
                Console.Write("Aranan Değer Bulundu");
            }
            */

            // lastindexof aramaya tersten başlar
            /*
            int sonuc = Array.LastIndexOf(sayilar, 62);
            if (sonuc == -1) {
                Console.Write("Aranan Değer Bulunamadı");
            } else {
                Console.Write("Aranan Değer Bulundu");
            }
            */

            // kullanıcıdan kaç adet değer dirmek istediğini sorun
            // girilen değerlerin içinden en küçük ve en büyük olan sayıları ekrana yazdıralım
            /*
            Console.Write("Kaç Adet Sayı Girmek İstersiniz?: ");
            int adet = int.Parse(Console.ReadLine());
            int[] girilenSayi = new int[adet];
            Console.WriteLine("");
            for (int i = 0; i < adet; i++) {
                Console.Write((i + 1) + ". Sayıyı Giriniz: ");
                girilenSayi[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(girilenSayi);
            Console.WriteLine("\nEn Küçük Olan: " + girilenSayi[0]);
            Console.WriteLine("En Büyük Olan: " + girilenSayi[adet - 1]);
            */

            // kullanıcıdan kaç adet kişi girmek istediğinizi sorun o kadar isim isteyin sonra
            // arama yapmak için beş harf bilgisi alın belirtilen harf ile başlayan isimleri listeleyin
            /*
            Console.Write("Kaç adet kişi girmek istersiniz: ");
            int kisi = int.Parse(Console.ReadLine().ToLower());
            string[] isimler = new string[kisi];
            for (int i = 0; i < isimler.Length; i++) {
                Console.Write((i + 1) + ". İsim giriniz: ");
                isimler[i] = Console.ReadLine();
            }
            Console.Write("\nHangi harf ile başlayan isimleri listelemek istersiniz: ");
            char harf = char.Parse(Console.ReadLine());
            Console.WriteLine("\n" + harf + " ile başlayan isimler şunlardır:");
            foreach (var item in isimler) {
                if (item.ToLower().IndexOf(harf) == 0) {
                    Console.WriteLine(item);
                }
            }
            */

            // kullancııdan kaç sayi girmek istediğini soralım o adet kadar sayıyı talep edelim
            // kullanıcılardan daha önceden giridği bir sayıyı terkar giremsini isteyin
            // aynı sayıyı giriyor ise "Bu sayiyi daha önceden girdiniz. Lütfen başka bir sayı giriniz" mesajı ile uyarın
            // sayılar girildikten sonra toplam ve ortalama değerlerini gösterelim
            /*
            Console.Write("Kaç adet sayi girmek istersiniz: ");
            int adet = int.Parse(Console.ReadLine());
            int[] sayilar = new int[adet];
            int sayac = 0, toplam = 0;
            while (sayac < adet) {
                Console.Write((sayac + 1) + ". Sayıyı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                if (Array.IndexOf(sayilar,sayi) == -1) {
                    sayilar[sayac] = sayi;
                    toplam += sayi;
                    sayac++;
                } else {
                    Console.WriteLine("{0} Sayisi daha önceden girdiniz. Lütfen başka bir sayı giriniz",sayi);
                }
            }
            double ort = (double) toplam / sayilar.Length;
            Console.WriteLine("Sayıların toplamı: " + toplam);
            Console.WriteLine("Sayıların ortalamarı: " + ort);
            */
            #endregion

            #region Metodlar (public,private,internal)
            // metodlar yapı itibari ile içerinde bulundan kod bloklarının içerisinde
            // istediğiniz yerde çalıştırmasını sağlayan yapılardır
            // public => halka açık manasına gelir erişim kolaylıkla sağlanabilir
            // private => belirtilen classı gizli olarak tanımlar dışardan erişim sağlanamaz
            // internal => diğer sınıfrlar içerisinden erişim sağlanabilir sadece başka projelerde erişim sağlanmaz

            // Metod.cs:
            /*
            public double ToplamaIslemi(double s1, double s2)
            {
                double toplam = s1 + s2;
                return toplam;

            }

            public void ToplaVeYaz(double s1, double s2)
            {

                Console.WriteLine("Sayıların Toplamı");
                Console.WriteLine("İki Adet Double Değer Toplandı");
                Console.WriteLine("Toplanan Değerler {0} ve {1}", s1, s2);
                Console.WriteLine("Toplam = " + (s1 + s2));

            }
            */

            // eklenen metoda göre bir örnek
            /*
            Metodlar m=new Metodlar();
            Console.Write("Bir sayı giriniz : ");
            double sayi1=int.Parse(Console.ReadLine());
            Console.Write("Bir Sayı Daha Giriniz : ");
            double sayi2=int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------");

            // double toplam = m.ToplamaIslemi(sayi1, sayi2);
            // Console.WriteLine(toplam);
            // Console.WriteLine(m.ToplamaIslemi(sayi1,sayi2));

            m.ToplaVeYaz(sayi1, sayi2);
            */

            // Metod.cs:
            /*
            public int CikarmaIslemi(int s1, int s2)
            {
                int sonuc = s1 - s2;
                return sonuc;
            }


            public void CikarmaIslemiVoid(int s1, int s2)
            {
                Console.WriteLine("Sayıların Farkı = " + (s1 - s2));
            }
            */

            // kullanıcıdan 2 adet sayı talep edelim
            // talep edilen sayıların farkını ekrana yazdıralım
            /*
            Console.Write("Birinci Sayıyı Giriniz : ");
            int kullaniciSayi1=int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz : " );
            int kullaniciSayi2=int.Parse(Console.ReadLine());
            Metod met=new Metod();
            // Console.WriteLine("Sayıların Farkı = "+met.CikarmaIslemi(kullaniciSayi1,kullaniciSayi2));
            met.CikarmaIslemiVoid(kullaniciSayi1,kullaniciSayi2);
            */

            // Method.cs:
            /*
            public int ToplamaYaptir(int[] sayilar)
            {
                int toplam = 0;
                foreach (var item in sayilar)
                {
                    toplam += item;

                }
                return toplam;

            }
            public void ToplamveOrtalamaYazdir(int toplam, int adet)
            {
                Console.WriteLine("Sayıların Toplamı = " + toplam);
                Console.WriteLine("Sayıların Ortalaması = " + toplam / adet);
            }
            */

            // kullanıcıdan kaç adet sayı girmek istediğini talep edelim
            // talep edilen sayıların toplamını ve ortalamasını ekrana yazdıralım
            /*
            Console.Write("Kaç Adet Sayı Girmek İstersiniz : ");
            int adet=int.Parse(Console.ReadLine());

            int[] sayilarDizisi=new int[adet];
            for (int i = 0; i < sayilarDizisi.Length; i++)
            {
                Console.Write((i+1)+".Sayıyı Giriniz : ");
                sayilarDizisi[i]=int.Parse(Console.ReadLine());
            }
            Metodlar metod = new Metodlar();
            int sayilarinToplami = metod.ToplamaYaptir(sayilarDizisi);
            metod.ToplamveOrtalamaYazdir(sayilarinToplami,sayilarDizisi.Length);
            */

            // Method.cs:
            /*
            public void Toplama(int s1, int s2)
            {
                int toplam = s1 + s2;
                Console.WriteLine("Sayıların Toplamı = " + toplam);
            }
            public void Cikarma(int s1, int s2)
            {
                int fark = s1 - s2;
                Console.WriteLine("Sayıların Farkı = " + fark);

            }
            */

            // kullanıcıdan 2 adet sayı isteyelim
            // 1-Toplama
            // 2-Çıkarma
            // kullanıcının seçmiş olduğu işleme göre
            // sayıların toplamını veya farkını ekrana yazdıralım
            /*
            Console.Write("Birinci Sayıyı Giriniz : ");
            int sayi1=int.Parse(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz : ");
            int sayi2=int.Parse(Console.ReadLine());    

            Console.Clear();
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("----------");
            Console.WriteLine("İşlem Türünü Seçiniz");
            int secim=int.Parse(Console.ReadLine());

            Metodlar metod=new Metodlar();
            switch (secim)
            {
                case 1:
                    metod.Toplama(sayi1,sayi2);
                    break;
                case 2:
                    metod.Cikarma(sayi1,sayi2);
                    break;
                    default:
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    break;
            }
            */
            #endregion

            #region Over Load Metod
            // programlarımız içerisinde bazı durumlarda fonksiyon adında farklı işleyişler yaptırmay imkanı sağlayabilir
            // örnek olaraK 2 adet int satısı parametre olarak tutan bir metodumuz olsun
            // bu fonksiyonu çalıştırabilmemiz için foknsiyon adı altında int sayı değilde double sayıları toplamak isterse
            // overload metod yöntemine başvurulur

            // Method.cs:
            /*
            public void Topla(int s1, int s2)
            {
                Console.WriteLine(s1 + s2);
            }
            public void Topla(double s1, double s2)
            {
                Console.WriteLine(s1 + s2);
            }
            public void Topla(int s1, int s2, int s3)
            {
                Console.WriteLine(s1 + s2 + s3);
            }
            public void Topla(double s1, double s2, double s3)
            {
                Console.WriteLine(s1 + s2 + s3);
            }
            */

            // kullanımı
            /*
            Metod methodlar = new Metod();
            Console.Write("1. Fonksiyon: ");
            methodlar.Topla(5, 10);
            Console.Write("2. Fonksiyon: ");
            methodlar.Topla(5.4, 9.4);
            Console.Write("3. Fonksiyon: ");
            methodlar.Topla(5, 12, 17);
            Console.Write("4. Fonksiyon: ");
            methodlar.Topla(2.1, 7.3, 8.3);
            */

            // kullanıcıdan 2 adet sayı talep edelim 1 adette işlem türü talep edelim
            // işlem türüne göre sonucu ekrana yazıdralım kullanıcı işlem türü girmeden enter basar toplama işlemi yapar
            // Method.cs:
            /*
            public void Hesapla(int s1, int s2)
            {
                Console.WriteLine("Geçerli bir işlem türü girmediniz sayılar toplanacak");
                Console.WriteLine("Sayıların toplamı = " + (s1 + s2));
            }
            public void Hesapla(int s1, int s2, string secim)
            {
                string format = "{0} {1} {2} = {3}";
                double sonuc = 0;

                switch (secim)
                {
                    case "+":
                        sonuc = s1 + s2;
                        break;
                    case "-":
                        sonuc = s1 - s2;
                        break;
                    case "*":
                        sonuc = s1 * s2;
                        break;
                    case "/":
                        sonuc = s1 / s2;
                        break;
                }

                Console.WriteLine(format, s1, secim, s2, sonuc);
            }
            */

            /*
            Console.WriteLine("Lütfen 2 Sayı Giriniz");
            Console.Write("1. Sayı: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayı: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("\nYapmak türünü giriniz ( + , - , * , / ) : ");
            string islemTuru = Console.ReadLine();

            Metod m = new Metod();
            if (string.IsNullOrEmpty(islemTuru))
            {
                m.Hesapla(sayi1, sayi2);
            }
            else 
            {
                m.Hesapla(sayi1, sayi2, islemTuru);
            }
            */
            #endregion

            #region Static Metod
            // şimdiye kadar oluşturduğumuz sibirları program içerisne dahil etmek için "new" ifadesini kullanıyordu
            // new ifade sayesinde çağardığımız calss yapısı içerindeki fonksiyonlara erişim sağlıyorduk
            // static metod ile metodlarımızda new ifade olmadan direkt erişim sağlayabiliriz
            // internal static class Metod (static eklemesi yapılıyor)

            // Metod.cs:
            /*
            internal static class Metod
            {
                public static void Topla(int s1, int s2)
                {
                    Console.WriteLine("Sayıların Toplamı: " + (s1 + s2));
                }
            }*/

            // normalde "Metod methodlar = new Metod();" şelinde çağarılıyordu
            // static sayesinde buna gerek olmadan çağarılabiliyor
            /*
            Metod.Topla(5, 8);
            */
            #endregion

            #region Try Catch
            // programımız içerisinde çalışma esnasında bazo durumlarda hata olur ve program çöker
            // bu durumlarda çökme yaşanmaması için try catch kullanırız
            /*
            Console.Write("Bir sayı giriniz: ");
            try
            {
                int sayi = int.Parse(Console.ReadLine());
                Console.WriteLine("Girilen sayı: " + sayi);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                Console.WriteLine("\n------------------\n");
                Console.Write(ex.Message);
                Console.WriteLine("\n\n------------------\n");
                Console.Write("Lütfen tam sayı giriniz");
            }
            */

            // kullanıcının 4 işlem yapabileceği bir program hazırlayın
            // girilen değerleri trycatch ile kontrol edelim
            // Metod.cs olarak ta bunu ekleyebilrsiniz main dizinin dışında yazabilirsiniz
            /*
            public void SecimMenusu()
            {
                Console.WriteLine("İşleminizi seçin");
                Console.WriteLine("1-Toplama");
                Console.WriteLine("2-Çıkarma");
                Console.WriteLine("3-Çarpma");
                Console.WriteLine("4-Bölme");
            }
            */

            /*
            Program m = new Program();
            try
            {
                Console.Write("1. Sayıyı Giriniz: ");
                int sayi1=int.Parse(Console.ReadLine());
                Console.Write("2. Sayıyı Giriniz: ");
                int sayi2=int.Parse(Console.ReadLine());
                Console.Clear();
                m.SecimMenusu();
                Console.Write("\nİşleminizi seçin: ");
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Sayıların toplamı: " +(sayi1+sayi2));
                        break;
                    case 2:
                        Console.WriteLine("Sayıların farkı: " +(sayi1-sayi2));
                        break;
                    case 3:
                        Console.WriteLine("Sayıların çarpımı: " +(sayi1*sayi2));
                        break;
                    case 4:
                        Console.WriteLine("Sayıların bölümü: " +(sayi1/sayi2));
                        break;
                    default: Console.WriteLine("Yanlış bir işlem yaptınız");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */
            #endregion

            #region Sınıflar (Class)
            // classlar nesne yönelimli programların en önemli yapı taşlarından birisidir
            // class yapılarının içerisinde barınan tüm elamarın bir erişim düzenleyici olması zorunludur
            /*
            class MyClass
            {

            }
            */
            #endregion

            #region Field
            // class içerisinde bir veritipi class veya koleysiona bağlı olarak tanımlanan değişkenlere denir
            // default olarak erişim düzenleyicileri private olarak tanımlanır
            // başka class üzerinden erişmek için public olması gerekir
            /*
            ClassIsmi ogr = new ClassIsmi();
            ogr.ad = "Ahmet";
            ogr.soyad = "Kanca";
            ogr.no = 43;
            Console.WriteLine("Adı: " + ogr.ad);
            Console.WriteLine("Soyadı: " + ogr.soyad);
            Console.WriteLine("Numarası: " + ogr.no);
            */
            #endregion

            #region Class Ornek
            // bir öğrenci classı oluşturalım ad soyad not1 not2 bilgileri yer alalım
            // öğrencilerin tüm bilgilerini kullanıcında talep edelim ve ekrana yazıdralmı
            // Ogrenci.cs:
            /*
            public string ad;
            public string soyad;
            public int not1;
            public int not2;
            */

            /*
            Ogrenci ogr = new Ogrenci();
            Console.Write("Adinizi Girin: ");
            ogr.ad = Console.ReadLine();
            Console.Write("Soyadinizi Girin: ");
            ogr.soyad = Console.ReadLine();
            Console.Write("Not 1'i Girin: ");
            ogr.not1 = int.Parse(Console.ReadLine());
            Console.Write("Not 2'yi Girin: ");
            ogr.not2 = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Girilen Bilgileriniz\n");
            Console.WriteLine("Adı: " + ogr.ad);
            Console.WriteLine("Soyadı: " + ogr.soyad);
            Console.WriteLine("Numarası: " + ogr.not1);
            Console.WriteLine("Numarası: " + ogr.not2);
            */
            #endregion

            #region Property
            // class yapıları içerisinde tanımlanan bazı değişkenlerin sadece okunabilir veya yazılabilir olmasını isteyebiliriz
            // property ler sınıflar içerindeki değişkenleri kasıtlamamızı sağlar

            // Metod.cs:
            /*
            public string ad, soyad;
            public double n1, n2;
            public double notOrtalamasi { get { return (n1 + n2) / 2; } }

            public string ogrencAdi { set { ad = value; } } // private ise değişkeni çağarabiliriz (get olmadığı için okuma yapamaz)
            */

            /*
            Metod o = new Metod();
            o.ad = "Ali";
            o.soyad = "Polat";
            o.n1 = 60;
            o.n2 = 85;
            Console.WriteLine("Adı: " +o.ad);
            Console.WriteLine("Soyadı: " +o.soyad);
            Console.WriteLine("Not Ortalaması: " +o.notOrtalamasi);
            */

            // property için örnek
            // Metod.cs:
            /*
            public string kullaniciAdi;
            private string _parola;
            public string parolaTanimla { set { _parola = value; } }
            public void GirisYap(string kAdi, string parola) {
                if (kAdi == kullaniciAdi && parola == _parola) { Console.WriteLine("Giriş Yapıldı"); }
                else { Console.WriteLine("Girişiniz Başarısız"); }
            }
            */

            /*
            Metod k = new Metod();
            k.kullaniciAdi = "admin";
            k.parolaTanimla = "1234";
            Console.Write("Kullanici adi: ");
            string kAdi = Console.ReadLine();
            Console.Write("Şifre: ");
            string parola = Console.ReadLine();
            k.GirisYap(kAdi, parola);
            */
            #endregion

            #region List
            // list koleksiyonu c# programlama dili içerisinde sık kulanılan bir köleksiyonlardan bir tanesidir
            // koleksiyon tanımlama işlemi esnasında içerisinde kaç adet elaman barındıralacağını belirmemize ihtiyac yoktur
            /*
            List<int> sayilar = new List<int>();
            sayilar.Add(53);
            sayilar.Add(42);
            sayilar.Add(-85);
            Console.WriteLine("0. İndexteki 1. Eleman : " + sayilar[0]);
            Console.WriteLine("1. İndexteki 2. Eleman : " + sayilar[1]);
            Console.WriteLine("2. İndexteki 3. Eleman : " + sayilar[2]);
            sayilar[1] = 70;
            Console.WriteLine("1. İndexteki 2. Eleman (değiştirilmiş) : " + sayilar[1]);
            sayilar.Remove(70); // belirtilen değeri koleysion içerisinde arayı bulursa siler
            sayilar.RemoveAt(0); // index numarasına göre elamanı siler
            sayilar.Count(); // koleksyion içindeki eleman sayısı
            */

            // kullanıcıdan kaç adet sayi girmek istedini soralım
            // belirttiği sayı kadar sayıyı list koleksiyonu içerisinde barındıralım
            // kullanıcıdan girmiş oldu sayıların toplamını ve ortalamasını ekrana yazdıralım
            /*
            Console.Write("Kaç adet sayi girmek istersiniz: ");
            int adet = int.Parse(Console.ReadLine());
            List<int> sayilar = new List<int>();
            for (int i = 1; i < adet; i++) {
                Console.WriteLine(i + ". Sayiyi giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                sayilar.Add(sayi);
            }
            int toplam = 0;
            foreach (var sayi in sayilar) {
                toplam += sayi;
            }
            double ort = (double)toplam / sayilar.Count());
            Console.WriteLine("\nSayıların toplamı: " +toplam);
            Console.WriteLine("Sayıların ortalaması: " + Math.Round(ort,2));
            */
            #endregion

            #region Genel Alıştırma
            // Öğrenci kayıt programı
            // 1. Öğrenci ekle
            // 2. Öğrenci sil
            // 3. Öğrenci listele
            // 4. Öğrenci ara
            // 5. Toplam öğrenci sayısı
            // 6. Öğrencilerin genel not ortalaması
            // 0. Programdan çıkış
            // yukardaki işlemleri yapabilen bir program yazın

            // Menu.cs:
            /*
            internal static class Menu
            {
                static List<Ogrenci> ogrenciler = new List<Ogrenci>();
                public static void Islemler(ConsoleKey secim)
                {
                    switch (secim)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            OgrenciEkle("Öğrenci Ekleme Sayfası");
                            break;
                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            OgrenciSil("Öğrenci Silme Sayfası");
                            break;
                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            OgrencileriListele("Öğrenci Listeleme Sayfası");
                            break;
                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            OgrenciAra("Öğrenci Arama Sayfası");
                            break;
                        case ConsoleKey.D5:
                        case ConsoleKey.NumPad5:
                            ToplamOgrenci("Toplam Öğrenci Sayısı");
                            break;
                        case ConsoleKey.D6:
                        case ConsoleKey.NumPad6:
                            GenelNotOrtalamasi("Öğrencilerin Genel Not Ortalaması");
                            break;
                        default: break;
                    }
                }
                private static void BaslikYazdir(string metin)
                {
                    Console.Clear();
                    Console.WriteLine(metin);
                    Console.WriteLine("------------------------");
                }
                private static void AnaMenuyeDon(string metin)
                {
                    Console.WriteLine("\n\n" + metin);
                    Console.WriteLine("Ana Menüye Dönmek İçin Bir Tuşa Basınız");
                    Console.ReadKey();
                }
                private static void OgrenciEkle(string metin)
                {
                    BaslikYazdir(metin);
                    Ogrenci o = new Ogrenci();
                    o.ad = Metodlar.GetString("Öğrencinin Adını Giriniz: ");
                    o.soyad = Metodlar.GetString("Öğrencinin Soyadını Giriniz: ");
                    o.okulNo = Metodlar.GetInt("Öğrencinin Numarasını Giriniz: ", 1, 9999);
                    o.n1 = Metodlar.GetDouble("Öğrencinin 1. Sınav Notunu Giriniz: ", 1, 100);
                    o.n2 = Metodlar.GetDouble("Öğrencinin 2. Sınav Notunu Giriniz: ", 1, 100);
                    ogrenciler.Add(o);
                    AnaMenuyeDon("Kayıt İşlemi Başarılı Bir Şekilde Gerçekleşti");
                }
                private static void OgrenciSil(string metin)
                {
                    BaslikYazdir(metin);
                    if (ogrenciler.Count > 0) {
                        for (int i = 0; i < ogrenciler.Count; i++) {
                            ogrenciler[i].Yazdir(i+1);
                        }
                        int siraNo = Metodlar.GetInt("Silmek İstediğiniz Öğrencinin Sıra Numarasını Giriniz: ", 1, ogrenciler.Count);
                        ogrenciler.RemoveAt(siraNo - 1);
                        AnaMenuyeDon("Silme İşlemi Başarılı Bir Şekilde Gerçekleşmiştir");
                    } else {
                        AnaMenuyeDon("Listede Kayıtlı Öğrenci Bulunamadı");
                    }
                }
                private static void OgrencileriListele(string v)
                {
                    BaslikYazdir(v);
                    if (ogrenciler.Any()) {
                        for (int i = 0; i < ogrenciler.Count; i++) {
                            ogrenciler[i].Yazdir();
                        }
                        AnaMenuyeDon(string.Format("Toplam {0} adet öğrenci listelenmiştir",ogrenciler.Count));
                    } else {
                        AnaMenuyeDon("Listede Kayıtlı Öğrenci Bulunamadı");
                    }
                }
                private static void OgrenciAra(string v) 
                {
                    BaslikYazdir(v);
                    if (ogrenciler.Any()) {
                        string aranacakOgrenci = Metodlar.GetString("Aranacak Öğrencinin Adını veya Soyadını Giriniz: ");
                        int adet = 0;
                        foreach (var ogrenci in ogrenciler) {
                            if (ogrenci.tamAd.ToLower().Contains(aranacakOgrenci.ToLower())) {
                                adet++;
                                ogrenci.Yazdir(adet);
                            }
                        }
                        AnaMenuyeDon(string.Format("{0} kelimesine karışık {1} tane öğrenci bulunmuştur",aranacakOgrenci,adet));
                    } else {
                        AnaMenuyeDon("Listede Aranacak Kayıtlı Bir Öğrenci Bulunamadı");
                    }
                }
                private static void ToplamOgrenci(string v)
                {
                    BaslikYazdir(v);
                    if (ogrenciler.Any()) {
                        AnaMenuyeDon(string.Format("Listede {0} tane kayıtlı öprenci vardır",ogrenciler.Count));
                    } else {
                        AnaMenuyeDon("Kayıtlı Öğrenci Bulunamadı");
                    }
                }
                private static void GenelNotOrtalamasi(string v) 
                { 
                    BaslikYazdir(v);
                    if (ogrenciler.Any()) {
                        double genelOrt = 0;
                        foreach (var item in ogrenciler) {
                            genelOrt += item.ortalama;
                        }
                        double sonuc = genelOrt / ogrenciler.Count;
                        AnaMenuyeDon(string.Format("{0} adet ogrencinin genel not ortalaması = {1}", ogrenciler.Count, sonuc));
                    } else {
                        AnaMenuyeDon("Listede Kayıtlı Öğrenci Bulunamadı");
                    }
                }
            }
            */

            // Metodlar.cs:
            /*
            internal static class Metodlar
            {
                public static string GetString(string metin)
                {
                    string text = string.Empty;
                    bool hata = true;
                    do {
                        Console.Write(metin);
                        text = Console.ReadLine();
                        if (string.IsNullOrEmpty(text)) {
                            Console.WriteLine("Boş Bırakılamaz");
                            hata = true;
                        } else {
                            hata = false;
                        }
                    } while (hata);
                    return text;
                }
                public static int GetInt(string metin, int min = int.MinValue, int max = int.MaxValue)
                {
                    int sayi = 0;
                    bool hata = true;
                    do {
                        Console.Write(metin);
                        try {
                            sayi = int.Parse(Console.ReadLine());
                            if (sayi >= min && sayi <= max) {
                                hata = false;
                            } else {
                                Console.WriteLine("Girilen sayı {0} ile {1} aralığında olmalıdır",min,max);
                                hata = true;
                            }
                        } catch (Exception e) {
                            Console.WriteLine(e.Message);
                            hata = true;
                        }
                    } while (hata);
                    return sayi;
                }
                public static double GetDouble(string metin, double min = double.MinValue, double max = double.MaxValue)
                {
                    double sayi = 0;
                    bool hata = true;
                    do {
                        Console.Write(metin);
                        try {
                            sayi = double.Parse(Console.ReadLine());
                            if (sayi >= min && sayi <= max) {
                                hata = false;
                            } else {
                                Console.WriteLine("Girilen sayı {0} ile {1} aralığında olmalıdır", min, max);
                                hata = true;
                            }
                        } catch (Exception e) {
                            Console.WriteLine(e.Message);
                            hata = true;
                        }
                    } while (hata);
                    return sayi;
                }
            }
            */

            // Ogrenci.cs:
            /*
            internal class Ogrenci
            {
                public string ad, soyad;
                public int okulNo;
                public double n1, n2;

                public double ortalama {
                    get { return (n1+n2) / 2; }
                }
                public string tamAd {
                    get { return (ad + " " + soyad); }
                }
                public void Yazdir() {
                    Console.WriteLine("Öğrencinin Adı ve Soyadı: " + tamAd);
                    Console.WriteLine("Öğrencinin Sınav Notları: {0} , {1}",n1,n2);
                    // Console.WriteLine("Öğrencinin Sınav Notları: " + n1 + " , " + n2);
                    Console.WriteLine("Öğrencinin Not Ortalaması: " + ortalama + "\n");
                }
                public void Yazdir(int siraNo) {
                    Console.WriteLine(siraNo + "-) " + tamAd);
                }
            }
            */

            /*
            ConsoleKey cevap;
            do {
                Console.Clear();
                Console.WriteLine("Öğrenci Kayıt Programı");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Öğrenci Ekle");
                Console.WriteLine("2. Öğrenci Sil");
                Console.WriteLine("3. Öğrenci Listele");
                Console.WriteLine("4. Öğrenci Ara");
                Console.WriteLine("5. Toplam Öğrenci Sayısı");
                Console.WriteLine("6. Öğrencilerin Genel Not Ortalaması");
                Console.WriteLine("0. Programdan Çıkış");
                Console.WriteLine("--------------------------");
                Console.Write("Seçiminizi Yapın (0-6): ");
                cevap = Console.ReadKey().Key;
                Menu.Islemler(cevap);
            } while (cevap != ConsoleKey.D0 && cevap != ConsoleKey.NumPad0);
            Console.Clear();
            Console.WriteLine("Programı Kullandığınız İçin Teşekür Ederiz");
            Console.WriteLine("Kapatmak İçin Herhangi Bir Tuşa Basınız");
            */
            #endregion

            #region Inheritance
            // Inheritance (Kalıtım)
            // C# programlama dili içerisinde aynı proje içerisinde birden fazla class yazılabilir
            // bu classlar içersinde bazı propertylerin özellikleri aynı olabilir
            // bir classı başka bir classa miras alabilir miras aldığınız class içerisinde diğer classın tüm özellikleri kullanılabilir
            // bir classa sadece bir tane class miras edebilirsiniz

            // Kisi.cs:
            /*
            internal class Kisi
            {
                public string ad, soyad;
                public string tamAd
                {
                    get { return ad + " " + soyad; }
                }
            }
            */

            // Personel.cs:
            /*
            internal class Personel:Kisi
            {
                public int calismaSaati, saatlikUcret;
                public double maas
                {
                    get { return (double)calismaSaati * saatlikUcret; }
                }
                public void Yazdir()
                {
                    Console.WriteLine("Personel Bilgileri");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Personelin Adı ve Soyadı: " + tamAd);
                    Console.WriteLine("Çalışma Saati: " + calismaSaati);
                    Console.WriteLine("Saatlik Ücret: " + saatlikUcret);
                    Console.WriteLine("Maaş: " + maas);
                }
            }
            */

            // SaticDanismani.cs:
            /*
            internal class SatisDanismani:Personel
            {
                public double prim;
                public double toplamMaas { get { return prim + maas; } }
                public new void Yazdir()
                {
                    Console.WriteLine("Personel Bilgileri");
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Personelin Adı ve Soyadı: " + tamAd);
                    Console.WriteLine("Çalışma Saatli: " + calismaSaati);
                    Console.WriteLine("Saatlik Ücret: " + saatlikUcret);
                    Console.WriteLine("Maaş: " + maas);
                    Console.WriteLine("Prim: " + prim);
                    Console.WriteLine("Toplam Alacağı Maaş: " + toplamMaas);
                }
            }
            */

            /*
            Personel p = new Personel();
            p.ad = "Ahmet";
            p.soyad = "kaçar";
            p.calismaSaati = 250;
            p.saatlikUcret = 300;
            p.Yazdir();
            Console.WriteLine("\n");
            SatisDanismani sd = new SatisDanismani();
            sd.ad = "Ayşe";
            sd.soyad = "Yumlu";
            sd.calismaSaati = 180;
            sd.saatlikUcret = 350;
            sd.prim = 15000;
            sd.Yazdir();
            */
            #endregion

            #region Inheritance Örnek
            // Öğrenci ve öğretmen bilgilerini yazdırabileceğimiz bir program yapalım
            // Öğretmen (üniversite , branş)
            // Öğrenci (sınınf , okulNo)

            // Kisi.cs:
            /*
            internal class Kisi
            {
                public string ad, soyad;
                public string tamAd
                {
                    get { return ad + " " + soyad; }
                }
            }
            */

            // Ogrenci.cs:
            /*
            internal class Ogrenci:Kisi
            {
                public int sinif, okulNo;
                public void Yazdir()
                {
                    Console.WriteLine("Öğrenci Bilgilieri");
                    Console.WriteLine("------------------");
                    Console.WriteLine("Öğrenci Adı ve Soyadı: " + tamAd);
                    Console.WriteLine("Öprencinin Sınıfı: " + sinif);
                    Console.WriteLine("Öğrencinin Okul Numarası: " + okulNo);
                }
            }
            */

            // Ogretmen.cs:
            /*
            internal class Ogretmen:Kisi
            {
                public string uni, brans;
                public new void Yazdir()
                {
                    Console.WriteLine("Öğretmen Bilgilieri");
                    Console.WriteLine("------------------");
                    Console.WriteLine("Öğretmen Adı ve Soyadı: " + tamAd);
                    Console.WriteLine("Öğretmenin Mezun Olduğu Üniversite: " + uni);
                    Console.WriteLine("Öğretmenin Branşı: " + brans);
                }
            }
            */

            /*
            Ogrenci ogrenci = new Ogrencii();
            ogrenci.ad = "Osman";
            ogrenci.soyad = "Akkaya";
            ogrenci.okulNo = "2051";
            ogrenci.sinif = "11";
            ogrenci.Yazdir();
            Console.WriteLine("\n");
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.ad = "Kemal";
            ogretmen.soyad = "Uzun";
            ogretmen.uni = "ITU";
            ogretmen.brans = "Matematik";
            ogretmen.Yazdir();
            */
            #endregion

            #region Enum
            // String ifadelerle sayısal karşılaştırma ta da farklı işlemlerin gerektiği durumlarda
            // yazılımcılar için dahada okunabilirlik sağlayan ve gelecekte anlaşılmasını zorlaştıran kod
            // karmaşasını azaltmayı sağlayan yardımcı bir kod yapısıdır

            // static void Main(string[] args) kısmının dışına yazılır
            /*
            enum HaftaninGunleri
            {
                Pazartesi = 1,
                Sali,
                Çarşamba,
                Perşembe,
                Cuma,
                Cumartesi,
                Pazar
            }

            enum Departmanlar 
            {
                SatısPersoneli = 56,
                InsanKaynaklari = 200,
                PazarlamaMuduru = 80
            }
            */

            // 1. Örnek
            /*
            HaftaninGunleri bugun = HaftaninGunleri.Pazartesi;
            Console.WriteLine("Bugün Günkerden: " + bugun);
            */

            // 2. Örmek
            /*
            Console.Write("Departman Numarasını Giriniz: ");
            int departmanNo = int.Parse(Console.ReadLine());
            switch (departmanNo)
            {
                case (int)Departmanlar.SatisPersoneli:
                    Console.WriteLine("Satış Departmanına Hoşgeldiniz");
                    break;
                case (int)Departmanlar.PazarlamaMuduru:
                    Console.WriteLine("Pazarlama Departmanına Hoşgeldiniz");
                    break;
                case (int)Departmanlar.InsanKaynaklari:
                    Console.WriteLine(Departmanlar.InsanKaynaklari.ToString());
                    break;
                default:
                    Console.WriteLine("Bu Numaraya Kayıtlı Bir Departman Bulunamadı");
                    break;
            }
            */
            #endregion

            #region DateTime
            // DateTime sınıfı içerisinde zanab bilgisini tutan ve bu zaman bilgilerini
            // belirten formatlar ile ulaşabildiğimiz bir class yapısıdır
            /*
            DateTime time = DateTime.Now;
            Console.WriteLine("Şimdiki Zaman: " + time);
            Console.WriteLine("Tarih Bilgisi: " +time.Date);
            Console.WriteLine("Gün Bilgisi: " +time.Day);
            Console.WriteLine("Ay Bilgisi: " +time.Month);
            Console.WriteLine("Yıl Bilgisi: " +time.Year);
            Console.WriteLine("Saat Bilgisi: " +time.Hour);
            Console.WriteLine("Dakika Bilgisi: " +time.Minute);
            Console.WriteLine("Saniye Bilgisi: " +time.Second);
            Console.WriteLine("Milisaniye Bilgisi: " +time.Millisecond);
            Console.WriteLine("Haftanın Günü: " +time.DayOfWeek);
            Console.WriteLine("Yılın Kaçıncı Günü: " +time.DayOfYear);
            */
            #endregion

            #region Linq
            // Linq sorgulama yöntemi .Net Framework 3.5 ile birlikle gelen bir teknolojidir
            // Linq yöntemi ile kolekiyonlar ieçerisindeki verileri filteleyebilir sıralayabilir gruplandırabilirsiz
            /*
            List<string> sehirler = new List<string>() { 
                "İstanbul", "İzmir" ,"Manisa","Adıyaman","Edirne","Sivas","Bursa","Antalya","Tokat" 
            };
            var liste = from s in sehirler select s;
            foreach (var item in liste) {
                Console.WriteLine(item);
            }
            var kbSehirler = from s in sehirler orderby s ascending select s;
            Console.WriteLine("\nOrderBY\n-------------");
            foreach (var item in kbSehirler) {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region Linq Örnek
            /*    
            List<int> sayilar = new List<int>() {
                25,6,38,456,2,63,754,45,67,-5,-874,-5,3
            };
            */

            // koleksiyon içerisindeki veirleri linq yöntemi ile çekip ekrana yazdıralım
            /*
            var list = from s in sayilar select s;
            foreach (var item in list)  {
                Console.Write(item+ " ");
            }
            */

            // koleksiyon içerisindeki verileri küçükten büyüğe doğru sıralı bir şekilde yazdıralım
            /*
            var kbSayilar = from s in sayilar orderby s ascending select s;
            foreach (var item in kbSayilar) {
                Console.Write(item + " ");
            }
            */

            // koleksiyon içerisindeki verilerden 3'e bölünebilenleri ekrana yazdıralım
            /*
            var bolunen3 = from sayi in sayilar where sayi % 3 == 0 select sayi;
            foreach (var item in bolunen3) {
                Console.Write(item + " ");
            }
            */

            // koleksiyon içerisindeki verilerden 4'e bölünüp 7'ye bölünemeyen sayıları büyükten küçüğe doğru yazdıralım
            /*
            var bolunen4 = from sayi in sayilar where sayi % 4 == 0 where sayi % 7 !=0 orderby sayi descending select sayi;
            foreach(var item in bolunen4) {
                Console.Write(item + " ");
            }
            */

            // koleksiyon içerisindeki verilerden 2'ye tam bölünebilen sayıların en büyüğünü ve en küçüğünü ekrana yazdıralım
            /*
            var bolunenSayi = (from s in sayilar where s % 2 == 0 orderby s ascending select s).ToList();
            Console.WriteLine("En Küçük Sayı = " + bolunenSayi[0]);
            Console.WriteLine("En Büyük Sayı = " + bolunenSayi[bolunenSayi.Count-1]  );    
            */
            #endregion

            Console.ReadKey();
        }
    }
}