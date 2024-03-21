using System;
using System.Diagnostics;

namespace Phantaso
{
    internal class Discord_Token_Login
    {
        public static void Run()
        {
            while (true)
            {
                Console.Write("Token (Çıkmak için 'kapa' yazın): ");
                string token = Console.ReadLine();

                if (token.ToLower() == "kapa") {
                    break;
                } else if (token.Length < 50) {
                    Console.WriteLine("En az 50 karakter olmalıdır\n");
                    continue;
                } else {
                    Console.WriteLine("Tarayıcıya yönlendiriliyorsunuz\n");
                }

                string tokenDuzenli = token.Replace(" ", "+");
                OpenInIncognitoMode($"https://discord.com/?discordtoken={tokenDuzenli}");
            }
        }

        static void OpenInIncognitoMode(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true,
                    WindowStyle = ProcessWindowStyle.Minimized
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }
        
    }
}
