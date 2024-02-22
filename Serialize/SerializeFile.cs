using Newtonsoft.Json;

namespace ConsoleApp1Serializar
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie
            {
                Name = "Bad Boys",
                Year = 1995
            };

            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@"[CHANGE PATH]\movie.json", JsonConvert.SerializeObject(movie));

            // serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(@"[CHANGE PATH]\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, movie);
            }
        }

        public class Movie
        {
            public string Name { get; set; }
            public int Year { get; set; }
        }

    }
}
// example path:
//C:\Users\Federico\Downloads\to-send