using Newtonsoft.Json;
using SoundScape_Tour_Guide_Website.Interfaces;
using SoundScape_Tour_Guide_Website.Models;
using SoundScape_Tour_Guide_Website.Pages.Account;
using System.Reflection;

namespace SoundScape_Tour_Guide_Website.Helpers
{
    public class JsonFileReader
    {
       public static Dictionary<int, Sounds> ReadJson(string JsonFileName)
       {
          string jsonString = File.ReadAllText(JsonFileName);
          return JsonConvert.DeserializeObject<Dictionary<int, Sounds>>(jsonString);
       }

    }
}
