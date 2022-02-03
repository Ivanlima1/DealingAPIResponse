using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace playground
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Consumo de API simples e funcional
            const string baseURL = "https://pokeapi.co/api/v2/";

            //baseURL = baseURL + inputWorld;
            var client = new RestClient(baseURL);

            var request = new RestRequest($"/pokemon/ditto", DataFormat.Json);

            var response = client.Get(request);

            var teste = JsonConvert.DeserializeObject<Pokemon>(response.Content);
            

            Console.WriteLine($"'{teste.Id}' - {teste.Name}");


            //TESTE
            const string baseURL2 = "https://api.adviceslip.com";

            //baseURL = baseURL + inputWorld;
            var client2 = new RestClient(baseURL2);

            var request2 = new RestRequest($"/advice", DataFormat.Json);

            var response2 = client2.Get(request2);

            Root teste2 = JsonConvert.DeserializeObject<Root>(response2.Content);

            Console.WriteLine($"{teste2.Slip.advice}");


        }

    }
}
