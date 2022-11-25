/***using Newtonsoft.Json;
using QuickType;

namespace TesteConexaoAPIZM
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string servidorZm = "192.168.2.129";
            string UrlListMonitors = "http:" + servidorZm + "/zm/api/monitors.json?";
            string token = "api/monitors.json?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJab25lTWluZGVyIiwiaWF0IjoxNjY4NDI4MjM3LCJleHAiOjE2Njg0MzU0MzcsInVzZXIiOiJhZG1pbiIsInR5cGUiOiJhY2Nlc3MifQ.vMMUVzrwZ2K2lebx5KKldlnXrU9qpkyVs5Aig2pDGLo";



            HttpClient client = new HttpClient { BaseAddress = new Uri("http://192.168.2.129/zm") };
            var response = await client.GetAsync("api/monitors.json?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJab25lTWluZGVyIiwiaWF0IjoxNjY4NDI4MjM3LCJleHAiOjE2Njg0MzU0MzcsInVzZXIiOiJhZG1pbiIsInR5cGUiOiJhY2Nlc3MifQ.vMMUVzrwZ2K2lebx5KKldlnXrU9qpkyVs5Aig2pDGLo");
            var content = await response.Content.ReadAsStringAsync();

            var users = JsonConvert.DeserializeObject<User[]>(content);

            Console.WriteLine(users);
            
            foreach (var item in users)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Email);                
            }

        }
    }
} **/


internal interface IRestResponse
{
    bool Content { get; }
}