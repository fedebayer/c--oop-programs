using Newtonsoft.Json;

namespace ConsoleApp1Serializar
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = @"['Starcraft','Halo','Legend of Zelda']";

            List<string> videogames = JsonConvert.DeserializeObject<List<string>>(json);

            Console.WriteLine(string.Join(", ", videogames.ToArray()));
            // Starcraft, Halo, Legend of Zelda
        }


    }
}