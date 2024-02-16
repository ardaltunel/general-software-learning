using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_quiz
{
    internal class Program
    {
        static Random random = new Random();
        static int dogruCevaplar = 0;

        static void Main()
        {
            Console.WriteLine("Matematik Oyunu\n");

            for (int i = 1; i <= 5; i++) {
                SoruSor();
            }

            Console.WriteLine($"\nOyun bitti! 5 sorunun {dogruCevaplar} tanesine doğru cevap verdiniz.");
            Console.WriteLine("Programı kapatmak için bir tuşa basın.");
            Console.ReadKey();
        }

        static void SoruSor()
        {
            int sayi1 = random.Next(1, 11);
            int sayi2 = random.Next(1, 11);
            char operatorBelirle = RandomOperatorBelirle();

            Console.Write($"{sayi1} {operatorBelirle} {sayi2} = ");

            if (double.TryParse(Console.ReadLine(), out double kullaniciCevabi)) {
                double dogruSonuc = Hesapla(sayi1, sayi2, operatorBelirle);

                if (kullaniciCevabi == dogruSonuc) {
                    Console.WriteLine("Doğru!\n");
                    dogruCevaplar++;
                } else {
                    Console.WriteLine($"Doğru cevap: {dogruSonuc} olacaktı\n");
                }
            } else {
                Console.WriteLine("Geçersiz giriş! Soru geçiliyor.\n");
            }
        }

        static double Hesapla(int sayi1, int sayi2, char operatorBelirle)
        {
            switch (operatorBelirle)
            {
                case '+':
                    return sayi1 + sayi2;
                case '-':
                    return sayi1 - sayi2;
                case '*':
                    return sayi1 * sayi2;
                case '/':
                    return (double)sayi1 / sayi2;
                default:
                    throw new ArgumentException("Geçersiz operator.");
            }
        }

        static char RandomOperatorBelirle()
        {
            char[] operatorler = { '+', '-', '*', '/' };
            return operatorler[random.Next(operatorler.Length)];
        }
    }
}
