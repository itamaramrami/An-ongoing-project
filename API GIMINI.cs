using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DotNetEnv;

namespace An_ongoing_project
{
    class ApiGemini
    {
        public static async Task CallApiGemini()
        {
            Console.WriteLine("=== Welcome to Gemini! ===");
            Env.Load();
            string apiKey = Environment.GetEnvironmentVariable("API_KEY");

            if (string.IsNullOrEmpty(apiKey))
            {
                Console.WriteLine("API Key is not set in .env file.");
                return;
            }

            Console.WriteLine("Ask me any question and i will answer you! ");
            string promt = Console.ReadLine();
            string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key={apiKey}";

            var requestBody = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[]
                        {
                            new { text = promt }
                        }
                    }
                }
            };

            var json = JsonConvert.SerializeObject(requestBody);

            HttpClient httpClient = new HttpClient();
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                Console.WriteLine("Gemini thinking...");
                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    JObject parsed = JObject.Parse(responseString);
                    string resultText = parsed["candidates"]?[0]?["content"]?["parts"]?[0]?["text"]?.ToString();
                    Console.WriteLine("Gemini Answer:");
                    Console.WriteLine(resultText ?? "(No response text found)\n");
                }
                else
                {
                    Console.WriteLine($"Request failed. Status code: {response.StatusCode}");
                    Console.WriteLine($"Error details: {responseString}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message}");
            }
        }
    }
}
