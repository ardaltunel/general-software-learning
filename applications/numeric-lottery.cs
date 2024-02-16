using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sayısal Loto Simülasyonuna Hoş Geldiniz!");

        while (true)
        {
            Console.Write("\nOluşturmak istediğiniz loto kuponu adedini girin (Çıkış için 'kapa' yazınız): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "kapa")
            {
                Console.WriteLine("\nLoto Simülasyonunu sonlandırdınız. İyi günler!");
                break;
            }

            if (int.TryParse(input, out int kuponAdedi) && kuponAdedi > 0)
            {
                List<List<int>> kuponlar = GetKuponlar(kuponAdedi);

                List<int> winningNumbers = GenerateRandomNumbers(1, 49, 6, new Random());

                Console.WriteLine($"\n{DateTime.Now} tarihli Loto Çekilişi Sonuçları: {string.Join(", ", winningNumbers.OrderBy(n => n))}\n");

                foreach (var kupon in kuponlar)
                {
                    int tutanSayiSayisi = winningNumbers.Intersect(kupon).Count();

                    Console.WriteLine($"\nKupon: {string.Join(", ", kupon.OrderBy(n => n))}");
                    Console.WriteLine($"Tutan Sayı Sayısı: {tutanSayiSayisi}");
                    Console.WriteLine($"Kazancınız: {CalculateWinnings(tutanSayiSayisi)} TL");
                }
            }
            else
            {
                Console.WriteLine("\nGeçersiz giriş. Lütfen pozitif bir sayı girin.");
            }
        }
    }

    static List<List<int>> GetKuponlar(int kuponAdedi)
    {
        List<List<int>> kuponlar = new List<List<int>>();

        for (int i = 1; i <= kuponAdedi; i++)
        {
            Console.Write($"\n{i}. Kuponu girin (örneğin: 1, 9, 17, 28, 36, 48): ");
            string kuponInput = Console.ReadLine();

            if (TryParseKupon(kuponInput, out List<int> kupon))
            {
                kuponlar.Add(kupon);
            }
            else
            {
                Console.WriteLine("Geçersiz kupon formatı. Lütfen sayıları virgülle ayırarak girin.");
                i--;
            }
        }

        return kuponlar;
    }

    static bool TryParseKupon(string kuponInput, out List<int> kupon)
    {
        kupon = new List<int>();
        string[] numbers = kuponInput.Split(',');

        foreach (string number in numbers)
        {
            if (int.TryParse(number.Trim(), out int parsedNumber))
            {
                kupon.Add(parsedNumber);
            }
            else
            {
                return false;
            }
        }

        return kupon.Count == 6;
    }

    static int CalculateWinnings(int tutanSayiSayisi)
    {
        switch (tutanSayiSayisi)
        {
            case 6:
                return 1000000;
            case 5:
                return 10000;
            case 4:
                return 500;
            case 3:
                return 50;
            default:
                return 0;
        }
    }

    static List<int> GenerateRandomNumbers(int min, int max, int count, Random random)
    {
        HashSet<int> uniqueNumbers = new HashSet<int>();

        while (uniqueNumbers.Count < count)
        {
            uniqueNumbers.Add(random.Next(min, max + 1));
        }

        return uniqueNumbers.ToList();
    }
}
