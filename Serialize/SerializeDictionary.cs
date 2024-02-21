using Newtonsoft.Json;

namespace ConsoleApp1Serializar
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> points = new Dictionary<string, int>
            {
                { "James", 9001 },
                { "Jo", 3474 },
                { "Jess", 11926 }
            };

            string json = JsonConvert.SerializeObject(points, Formatting.Indented);

            Console.WriteLine(json);
            // {
            //   "James": 9001,
            //   "Jo": 3474,
            //   "Jess": 11926
            // }
        }

    }
}