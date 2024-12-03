using System.Net;
using System.Net.Http;

namespace MyApp
{


    class App
    {
        public async static Task Main()
        {
           
            HttpClientHandler handler = new HttpClientHandler()
            {
                Proxy = new WebProxy(new Uri("http://127.0.0.1:8080"))
            };
            HttpClient client = new HttpClient(handler);
            client.DefaultRequestHeaders.Add("User-Agent","Mozilla Firefox");
            var data = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                {"data","any thing"}
            });
            var response = await client.PostAsync(new Uri("http://testphp.vulnweb.com"),data);
            Console.WriteLine(response.Headers.Server);


        }
    }
}

