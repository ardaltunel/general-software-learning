using System;
using System.Linq;

class KelimeTahminOyunu
{
    static void Main()
    {
        Console.WriteLine("Kelime Tahmin Oyununa Hoş Geldiniz!");

        string[] kelimeler = { "bilgisayar", "programlama", "kitap", "telefon", "merhaba", "araba", "motor", "kasa" };
        Random rastgele = new Random();
        string secilenKelime = kelimeler[rastgele.Next(kelimeler.Length)];
        char[] tahminEdilenHarfler = new char[secilenKelime.Length];

        for (int i = 0; i < tahminEdilenHarfler.Length; i++)
        {
            tahminEdilenHarfler[i] = '_';
        }

        int kalanDenemeHakki = 8;

        while (kalanDenemeHakki > 0)
        {
            Console.WriteLine("\nTahmin edilen kelime: " + string.Join(" ", tahminEdilenHarfler));
            Console.WriteLine($"Kalan deneme hakkınız: {kalanDenemeHakki}");

            Console.Write("Bir harf tahmin edin: ");
            char tahminEdilenHarf;
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (char.IsLetter(keyInfo.KeyChar))
            {
                tahminEdilenHarf = char.ToLower(keyInfo.KeyChar);
                if (secilenKelime.Contains(tahminEdilenHarf))
                {
                    Console.WriteLine("\nTebrikler! Doğru tahmin.");
                    UpdateTahminEdilenHarfler(secilenKelime, tahminEdilenHarfler, tahminEdilenHarf);
                }
                else
                {
                    Console.WriteLine("\nÜzgünüm, yanlış tahmin. Tekrar deneyin.");
                    kalanDenemeHakki--;
                }
            }
            else
            {
                Console.WriteLine("\nLütfen bir harf girin.");
            }

            if (!tahminEdilenHarfler.Contains('_'))
            {
                Console.WriteLine("\nTebrikler! Kelimeyi doğru tahmin ettiniz: " + secilenKelime);
                break;
            }
        }

        if (kalanDenemeHakki == 0)
        {
            Console.WriteLine("\nÜzgünüm, hakkınız bitti. Doğru kelime: " + secilenKelime);
        }

        Console.ReadKey(); // Programın kapanmaması için bekleme
    }

    static void UpdateTahminEdilenHarfler(string kelime, char[] tahminEdilenHarfler, char tahminEdilenHarf)
    {
        for (int i = 0; i < kelime.Length; i++)
        {
            if (kelime[i] == tahminEdilenHarf)
            {
                tahminEdilenHarfler[i] = tahminEdilenHarf;
            }
        }
    }
}
