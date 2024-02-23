using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev 1
            #region 1). Girilen sayının tek ya da çift olduğunu gösteren örneği oluşturunuz
            /*
            Console.Write("Bir Sayı Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi % 2 == 0) {
                Console.WriteLine("Girilen Sayı Çifttir");
            } else if (sayi % 2 == 1) {
                Console.WriteLine("Girilen Sayı Tektir");
            } else {
                Console.WriteLine("Beklenmedik Bir Hata Oldu");
            }
            */
            #endregion
            
            #region 2). Girilen sayı çift ise yarısını, tek ise 2 katını alarak ekrana yazdıran program
            /*
            Console.Write("Bir Sayı Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi % 2 == 0) {
                Console.WriteLine("Bölme Sonucu: " + sayi / 2);
            }
            else if (sayi % 2 == 1) {
                Console.WriteLine("Çarpım sonucu: " + sayi * 2);
            } else {
                Console.WriteLine("Beklenmedik Bir Hata Oldu");
            }
            */
            #endregion
            
            #region 3). Kullanıcıdan 2 tane sayı isteyerek 1. sayının 2. sayıya tam bölünmesi durumunda "Tam Bölünüyor" yazan, aksi durumda "Tam bölünmüyor" diyerek kalanı ekranda gösteren program 
            /*
            Console.WriteLine("Lütfen 2 Sayı Giriniz");
            Console.Write("Birinci Sayıyı Giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine()); 
            if (sayi2 != 0) {
                double bolmeSonuc = (double)sayi1 / sayi2;

                if (bolmeSonuc % 1 == 0) {
                    Console.WriteLine(sayi1 + " sayısı " + sayi2 + " sayısına tam bölünüyor.");
                } else {
                    Console.WriteLine(sayi1 + " sayısı " + sayi2 + " sayısına tam bölünmüyor. Kalan: " + bolmeSonuc % 1);
                }
            } else {
                Console.WriteLine("Bir sayıyı 0'a bölemezsiniz. İkinci sayıyı 0'dan farklı bir değer girin.");
            }
            */
            #endregion
            
            #region 4.) Klavyeden girilen bir sayının seçime bağlı olarak karesini, küpünü ve karekökünü alan programı yazınız.
            /*
            Console.Write("Bir sayı giriniz: ");
            if (double.TryParse(Console.ReadLine(), out double sayi)) {
                Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1. Kare");
                Console.WriteLine("2. Küp");
                Console.WriteLine("3. Karekök");

                Console.Write("Seçiminizi yapın (1-3): ");
                string secim = Console.ReadLine();

                if (secim == "1") {
                    Console.WriteLine("Girilen sayının karesi: " + Math.Pow(sayi, 2));
                } else if (secim == "2") {
                    Console.WriteLine("Girilen sayının küpü: " + Math.Pow(sayi, 3));
                } else if (secim == "3") {
                    if (sayi >= 0) {
                        Console.WriteLine("Girilen sayının karekökü: " + Math.Sqrt(sayi));
                    } else {
                        Console.WriteLine("Negatif bir sayının karekökü yoktur.");
                    }
                }  else {
                    Console.WriteLine("Geçersiz seçenek!");
                }
            } else {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
            }
            */
            #endregion
            
            #region 5.) Girilen tam bir sayının 3'e ve 5'e tam olarak bölünebiliyor mu? bulan programı yazınız.
            /*
            Console.Write("Bir sayı giriniz: ");
            if (int.TryParse(Console.ReadLine(), out int sayi)) {
                if (sayi % 3 == 0 && sayi % 5 == 0) {
                    Console.WriteLine(sayi + " sayısı hem 3'e hem de 5'e tam olarak bölünebilir.");
                } else {
                    Console.WriteLine(sayi + " sayısı hem 3'e hem de 5'e tam olarak bölünemez.");
                }
            } else {
                Console.WriteLine("Geçersiz giriş. Lütfen bir tam sayı girin.");
            }
            */
            #endregion
            
            #region 6.) Ehliyet sınavı için yaşı 18 ve üzeri olanlar için başvuru yapabileceklerini, 18 yaşın altında ise kaç yıl sonra ehliyet alabileceğini ekrana yazan c# kodlarını yazınız.
            /*
            Console.Write("Yaşınızı giriniz: ");
            if (int.TryParse(Console.ReadLine(), out int yas) && yas >= 0) {
                if (yas >= 18) {
                    Console.WriteLine("Ehliyet başvurusu yapabilirsiniz.");
                } else {
                    int kacYilSonraEhliyetAlabilir = 18 - yas;
                    Console.WriteLine("Ehliyet başvurusu yapabilmek için " + kacYilSonraEhliyetAlabilir + " yıl beklemeniz gerekiyor.");
                }
            } else {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir yaş değeri girin.");
            }
            */
            #endregion
            
            #region 7.) Bir kişi mağazadan 100 TL ve üzeri alışveriş yaparsa %10 indirim, 200TL ve üzeri alışveriş yaparsa %15 indirim, 300TL ve üzeri alışveriş yaparsa %20 indirim kazandığını ve ödeyeceği miktarı ekrana yazan C# kodlarını yazınız.
            /*
            Console.Write("Alışveriş tutarınızı giriniz: ");
            if (double.TryParse(Console.ReadLine(), out double alisverisTutari) && alisverisTutari >= 0) {
                double indirimOrani = 0;

                if (alisverisTutari >= 300) {
                    indirimOrani = 0.20;
                }
                else if (alisverisTutari >= 200) {
                    indirimOrani = 0.15;
                }
                else if (alisverisTutari >= 100) {
                    indirimOrani = 0.10;
                }

                double indirimMiktari = alisverisTutari * indirimOrani;
                double odenecekMiktar = alisverisTutari - indirimMiktari;

                Console.WriteLine("Yaptığınız alışveriş tutarı: " + alisverisTutari + " TL");
                Console.WriteLine("İndirim oranı: %" + (indirimOrani * 100));
                Console.WriteLine("İndirim miktarı: " + indirimMiktari + " TL");
                Console.WriteLine("Ödemeniz gereken miktar: " + odenecekMiktar + " TL");
            } else {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir alışveriş tutarı girin.");
            }
            */
            #endregion
            
            #region 8) :Klavyeden girilen öğrenci notuna göre harf notunu yazdıran program. Koşullar (0-39 = F, 40-59 = E, 60-60 = D, 70-79 = C, 80-89 = B, 90,100 = A)
            /*
            Console.Write("Öğrenci notunu giriniz: ");
            if (int.TryParse(Console.ReadLine(), out int ogrenciNotu) && ogrenciNotu >= 0 && ogrenciNotu <= 100)
            {
                string harfNotu = "";
                if (ogrenciNotu >= 90 && ogrenciNotu <= 100) {
                    harfNotu = "A";
                } else if (ogrenciNotu >= 80 && ogrenciNotu < 90) {
                    harfNotu = "B";
                } else if (ogrenciNotu >= 70 && ogrenciNotu < 80) {
                    harfNotu = "C";
                } else if (ogrenciNotu >= 60 && ogrenciNotu < 70) {
                    harfNotu = "D";
                } else if (ogrenciNotu >= 40 && ogrenciNotu < 60) {
                    harfNotu = "E";
                } else {
                    harfNotu = "F";
                }
                Console.WriteLine("Öğrenci notu: " + ogrenciNotu + ", Harf notu: " + harfNotu);
            } else {
                Console.WriteLine("Geçersiz giriş. Lütfen 0-100 arasında bir sayı girin.");
            }
            */
            #endregion
           
            #region 9.) Bir otoparkta saate göre ödenecek tutarı ekrana yazan program (0-3 saat 10₺, 4-6 saat 15₺, 7 saat ve üzeri 20₺)
            /*
            Console.Write("Otoparkta kaç saat kalındı: ");
            if (int.TryParse(Console.ReadLine(), out int kalinmaSuresi) && kalinmaSuresi >= 0) {
                int odemeTutari = 0;
                if (kalinmaSuresi <= 3) {
                    odemeTutari = 10;
                } else if (kalinmaSuresi <= 6) {
                    odemeTutari = 15;
                } else {
                    odemeTutari = 20;
                }
                Console.WriteLine($"Ödeme tutarı: {odemeTutari} TL");
            } else {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin.");
            }
            */
            #endregion
            
            #region 10.) Aylık elektrik faturası hesaplanacaktır. Kullanıcıdan kaç kWh tükettiğini alınız. Eğer tüketim 150' den küçükse kWh'i 20 kuruş, eğer 150 ile 300 arsında ise 30 kuruş, 300 ve üzeri ise 50 kuruş olarak hesaplanmaktadır. Kişilerin yaptığı tüketime göre faturasının kaç TL olacağını hesaplayıp ekrana yazdırınız
            /*
            Console.Write("Aylık kaç kWh tükettiğinizi giriniz: ");
            if (int.TryParse(Console.ReadLine(), out int tuketim) && tuketim >= 0) {
                double birimFiyat = 0.0;

                if (tuketim < 150) {
                    birimFiyat = 0.20;
                } else if (tuketim <= 300) {
                    birimFiyat = 0.30;
                } else {
                    birimFiyat = 0.50;
                } 
                double faturaTutari = tuketim * birimFiyat;
                Console.WriteLine("Aylık elektrik faturası: " + faturaTutari + " TL");
            } else {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin.");
            }
            */
            #endregion


            // Ödev 2
            #region 1-) Kullanıcıdan 1 adet sayı talep edin, kullanıcı 5 in katı bir sayı girmezse program kullanıcıdan tekrar tekrar sayı istesin.
            /*
            int kullaniciSayi;
            do {
                Console.Write("Lütfen 5'in katı bir sayı girin: ");
                string kullaniciGiris = Console.ReadLine();

                if (int.TryParse(kullaniciGiris, out kullaniciSayi) && kullaniciSayi % 5 == 0) {
                    Console.Write($"{kullaniciSayi} sayısı 5'in katı bir sayıdır");
                    break;
                } else {
                    Console.WriteLine("Geçerli bir sayı girmediniz veya 5'in katı bir sayı değil ");
                }
            } while (true);
            */
            #endregion
            
            #region 2-) Kullanıcı için kayıt ve giriş ekranının kodlarının olduğu bir uygulama yapılacak. Kayıt ekranına hoşgeldiniz yazısı gelsin Kullanıcı adı ve şifre talep edelim. Daha sonra Kayıt Başarılı oldu yazısı gelsin Daha sonra giriş için kullanıcı adı ve şifre talep edelim Kayıt olurken girilen kullanıcı adı ve şifre ile giriş yaparken girilen kullanıcı adı ve şifre eşleşiyorsa "Giriş Başarılı" desin. Eğer Eşleşme sağlanmadıysa "Yanlış Kullanıcı Adı veya Şifre" diyelim ve Tekrar girişi için kullanıcı adı ve şifre talep edelim
            /*
            Console.WriteLine("Kayıt Ekranına Hoşgeldiniz!");
            Dictionary<string, string> kullaniciBilgileri = new Dictionary<string, string>();
            Console.Write("Kullanıcı adı: ");
            string kullaniciAdi = Console.ReadLine();
            Console.Write("Şifre: ");
            string sifre = Console.ReadLine();

            if (!kullaniciBilgileri.ContainsKey(kullaniciAdi)) {
                kullaniciBilgileri.Add(kullaniciAdi, sifre);
                Console.WriteLine("Kayıt başarılı!\n");

                Console.WriteLine("Giriş Ekranına Hoşgeldiniz!");
                string girisSifre;

                do
                {
                    Console.Write("Kullanıcı adı: ");
                    string girisKullaniciAdi = Console.ReadLine();
                    Console.Write("Şifre: ");
                    girisSifre = Console.ReadLine();

                    if (kullaniciBilgileri.TryGetValue(girisKullaniciAdi, out string kayitliSifre) && kayitliSifre == girisSifre) {
                        Console.WriteLine("Giriş başarılı!");
                        break;
                    } else {
                        Console.WriteLine("Yanlış kullanıcı adı veya şifre girdiniz\n");
                    }
                } while (true);
            } else {
                Console.WriteLine("Hata");
            }
            */
            #endregion
           
            #region 3-) Kullanıcıdan 2 adet sayı talep edelim. daha sonra şöyle bir listeyi karşısına çıkaralım 1) Toplama 2) Çıkarma 3) Çarpma 4) Bölme 5)Çıkış . Kullanıcının yapmış olduğu seçime göre işlem ve işlem sonucunu döndürelim Kullanıcı eğer Çıkış seçeneğini seçmezse tekrardan bu işlemleri yaptıralım
            /*
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Lütfen iki sayı girin:");
                Console.Write("Birinci sayı: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci sayı: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nİşlem seçenekleri:");
                Console.WriteLine("1) Toplama");
                Console.WriteLine("2) Çıkarma");
                Console.WriteLine("3) Çarpma");
                Console.WriteLine("4) Bölme");
                Console.Write("Seçiminizi yapın (1-4): ");
                int secim = Convert.ToInt32(Console.ReadLine());
                double sonuc = 0;

                switch (secim)
                {
                    case 1:
                        sonuc = sayi1 + sayi2;
                        Console.WriteLine($"Toplama sonucu: {sonuc}");
                        break;
                    case 2:
                        sonuc = sayi1 - sayi2;
                        Console.WriteLine($"Çıkarma sonucu: {sonuc}");
                        break;
                    case 3:
                        sonuc = sayi1 * sayi2;
                        Console.WriteLine($"Çarpma sonucu: {sonuc}");
                        break;
                    case 4:
                        if (sayi2 != 0)
                        {
                            sonuc = sayi1 / sayi2;
                            Console.WriteLine($"Bölme sonucu: {sonuc}");
                        }
                        else
                        {
                            Console.WriteLine("Hata: Sayı 2 sıfıra bölünemez.");
                        }
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek. Lütfen 1 ile 5 arasında bir seçenek girin.");
                        break;
                }

                Console.WriteLine("\nDevam etmek için bir tuşa basın");
                Console.WriteLine("Cıkmak için 'q' tuşuna basın");
                if (Console.ReadKey().KeyChar == 'q')
                    break;
            }
            */
            #endregion
           
            #region 4-) Kullanıcıdan sayı talep edin 0 dışında bir sayı girdiği sürece sayı istemeye devam eden ve girmiş olduğu sayıları toplayan , 0 girdiğinde ise  daha önceden girmiş olduğu sayıların toplamını ekrana yazdıran bir program yapınız
            /*
            int toplam = 0;
            Console.WriteLine("Girilen sayıları toplarsınız");
            while (true)
            {
                Console.Write("Sayı girin (0 yazarsanız sonucu gösterir): ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == 0) {
                    break;
                }

                toplam += sayi;
            }
            Console.WriteLine($"Girilen sayıların toplamı: {toplam}");
            */
            #endregion

            Console.ReadKey();
        }
    }
}
