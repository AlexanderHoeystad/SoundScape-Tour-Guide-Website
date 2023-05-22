using Newtonsoft.Json;
using SoundScape_Tour_Guide_Website.Interfaces;
using SoundScape_Tour_Guide_Website.Models;
using SoundScape_Tour_Guide_Website.Pages.Account;
using System.Reflection;
namespace SoundScape_Tour_Guide_Website.Helpers
{
    public class JsonFileWriter
    {
        public static void WriteToJson(Dictionary<int, Sounds> pizzas, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(pizzas,
                                                               Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(JsonFileName, output);
        }

    }
}
