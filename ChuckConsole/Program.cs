using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace ChuckConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = GetJokes();
            Console.WriteLine(message);
            
        }

        public static string GetJokes()
        {
            string url = "http://api.icndb.com/jokes/random";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "Get";


            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                Joke joke = JsonConvert.DeserializeObject<Joke>(response);
                
                Console.WriteLine(joke.value.joke);

                return joke.value.joke;
            }
        }
    }
}
