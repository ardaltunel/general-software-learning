using System;
using System.Collections.Generic;
using System.IO;

namespace todo_list
{
    internal class Program
    {
        static List<string> tasks = new List<string>();
        static string filePath = "tasks.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Basit ToDo List Uygulamasına Hoş Geldiniz!");

            // Önceki görevleri yükle
            LoadTasks();

            // Kapatma işlemi için olay ekle
            Console.CancelKeyPress += new ConsoleCancelEventHandler(Console_CancelKeyPress);

            while (true)
            {
                Console.WriteLine("\nYapılacaklar Seçenekleri:");
                Console.WriteLine("1. Görev Ekle");
                Console.WriteLine("2. Görevleri Listele");
                Console.WriteLine("3. Görev Tamamla");
                Console.WriteLine("4. Kaydet ve Çık");

                Console.Write("Seçiminizi yapın (1-4): ");
                string choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ListTasks();
                        break;
                    case "3":
                        CompleteTask();
                        break;
                    case "4":
                        Console.WriteLine("Görevler kaydediliyor ve uygulamadan çıkılıyor...");
                        SaveTasks(); // Görevleri kaydet
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçenek! Lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Yeni görevi girin: ");
            string newTask = Console.ReadLine();
            tasks.Add(newTask);
            Console.WriteLine("Görev başarıyla eklendi!");
        }

        static void ListTasks()
        {
            Console.WriteLine("Yapılacaklar Listesi:");
            if (tasks.Count > 0)
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
            else
            {
                Console.WriteLine("Listede hiç görev yok.");
            }
        }

        static void CompleteTask()
        {
            if (tasks.Count > 0)
            {
                ListTasks();

                Console.Write("Tamamlanan görevin numarasını girin: ");
                if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
                {
                    Console.WriteLine($"'{tasks[taskNumber - 1]}' görevi tamamlandı!");
                    tasks.RemoveAt(taskNumber - 1);
                    SaveTasks(); // Görevleri kaydet
                }
                else
                {
                    Console.WriteLine("Geçersiz görev numarası!");
                }
            }
            else
            {
                Console.WriteLine("Listede hiç görev yok.");
            }
        }

        static void SaveTasks()
        {
            try
            {
                File.WriteAllLines(filePath, tasks);
                Console.WriteLine("Görevler dosyaya kaydedildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }

        static void LoadTasks()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    tasks = new List<string>(File.ReadAllLines(filePath));
                    // Console.WriteLine("Görevler başarıyla yüklendi.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: {ex.Message}");
                }
            }
        }

        // Program kapatıldığında veya çıkış seçeneği seçildiğinde çağrılan olay işleyicisi
        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("Uygulamadan çıkılıyor...");
            SaveTasks(); // Görevleri kaydet
        }
    }
}
