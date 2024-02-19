using System;
using System.Net.Http;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading.Tasks;

namespace Phantaso
{
    internal class Wikipedia_Info
    {
        public static void Run()
        {
            Console.WriteLine("Wikipedia Bilgi Gösterici");

            while (true)
            {
                Console.Write("\nBilgi almak istediğiniz konuyu girin (Çıkış için 'kapa' yazınız): ");
                string konu = Console.ReadLine();

                if (konu.ToLower() == "kapa")
                {
                    Console.WriteLine("\nWikipedia Bilgi Gösterici uygulamasını sonlandırdınız. İyi günler!");
                    break;
                }

                GetWikipediaInformation(konu).Wait();
            }
        }

        private static async Task GetWikipediaInformation(string konu)
        {
            string apiUrl = $"https://tr.wikipedia.org/w/api.php?action=query&format=json&prop=extracts&titles={konu}&exintro=1";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string response = await client.GetStringAsync(apiUrl);

                    var data = Newtonsoft.Json.JsonConvert.DeserializeObject<WikipediaResponse>(response);
                    var page = data.Query.Pages.Values.FirstOrDefault();

                    if (page != null && !string.IsNullOrEmpty(page.Extract))
                    {
                        CleanAndDisplayText(page.Extract, konu);
                    }
                    else
                    {
                        Console.WriteLine($"\n{konu} konusunda Wikipedia bilgisi bulunamadı.");
                    }
                }
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("\nHata: Wikipedia'ya ulaşılamıyor. İnternet bağlantınızı kontrol edin.");
            }
        }

        private static void CleanAndDisplayText(string html, string konu)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            foreach (var script in doc.DocumentNode.DescendantsAndSelf().Where(n => n.Name == "script" || n.Name == "style").ToArray())
            {
                script.Remove();
            }

            doc.DocumentNode.DescendantsAndSelf()
                .Where(n => n.NodeType == HtmlNodeType.Comment || (n.Name == "div" && n.Attributes["class"]?.Value == "mw-parser-output"))
                .ToList()
                .ForEach(n => n.Remove());

            string cleanedText = doc.DocumentNode.InnerText.Trim();

            cleanedText = Regex.Replace(cleanedText, @"\s+", " ");

            if (string.IsNullOrWhiteSpace(cleanedText))
            {
                Console.WriteLine($"\nBu konuyu getiremiyorum. Lütfen başka bir konu girin.");
            }
            else
            {
                Console.WriteLine($"\n{cleanedText}");
            }
        }

        private class WikipediaResponse
        {
            public QueryContainer Query { get; set; }

            public class QueryContainer
            {
                public System.Collections.Generic.Dictionary<string, WikipediaPage> Pages { get; set; }
            }

            public class WikipediaPage
            {
                public string Extract { get; set; }
            }
        }
    }
}
