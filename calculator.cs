using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gelişmiş Hesap Makinesi");

            do
            {
                Console.WriteLine("\nİşlem Seçin:");
                Console.WriteLine("1. Toplama");
                Console.WriteLine("2. Çıkartma");
                Console.WriteLine("3. Çarpma");
                Console.WriteLine("4. Bölme");
                Console.WriteLine("5. Çıkış");

                Console.Write("Seçiminizi yapın (1-5): ");
                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    Console.WriteLine("Çıkılıyor...");
                    break;
                }

                if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    continue;
                }

                Console.Write("Birinci sayıyı girin: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İkinci sayıyı girin: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case "1":
                        result = num1 + num2;
                        break;
                    case "2":
                        result = num1 - num2;
                        break;
                    case "3":
                        result = num1 * num2;
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Hata: Sıfıra bölme hatası");
                            continue;
                        }
                        break;
                }

                Console.WriteLine($"Sonuç: {result}");

                Console.Write("Yeni bir işlem yapmak için herhangi bir tuşa basın, çıkmak için '5' tuşuna basın: ");
            } while (Console.ReadLine() != "55");
        }
    }
}
