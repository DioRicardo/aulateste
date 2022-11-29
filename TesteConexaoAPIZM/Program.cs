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
                Console.WriteLine("Próximo usuário:");
                Console.Write("Nome do Cliente: ");
                Console.WriteLine(item.Name);
                Console.Write("E-mail: ");
                Console.WriteLine(item.Email);
                Console.Write("Número de Telefone: ");
                Console.WriteLine(item.Phone);
                Console.Write("Endereço: ");
                Console.WriteLine(item.Address);
                Console.Write("Empresa: ");
                Console.WriteLine(item.Company);
                Console.WriteLine("----------------------//----------------------");                           
            }

        }
    }
}


