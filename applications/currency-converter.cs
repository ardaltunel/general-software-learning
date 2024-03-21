using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Phantaso
{
    internal class Currency_Converter
    {
        private const string ApiKey = "YOUR-API-KEY";

        public static void Run()
        {
            Console.WriteLine("Döviz Çevirici Uygulamasına Hoş Geldiniz!\n");

            while (true)
            {
                Console.Write("Çevirmek istediğiniz miktarı girin (Çıkış için 'kapa' yazınız): ");
                string amountInput = Console.ReadLine();

                if (amountInput.ToLower() == "kapa")
                {
                    Console.WriteLine("Döviz Çevirici uygulamasını sonlandırdınız. İyi günler!");
                    break;
                }

                if (double.TryParse(amountInput, out double amount))
                {
                    Console.Write("Dönüştürmek istediğiniz para birimini girin (TRY, USD, EUR): ");
                    string fromCurrency = Console.ReadLine().ToUpper();

                    Console.Write("Çevirmek istediğiniz para birimini girin (TRY, USD, EUR): ");
                    string toCurrency = Console.ReadLine().ToUpper();

                    double result = ConvertCurrency(amount, fromCurrency, toCurrency);
                    Console.WriteLine($"\n{amount} {fromCurrency} = {result} {toCurrency}\n");
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen miktarı doğru bir şekilde girin.");
                }
            }
        }

        private static double ConvertCurrency(double amount, string fromCurrency, string toCurrency)
        {
            string apiUrl = $"https://api.exchangerate-api.com/v4/latest/{fromCurrency}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = client.GetStringAsync(apiUrl).Result;
                    JObject exchangeRates = JObject.Parse(response);

                    double exchangeRate = (double)exchangeRates["rates"][toCurrency];
                    return amount * exchangeRate;
                }
                catch (HttpRequestException)
                {
                    Console.WriteLine("Hata: Döviz kurları alınamıyor. İnternet bağlantınızı kontrol edin.");
                    return 0;
                }
            }
        }
    }
}
