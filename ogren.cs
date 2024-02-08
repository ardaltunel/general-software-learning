using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06022024
{
    internal class Program
    {
       static void Main(string[] args)
        {
            // WriteLine yanına yazar
            /*
            Console.WriteLine("merhaba ben writeline");
            */


            // Write alt satıra yazar
            /*
            Console.Write("merhaba ben write ");
            Console.Write("bende write iki");
            */


            // ReadKey bir tuşa basıldığında kodu okumaya devam eder
            /*
            Console.ReadKey();
            */


            // ReadKey sadece enter basıldığında kodu okumaya devam eder
            /*
            Console.WriteLine("Enter bas");
            while (Console.ReadKey().Key != ConsoleKey.Enter){
                Console.WriteLine(" olmaz enter basman lazım!");
            }
            Console.WriteLine("Enter bastın");
            */


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


            // 2 adet sayı oluştur bu sayıları topla
            /*
            int toplaSayi1 = 5, toplaSayi2 = 10;
            int sonuc;
            sonuc = toplaSayi1 + toplaSayi2;
            Console.WriteLine("Sonuç = " + sonuc);
            */

            // doğum yılı yıl değeri ad soyad değişkenleri oluşturup atamalarını yapalım
            /*
            int guncelYil = 2024, dogumYil = 2004;
            int yas = guncelYil - dogumYil;
            string ad = "Arda", soyad = "Altunel";
            Console.WriteLine("Merhaba benim adım " + ad + " soyadım " + soyad + " yaşım " + yas);
            */

            // takibi kolaylaştırmak için region kullanabilirsin
            /*
            #region Console.ReadLine Tanımı
            Console.WriteLine("ben Console.ReadLine tanımıyım");
            #endregion
            */


            // kullanıcıya yazdırmak
            /*
            string ad;
            Console.Write("Adınızı Giriniz: ");
            ad = Console.ReadLine();

            Console.Write("Soyadınızı Giriniz: ");
            string soyad = Console.ReadLine();

            Console.WriteLine("Senin Adın: " + ad + " " + soyad);
            */


            Console.ReadKey();
        }
    }
}
