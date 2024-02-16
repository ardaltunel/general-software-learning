using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_generator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Gelişmiş Şifre Oluşturucu");

            Console.Write("Şifre uzunluğunu girin: ");
            if (!int.TryParse(Console.ReadLine(), out int uzunluk) || uzunluk <= 0) {
                Console.WriteLine("Geçersiz şifre uzunluğu. Program kapatılıyor.");
                return;
            }

            Console.WriteLine("\nLütfen aşağıdaki karakter tiplerinden bir veya birkaçını seçin:");
            Console.WriteLine("1. Harf (ABCabc)");
            Console.WriteLine("2. Sayı (123456)");
            Console.WriteLine("3. Özel Karakter (!@#$%^&*)");

            Console.Write("Seçtiğiniz karakter tiplerini sırasıyla yazın (örneğin 123): ");
            string karakterSecim = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(karakterSecim) || !KarakterSecimiGecerliMi(karakterSecim)) {
                Console.WriteLine("Geçersiz karakter tipleri. Program kapatılıyor.");
                return;
            }

            string sifre = SifreOlustur(uzunluk, karakterSecim);
            Console.WriteLine($"\nOluşturulan Şifre: {sifre}");

            Console.Write("\nProgramı kapatmak için bir tuşa basın.");
            Console.ReadKey();
        }

        static bool KarakterSecimiGecerliMi(string secim)
        {
            foreach (char karakter in secim) {
                if (karakter < '1' || karakter > '3') {
                    return false;
                }
            }
            return true;
        }

        static string SifreOlustur(int uzunluk, string karakterSecim)
        {
            StringBuilder sifre = new StringBuilder();
            Random random = new Random();

            const string harfler = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            const string sayilar = "0123456789";
            const string ozelKarakterler = "!@#$%^&*";

            foreach (char secim in karakterSecim) {
                string karakterSeti = "";

                switch (secim) {
                    case '1':
                        karakterSeti += harfler;
                        break;
                    case '2':
                        karakterSeti += sayilar;
                        break;
                    case '3':
                        karakterSeti += ozelKarakterler;
                        break;
                }

                sifre.Append(karakterSeti[random.Next(karakterSeti.Length)]);
            }

            while (sifre.Length < uzunluk) {
                string tumKarakterler = harfler + sayilar + ozelKarakterler;
                sifre.Append(tumKarakterler[random.Next(tumKarakterler.Length)]);
            }

            return Karistir(sifre.ToString());
        }

        static string Karistir(string str)
        {
            char[] karakterler = str.ToCharArray();
            Random random = new Random();

            for (int i = karakterler.Length - 1; i > 0; i--) {
                int r = random.Next(0, i + 1);
                char temp = karakterler[i];
                karakterler[i] = karakterler[r];
                karakterler[r] = temp;
            }

            return new string(karakterler);
        }
    }
}
