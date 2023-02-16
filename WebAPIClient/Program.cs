using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebAPIClient
{
    class Dictionary
    {
        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("meanings")]
        public List<Meanings> MeaningsList { get; set; }

        [JsonProperty("license")]
        public Licenses Licenses { get; set; }
    }

    class Meaning
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    class Definitions
    {
        [JsonProperty("definition")]
        public string Definition { get; set; }
    }

    class Meanings
    {
        [JsonProperty("partOfSpeech")]
        public string PartOfSpeech { get; set; }

        [JsonProperty("definitions")]
        public List<Definitions> Definitions { get; set; }
    }

    class Licenses
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            await ProcessRepositories();
        }

        private static async Task ProcessRepositories()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter word to search in dictionary. Press Enter twice to exit! ");
                    var term = Console.ReadLine();
                    if (string.IsNullOrEmpty(term))
                    {
                        break;
                    }

                    var result = await client.GetAsync("https://api.dictionaryapi.dev/api/v2/entries/en/" + term);
                    var resultRead = await result.Content.ReadAsStringAsync();
                    //Console.WriteLine(resultRead);
                    //var resultRead = result1.Substring(1, result1.Length - 2);

                    //var dictionary = JsonConvert.DeserializeObject(resultRead);
                    var dictionary = JsonConvert.DeserializeObject<List<Dictionary>>(resultRead);
                    //Console.WriteLine(dictionary.ToString());
                    Console.WriteLine("--------\n");
                    Console.WriteLine("Num: " + dictionary[0].Word);
                    //Console.WriteLine("Num: " + dictionary[0].MeaningsList[0].PartOfSpeech);
                    dictionary[0].MeaningsList.ForEach(t =>
                    {
                        Console.WriteLine("Part of Speech: " + t.PartOfSpeech);
                        t.Definitions.ForEach(s => Console.WriteLine("   -> " + s.Definition));
                        Console.WriteLine("\n");
                    });

                    Console.WriteLine("Name: " + dictionary[0].Licenses.Name + "   URL: " + dictionary[0].Licenses.URL);
                    Console.WriteLine("\n-------");
                }
                catch (Exception)
                {
                    Console.WriteLine("Error not valid");
                }
            }
        }
    }
}