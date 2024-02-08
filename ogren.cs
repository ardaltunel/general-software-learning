using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06022024
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
            double sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Gir: ");
            double sayi2 = int.Parse(Console.ReadLine());
            Console.Write("3. Sayıyı Gir: ");
            double sayi3 = int.Parse(Console.ReadLine());
            double sonuc = ((sayi1 + sayi2 + sayi3) / 3);
            Console.WriteLine("Sayıların Ortalaması: " + sonuc);
            */
            #endregion

            Console.ReadKey();
        }
    }
}
