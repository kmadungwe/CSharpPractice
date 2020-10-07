using System;
using System.Net.Http;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using(var httpClient = new HttpClient())
            {
               var response = httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/ditto").Result;
               var data = response.Content.ReadAsStringAsync().Result;
               Console.WriteLine(data);
            }
        }
    }
}
