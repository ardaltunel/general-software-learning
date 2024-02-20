using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Phantaso
{
    public static class Translator
    {
        private const string DeepLApiUrl = "https://api-free.deepl.com/v2/translate";
        private const string DeepLApiKey = "YOUR-API-KEY";

        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task Run()
        {
            Console.WriteLine("Çeviri Uygulamasına Hoş Geldiniz!");

            while (true)
            {
                Console.Write("\nÇevirmek istediğiniz metni girin (Çıkış için 'kapa' yazınız): ");
                string metin = Console.ReadLine();

                if (metin.ToLower() == "kapa")
                {
                    Console.WriteLine("\nÇeviri uygulamasını sonlandırdınız. İyi günler!");
                    break;
                }

                await TranslateAsync(metin);
            }
        }

        private static async Task TranslateAsync(string metin)
        {
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("auth_key", DeepLApiKey),
                new KeyValuePair<string, string>("text", metin),
                new KeyValuePair<string, string>("target_lang", "EN"), // İngilizce
            });

            try
            {
                var response = await _httpClient.PostAsync(DeepLApiUrl, content);
                string result = await response.Content.ReadAsStringAsync();
                var translationResult = Newtonsoft.Json.JsonConvert.DeserializeObject<TranslationResponse>(result);

                if (translationResult.translations != null && translationResult.translations.Count > 0)
                {
                    Console.WriteLine($"\nÇeviri: {translationResult.translations[0].text}");
                }
                else
                {
                    Console.WriteLine($"\nÇeviri başarısız. Hata Kodu: {translationResult.error.code}, Hata Mesajı: {translationResult.error.message}");
                }
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("\nHata: Çeviri servisine ulaşılamıyor. İnternet bağlantınızı kontrol edin.");
            }
        }

        private class TranslationResponse
        {
            public List<Translation> translations { get; set; }
            public Error error { get; set; }
        }

        private class Translation
        {
            public string text { get; set; }
        }

        private class Error
        {
            public int code { get; set; }
            public string message { get; set; }
        }
    }
}
