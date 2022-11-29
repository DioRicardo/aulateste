using Newtonsoft.Json;
using QuickType;

namespace TesteConexaoAPIZM
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com") };
            var response = await client.GetAsync("users");
            var content = await response.Content.ReadAsStringAsync();

            var users = JsonConvert.DeserializeObject<User[]>(content);
            
            foreach (var item in users)
            {
                Console.Write("Nome do usuário: ");
                Console.WriteLine(item.Name);
                Console.Write("E-mail: ");
                Console.WriteLine(item.Email);
                Console.Write("Telefone: ");
                Console.WriteLine(item.Phone);
                Console.WriteLine("----------------------//----------------------");           
            }

        }
    }
}


