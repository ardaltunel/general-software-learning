using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System;

class Program
{
    private static readonly HttpClient _httpClient = new HttpClient();
    private const string OmdbApiKey = "252f5086";

    static async Task Main()
    {
        Console.WriteLine("OMDB Film Bilgi Uygulamasına Hoş Geldiniz!");

        while (true)
        {
            Console.Write("\nArama yapmak istediğiniz film adını girin (Çıkış için 'kapa' yazınız): ");
            string filmAdi = Console.ReadLine();

            if (filmAdi.ToLower() == "kapa")
            {
                Console.WriteLine("\nOMDB Film Bilgi uygulamasını sonlandırdınız. İyi günler!");
                break;
            }

            await GetMovieInformationAsync(filmAdi);
        }
    }

    private static async Task GetMovieInformationAsync(string filmAdi)
    {
        string apiUrl = $"http://www.omdbapi.com/?t={filmAdi}&apikey={OmdbApiKey}";

        try
        {
            string response = await _httpClient.GetStringAsync(apiUrl);
            JObject filmBilgisi = JObject.Parse(response);

            if (filmBilgisi["Response"].ToString() == "True")
            {
                Console.WriteLine("\nFilm Bilgileri:");
                Console.WriteLine($"Başlık: {filmBilgisi["Title"]}");
                Console.WriteLine($"Yıl: {filmBilgisi["Year"]}");
                Console.WriteLine($"Tür: {filmBilgisi["Genre"]}");
                Console.WriteLine($"Yönetmen: {filmBilgisi["Director"]}");
                Console.WriteLine($"Oyuncular: {filmBilgisi["Actors"]}");
                Console.WriteLine($"IMDb Puanı: {filmBilgisi["imdbRating"]}");
            }
            else
            {
                Console.WriteLine($"\nBöyle bir film bulamadım. Lütfen doğru yazdığınızdan emin olun");
            }
        }
        catch (HttpRequestException)
        {
            Console.WriteLine("\nHata: OMDB'ye ulaşılamıyor. İnternet bağlantınızı kontrol edin.");
        }
    }
}
