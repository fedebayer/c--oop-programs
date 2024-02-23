using Newtonsoft.Json;

namespace ConsoleApp1Serializar
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = @"{
                'Email': 'james@example.com',
                'Active': true,
                'CreatedDate': '2013-01-20T00:00:00Z',
                'Roles': [
                    'User',
                    'Admin'
                    ]
            }";

            Account account = JsonConvert.DeserializeObject<Account>(json);

            Console.WriteLine(account.Email);
            // james@example.com
        }

        public class Account
        {
            public string Email { get; set; }
            public bool Active { get; set; }
            public DateTime CreatedDate { get; set; }
            public IList<string> Roles { get; set; }
        }

    }
}