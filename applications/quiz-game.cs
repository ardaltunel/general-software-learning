using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuizOyunu();

            Console.WriteLine("Oyun bitti. Çıkış yapmak için bir tuşa basın.");
            Console.ReadKey();
        }

        static void QuizOyunu()
        {
            List<Soru> sorular = new List<Soru>
            {
                new Soru("Hangi renk semaforda ilerlemeye işarettir?", "Yeşil"),
                new Soru("Denizlerde yaşayan dev canlılara ne ad verilir?", "Balina"),
                new Soru("Hangi meyve yeşil kabuğa sahiptir?", "Elma"),
                new Soru("Hangi hayvan 'hav hav' sesi çıkarır?", "Köpek"),
                new Soru("Ay'ın ışığını yansıtarak parlamasına ne ad verilir?", "Dolunay"),
                new Soru("Hangi renk gökkuşağında yer almaz?", "Pembe"),
                new Soru("Hangi mevsimde ağaçlar yapraklarını döker?", "Sonbahar"),
                new Soru("Hangi içecek asidik bir yapıya sahiptir?", "Limonata"),
                new Soru("Hangi renk portakalın kabuğunda bulunur?", "Turuncu"),
                new Soru("Hangi hayvanın aslan adıyla anıldığı bir çizgi film vardır?", "Köpek"),
                new Soru("Hangi meyve içerisinde çok sayıda tohum barındırır?", "Karpuz"),
                new Soru("Hangi renk gökyüzünü temsil eder?", "Mavi"),
                new Soru("Hangi meyve kirazın büyük olan türüdür?", "Vişne"),
                new Soru("Hangi hayvanın kuyruğu diğerlerinden farklıdır?", "Kanguru"),
                new Soru("Hangi içecek genellikle sıcak içilir?", "Çay"),
                new Soru("Hangi renk gül 'saf sevgi'yi simgeler?", "Kırmızı"),
                new Soru("Hangi meyve şeklinde bir saat bulunur?", "Portakal"),
                new Soru("Hangi hayvan evimizde genellikle evcil olarak beslenir?", "Kedi"),
                new Soru("Hangi içecek çoğunlukla kahvaltılarda içilir?", "Süt"),
                new Soru("Hangi renk insanların göz rengi olabilir?", "Kahverengi"),
            };

            int toplamPuan = 0;

            Console.WriteLine("Quiz Oyununa Hoş Geldiniz!");

            foreach (var soru in sorular)
            {
                Console.Write(soru.SoruMetni + " : ");
                string cevap = Console.ReadLine();

                if (cevap.ToLower() == soru.DogruCevap.ToLower()) {
                    Console.WriteLine("Doğru Cevap! +5 puan kazandınız\n");
                    toplamPuan += 5;
                } else {
                    Console.WriteLine($"Doğru cevap: {soru.DogruCevap} olacaktı\n");
                }
            }

            Console.WriteLine($"Quiz sona erdi. Toplam puanınız: {toplamPuan}");
        }
    }

    class Soru
    {
        public string SoruMetni { get; }
        public string DogruCevap { get; }

        public Soru(string soruMetni, string dogruCevap)
        {
            SoruMetni = soruMetni;
            DogruCevap = dogruCevap;
        }
    }
}
