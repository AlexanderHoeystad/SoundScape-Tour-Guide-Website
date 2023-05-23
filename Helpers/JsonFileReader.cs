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
          // Gå ind i SoundJson.cs filen inde i Service folderen
          // og ved linje 13 i SoundJson.cs skal du selv finde path fordi .JSON gemmes lokalt
          string jsonString = File.ReadAllText(JsonFileName);
          return JsonConvert.DeserializeObject<Dictionary<int, Sounds>>(jsonString);
       }

    }
}
