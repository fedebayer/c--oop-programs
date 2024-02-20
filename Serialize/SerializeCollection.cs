using Newtonsoft.Json;

namespace ConsoleApp1Serializar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> videogames = new List<string>
            {
                "Starcraft",
                "Halo",
                "Legend of Zelda"
            };

            string json = JsonConvert.SerializeObject(videogames);

            Console.WriteLine(json);
            // ["Starcraft","Halo","Legend of Zelda"]
        }

    }
}