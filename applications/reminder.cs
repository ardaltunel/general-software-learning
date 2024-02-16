using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

namespace reminder
{
    class Program
    {
        static Timer hatirlaticiZamanlayici;

        static void Main(string[] args)
        {
            Console.WriteLine("Hatırlatma Uygulaması\n");
            Console.WriteLine("1. Tarih ayarlayın");
            Console.WriteLine("2. Süre ayarlayın");
            Console.Write("Seçiminizi yapın (1-2): ");
            string tercih = Console.ReadLine();

            if (tercih == "1") {
                DateTime hatirlaticiTarihi;
                do {
                    Console.Write("\nHatırlatıcı tarih ve saat girin (örnek: 20.02.2024 14:30): ");
                } while (!DateTime.TryParse(Console.ReadLine(), out hatirlaticiTarihi));
                int hatirlaticiSuresi = (int)(hatirlaticiTarihi - DateTime.Now).TotalMilliseconds;
                TimerCallback hatirlaticiMetodu = new TimerCallback(Hatirlat);
                hatirlaticiZamanlayici = new Timer(hatirlaticiMetodu, null, hatirlaticiSuresi, Timeout.Infinite);
            } else if (tercih == "2") {
                Console.Write("\nHatırlatıcı süresini dakika cinsinden girin: ");
                if (int.TryParse(Console.ReadLine(), out int hatirlaticiDakika)) {
                    int hatirlaticiSuresi = hatirlaticiDakika * 60 * 1000;
                    TimerCallback hatirlaticiMetodu = new TimerCallback(Hatirlat);
                    hatirlaticiZamanlayici = new Timer(hatirlaticiMetodu, null, hatirlaticiSuresi, Timeout.Infinite);
                } else {
                    Console.WriteLine("Geçersiz süre formatı. Program kapatılıyor.");
                    return;
                }
            } else {
                Console.WriteLine("Geçersiz tercih. Program kapatılıyor.");
                return;
            }

            Console.WriteLine("Hatırlatıcı başarıyla ayarlandı.");
            Console.ReadKey();
        }

        static void Hatirlat(object state)
        {
            Console.WriteLine("\nHatırlatıcı zamanı geldi! Yapmanız gerekenleri kontrol edin.");
            SoundPlayer sesCalar = new SoundPlayer(@"C:\Windows\Media\Alarm01.wav");
            sesCalar.Play();
            hatirlaticiZamanlayici.Dispose();
        }
    }
}
